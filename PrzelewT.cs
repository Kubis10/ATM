using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class PrzelewT : Form
    {
        public PrzelewT()
        {
            InitializeComponent();
        }

        public static bool tel = false;
        private static string knt;

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Przelewy przelewy = new Przelewy();
            przelewy.Show();
            this.Hide();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            string provider = ConfigurationManager.AppSettings["provider"];

            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    Console.WriteLine("Connection Error");
                    Console.ReadLine();
                    return;
                }

                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    Console.WriteLine("Command Error");
                    Console.ReadLine();
                    return;
                }

                command.Connection = connection;

                command.CommandText = ("Select [CardID] From [Users] where Tel = '" + t_box.Value + "'");

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        PrzelewT.tel = true;
                        PrzelewT.knt = $"{dataReader["CardID"]} ";

                    }
                }
            }
            if (PrzelewT.tel == true)
            {
                string connetionString = null;
                string sql = null;

                connetionString = "Data Source=GAMEING-DESKTOP\\SQLEXPRESS;Initial Catalog=bankomatDB;Integrated Security=True;Pooling=False";

                sql = "update [Users] set [Money] -= @money where CardID = @CardId";

                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    try
                    {
                        cnn.Open();

                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.Add("@money", SqlDbType.NVarChar).Value = Math.Round(kwota.Value, 2);
                            cmd.Parameters.Add("@CardId", SqlDbType.NVarChar).Value = Program.globalCardId;

                            int rowsAdded = cmd.ExecuteNonQuery();
                            if (rowsAdded > 0)
                            {
                                Console.WriteLine("Odebrano");
                            }
                            else
                                MessageBox.Show("Wystąpił problem spróbuj ponownie później");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.Message);
                    }
                }
                sql = "update [Users] set [Money] += @money where Tel = @Tel";

                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    try
                    {
                        cnn.Open();

                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.Add("@money", SqlDbType.NVarChar).Value = Math.Round(kwota.Value, 2);
                            cmd.Parameters.Add("@tel", SqlDbType.NVarChar).Value = t_box.Value;

                            int rowsAdded = cmd.ExecuteNonQuery();
                            if (rowsAdded > 0)
                            {
                                Console.WriteLine("Zabranov2");
                            }
                            else
                                MessageBox.Show("Wystąpił problem spróbuj ponownie później");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.Message);
                    }
                }
                sql = "insert into Historia (card_out, card_in, opis, money) values (@cardout, @cardout, 'Przelew na telefon', @Money)";
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    try
                    {
                        cnn.Open();

                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.Add("@money", SqlDbType.NVarChar).Value = Math.Round(kwota.Value, 2);
                            cmd.Parameters.Add("@cardout", SqlDbType.NVarChar).Value = Program.globalCardId;
                            cmd.Parameters.Add("@cardin", SqlDbType.NVarChar).Value = knt;

                            int rowsAdded = cmd.ExecuteNonQuery();
                            if (rowsAdded > 0)
                            {
                                MessageBox.Show("Przelew udany!");
                                Menu menu = new Menu();
                                menu.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("Wystąpił problem spróbuj ponownie później");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie znaleziono takiego użytkownika!", "Error");
            }
        }

        private void PrzelewT_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (Program.theme == false)
            {
                Color Warn1Color = Color.FromArgb(70, 70, 70);
                this.BackColor = Warn1Color;
            }
            else
            {
                this.BackColor = Control.DefaultBackColor;
            }
        }
    }
}
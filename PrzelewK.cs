using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class PrzelewK : Form
    {
        public PrzelewK()
        {
            InitializeComponent();
        }

        public static bool konto = false;

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

                command.CommandText = ("Select [Pin] From [Users] where CardID = '" + k_box.Text + "'");

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        PrzelewK.konto = true;
                    }
                }
            }
            if (PrzelewK.konto == true)
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
                                Console.WriteLine("Zabrano");
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
                sql = "update [Users] set [Money] += @money where CardID = @cardId";

                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    try
                    {
                        cnn.Open();

                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.Add("@money", SqlDbType.NVarChar).Value = Math.Round(kwota.Value, 2);
                            cmd.Parameters.Add("@cardId", SqlDbType.NVarChar).Value = k_box.Text;

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
                MessageBox.Show("Nie znaleziono podanego użytkownika");
            }
        }
    }
}
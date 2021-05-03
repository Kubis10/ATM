using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Transakcje : Form
    {
        public Transakcje()
        {
            InitializeComponent();
        }

        public static int ile = 0;
        public static int i = 1;
        public string kasa;

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void nr_btn_Click(object sender, EventArgs e)
        {
            tranz_box.Hide();
            nr_btn.Hide();
            label1.Hide();
            Transakcje.ile = (int)tranz_box.Value;
            next_btn.Visible = true;
            ammo_box.Visible = true;
            label2.Visible = true;
            label2.Text = "Podaj cene " + i + " rachunku:";
        }

        private void next_btn_Click(object sender, EventArgs e)
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

                    command.CommandText = ("Select [Money] From [Users] where CardID = " + Program.globalCardId);

                    using (DbDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                        kasa = ($"{dataReader["Money"]}");
                        kasa = kasa.Substring(0, kasa.Length - 2);
                    }
                    }
                }
                double userVal = double.Parse(ammo_box.Text);

                double monwyVal = double.Parse(kasa);

                if (monwyVal - userVal > 0)
                {
                    string connetionString = null;
                    string sql = null;

                    connetionString = "Data Source=GAMEING-DESKTOP\\SQLEXPRESS;Initial Catalog=bankomatDB;Integrated Security=True;Pooling=False";

                    sql = "update [Users] set [Money] -= @Money where CardID = @CardId";

                    using (SqlConnection cnn = new SqlConnection(connetionString))
                    {
                        try
                        {
                            cnn.Open();

                            using (SqlCommand cmd = new SqlCommand(sql, cnn))
                            {
                                cmd.Parameters.Add("@Money", SqlDbType.NVarChar).Value = userVal;
                                cmd.Parameters.Add("@CardId", SqlDbType.NVarChar).Value = Program.globalCardId;

                                int rowsAdded = cmd.ExecuteNonQuery();
                                if (rowsAdded > 0)
                                {
                                    MessageBox.Show("Pomyślnie zapłacono!");
                                    i++;
                                    label2.Text = "Podaj cene " + i + " rachunku:";
                                    ammo_box.Text = "";
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
                sql = "insert into Historia (card_out, card_in, opis, money) values ('Nieznane ID', @cardout, 'Transakcja', @Money)";
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    try
                    {
                        cnn.Open();

                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.Add("@money", SqlDbType.NVarChar).Value = Math.Round(userVal, 2);
                            cmd.Parameters.Add("@cardout", SqlDbType.NVarChar).Value = Program.globalCardId;

                            int rowsAdded = cmd.ExecuteNonQuery();
                            if (rowsAdded > 0)
                            {
                                if (i > ile)
                                {
                                    MessageBox.Show("Pomyślnie zapłacono wszystkie rachunki!", "SUCESS");
                                    Menu menu = new Menu();
                                    menu.Show();
                                    this.Hide();
                                }
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
                    MessageBox.Show("Nie masz wystarczających środków na koncie!", "ERROR");
                }
            }

        private void Transakcje_Load(object sender, EventArgs e)
        {
            ile = 0;
            i = 1;
        }
    }
}
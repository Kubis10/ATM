using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Dodaj : Form
    {
        public static bool czy_cardid = false;

        public Dodaj()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void okey_btn_Click(object sender, EventArgs e)
        {
            if (cardID_box.Text.Length == 11)
            {
                if (pin_box.Text.Length == 4)
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

                        command.CommandText = ("Select * From [Users] where CardID = '" + cardID_box.Text + "'");

                        using (DbDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Dodaj.czy_cardid = true;
                            }
                        }
                    }

                    if (Dodaj.czy_cardid == false)
                    {
                        string connetionString = null;
                        string sql = null;

                        connetionString = "Data Source=GAMEING-DESKTOP\\SQLEXPRESS;Initial Catalog=bankomatDB;Integrated Security=True;Pooling=False";

                        sql = "INSERT INTO [Users] (CardId, Tel, Pin, Money) VALUES (@CardId, @Tel, @Pin, @Money)";

                        using (SqlConnection cnn = new SqlConnection(connetionString))
                        {
                            try
                            {
                                cnn.Open();

                                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                                {
                                    cmd.Parameters.Add("@CardId", SqlDbType.NVarChar).Value = cardID_box.Text;
                                    cmd.Parameters.Add("@Pin", SqlDbType.NVarChar).Value = pin_box.Text;
                                    cmd.Parameters.Add("@Money", SqlDbType.NVarChar).Value = money_box.Text;
                                    cmd.Parameters.Add("@Tel", SqlDbType.NVarChar).Value = tel_box.Text;

                                    int rowsAdded = cmd.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        cardID_box.Enabled = false;
                                        pin_box.Enabled = false;
                                        money_box.Enabled = false;
                                        MessageBox.Show("Pomyślnie dodano użytkownika!");
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
                        MessageBox.Show("Osoba z takim numerem karty już istnieje", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Podano zbyt krótki numer karty", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Podano zbyt krótki pin!", "ERROR");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
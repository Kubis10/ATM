using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class ZmienPin : Form
    {
        public static string pin = "";

        public ZmienPin()
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

        private void zmien_btn_Click(object sender, EventArgs e)
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

                command.CommandText = ("Select [Pin] From [Table] where CardID = " + Program.globalCardId);

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ZmienPin.pin = $"{dataReader["Pin"]}";
                    }
                }
            }

            if (ZmienPin.pin == textBox1.Text)
            {
                if (textBox2.Text.Length == 4)
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        string connetionString = null;
                        string sql = null;

                        connetionString = "Data Source=GAMEING-DESKTOP\\SQLEXPRESS;Initial Catalog=bankomatDB;Integrated Security=True;Pooling=False";

                        sql = "update [Table] set [Pin] = @Pin where CardID = @CardId";

                        using (SqlConnection cnn = new SqlConnection(connetionString))
                        {
                            try
                            {
                                cnn.Open();

                                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                                {
                                    cmd.Parameters.Add("@pin", SqlDbType.NVarChar).Value = textBox2.Text;
                                    cmd.Parameters.Add("@CardId", SqlDbType.NVarChar).Value = Program.globalCardId;

                                    int rowsAdded = cmd.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        textBox1.Enabled = false;
                                        textBox2.Enabled = false;
                                        textBox3.Enabled = false;
                                        MessageBox.Show("Pomyślnie zmieniono PIN!");
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
                        MessageBox.Show("Piny nie są takie same!", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Twój nowy pin jest za krótki!", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Podano zły pin!", "ERROR");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
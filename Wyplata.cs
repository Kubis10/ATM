using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Wyplata : Form
    {
        public Wyplata()
        {
            InitializeComponent();
        }

        private void wyplac_btn_Click(object sender, EventArgs e)
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
                        cmd.Parameters.Add("@money", SqlDbType.NVarChar).Value = Math.Round(money.Value, 2);
                        cmd.Parameters.Add("@CardId", SqlDbType.NVarChar).Value = Program.globalCardId;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            money.Enabled = false;
                            MessageBox.Show("Pomyślnie wypłacono!");
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace Bankomat
{
    public partial class Wplata : Form
    {
        public Wplata()
        {
            InitializeComponent();
        }

        private void wplac_btn_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;

            connetionString = "Data Source=GAMEING-DESKTOP\\SQLEXPRESS;Initial Catalog=bankomatDB;Integrated Security=True;Pooling=False";
            
            sql = "update [Table] set [Money] += @Money where CardID = @CardId";

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@money", SqlDbType.NVarChar).Value = money.Value;
                        cmd.Parameters.Add("@CardId", SqlDbType.NVarChar).Value = Program.globalCardId;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            money.Enabled = false;
                            MessageBox.Show("Pomyślnie wpłacono!");
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

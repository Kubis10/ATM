using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Blocked : Form
    {
        public Blocked()
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

        private void block_btn_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;

            connetionString = "Data Source=GAMEING-DESKTOP\\SQLEXPRESS;Initial Catalog=bankomatDB;Integrated Security=True;Pooling=False";

            sql = "update [Users] set [Blocked] = 1 where CardID = @CardId";

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@CardId", SqlDbType.NVarChar).Value = input_box.Text;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Zablokowona pomyślnie użytkownika");
                            Admin admin = new Admin();
                            admin.Show();
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

        private void unblock_btn_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;

            connetionString = "Data Source=GAMEING-DESKTOP\\SQLEXPRESS;Initial Catalog=bankomatDB;Integrated Security=True;Pooling=False";

            sql = "update [Users] set [Blocked] = 0 where CardID = @CardId";
    

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@CardId", SqlDbType.NVarChar).Value = input_box;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Odblokowano pomyślnie użytkownika");
                            Admin admin = new Admin();
                            admin.Show();
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
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void Blocked_Load(object sender, EventArgs e)
        {
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

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Login : Form
    {
        public Login()
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

        private void Login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=GAMEING-DESKTOP\SQLEXPRESS;Initial Catalog=bankomatDB;Integrated Security=True;Pooling=False;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from [Table] where CardID = @cardId and Pin = @pinCode;", conn);
            cmd.Parameters.Add("@cardId", SqlDbType.VarChar).Value = card_nr.Text;
            cmd.Parameters.Add("@pinCode", SqlDbType.VarChar).Value = pin_nr.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                Program.globalCardId = card_nr.Text;
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Błędny pin lub numer karty", "Error");
                pin_nr.Text = "";
            }
            conn.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
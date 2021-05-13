using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Historia_Load(object sender, EventArgs e)
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
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT card_out AS od, card_in AS do, money AS kwota, opis FROM [bankomatDB].[dbo].[Historia] where card_in ='" + Program.globalCardId+"'", sqlCon);
                DataTable datb = new DataTable();
                sqlDa.Fill(datb);
                dataGridView1.DataSource = datb;
                SqlDataAdapter sqlDat = new SqlDataAdapter("SELECT card_out AS od, card_in AS do, money AS kwota, opis FROM [bankomatDB].[dbo].[Historia]where card_out ='" + Program.globalCardId + "'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDat.Fill(dtbl);
                dataGridView2.DataSource = dtbl;
            }
        }
    }
}

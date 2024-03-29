﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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

            sql = "update [Users] set [Money] += @Money where CardID = @CardId";
            var sqladd = "insert into Historia (card_out, card_in, opis, money) values ('Brak', @cardin, 'Wpłata do bankomatu', @Money)";

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
                        }
                        else
                            MessageBox.Show("Wystąpił problem spróbuj ponownie później");
                    }
                    using (SqlCommand cmd = new SqlCommand(sqladd, cnn))
                    {
                        cmd.Parameters.Add("@Money", SqlDbType.NVarChar).Value = Math.Round(money.Value, 2);
                        cmd.Parameters.Add("@cardin", SqlDbType.NVarChar).Value = Program.globalCardId;

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

        private void Wplata_Load(object sender, EventArgs e)
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
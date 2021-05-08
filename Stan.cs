using System;
using System.Configuration;
using System.Data.Common;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Drawing;

namespace Bankomat
{
    public partial class Stan : Form
    {
        public Stan()
        {
            InitializeComponent();
        }

        public double mons;

        private void myCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Stan_Load(object sender, EventArgs e)
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
            string provider = ConfigurationManager.AppSettings["provider"];

            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    Console.WriteLine("Connection Error");
                    return;
                }

                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    Console.WriteLine("Command Error");
                    return;
                }

                command.Connection = connection;

                command.CommandText = "Select * From [Users]";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader["CardID"]} " + $"{dataReader["Pin"]} " + $"{dataReader["Money"]} ");
                    }
                }

                command.CommandText = ("Select [Money] From [Users] Where CardID='" + Program.globalCardId + "'");

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        String st = ($"{dataReader["Money"]}");
                        st = st.Substring(0, st.Length - 2);
                        mons = double.Parse(st);
                        stan_konta.Text = (st + " PLN");
                    }
                }
            }
            WebClient wp = new WebClient() { Encoding = Encoding.UTF8 };
            string url = "http://api.nbp.pl/api/exchangerates/tables/a/?format=json";
            var response = wp.DownloadString(url);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var lists = JsonSerializer.Deserialize<List<RateData>>(response, options);

            var single = lists.Single();
            foreach (var rate in single.Rates)
            {
                comboBox.Items.Add(rate.Currency.ToString());
            }
            comboBox.Items.Add("PLN");
            comboBox.Text = "PLN";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        public class RateData
        {
            public List<Rate> Rates { get; set; }
        }

        public class Rate
        {
            public string Currency { get; set; }
            public string Code { get; set; }
            public decimal Mid { get; set; }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebClient wp = new WebClient() { Encoding = Encoding.UTF8 };
            string url = "http://api.nbp.pl/api/exchangerates/tables/a/?format=json";
            var response = wp.DownloadString(url);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var lists = JsonSerializer.Deserialize<List<RateData>>(response, options);
            string stan = "";
            var single = lists.Single();
            foreach (var rate in single.Rates)
            {
                if (rate.Currency==comboBox.Text)
                {
                    stan = Math.Round((mons / (double)rate.Mid), 2).ToString() +" "+ rate.Code.ToString();
                }
            }
            if (comboBox.Text == "PLN")
            {
                stan = mons.ToString() + " PLN";
            }
            stan_konta.Text = stan;
        }
    }
}
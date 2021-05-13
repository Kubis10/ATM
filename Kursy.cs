using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Kursy : Form
    {
        public Kursy()
        {
            InitializeComponent();
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

        private void get_response()
        {
            WebClient wp = new WebClient() { Encoding = Encoding.UTF8 };
            string url = "http://api.nbp.pl/api/exchangerates/tables/a/?format=json";
            var response = wp.DownloadString(url);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var lists = JsonSerializer.Deserialize<List<RateData>>(response, options);

            DataTable tempTable = new DataTable();
            tempTable.Columns.Add("Waluta", typeof(string));
            tempTable.Columns.Add("Kod", typeof(string));
            tempTable.Columns.Add("PLN", typeof(string));
            DataRow newRow;

            var single = lists.Single();
            foreach (var rate in single.Rates)
            {
                newRow = tempTable.NewRow();
                newRow["Waluta"] = rate.Currency.ToString();
                newRow["Kod"] = rate.Code.ToString();
                newRow["PLN"] = rate.Mid.ToString();
                tempTable.Rows.Add(newRow);
                tempTable.AcceptChanges();
            }
            dataGridView.Rows.Clear();
            dataGridView.DataSource = tempTable;
        }

        private void Kursy_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            get_response();
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
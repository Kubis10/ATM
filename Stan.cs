using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;

namespace Bankomat
{
    public partial class Stan : Form
    {
        public Stan()
        {
            InitializeComponent();
        }

        private void Stan_Load(object sender, EventArgs e)
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

                command.CommandText = "Select * From [Table]";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader["CardID"]} " + $"{dataReader["Pin"]} " + $"{dataReader["Money"]} ");
                    }
                }

                command.CommandText = ("Select [Money] From [Table] Where CardID="+ Program.globalCardId.ToString());

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        String st = ($"{dataReader["Money"]}");
                        st = st.Substring(0, st.Length - 2);
                        stan_konta.Text = (st + " zł");
                    }
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

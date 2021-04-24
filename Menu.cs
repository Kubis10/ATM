using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void konto_btn_Click(object sender, EventArgs e)
        {
            Stan stan = new Stan();
            stan.Show();
            this.Hide();
        }

        private void wplata_btn_Click(object sender, EventArgs e)
        {
            Wplata wplata = new Wplata();
            wplata.Show();
            this.Hide();
        }

        private void wyplata_btn_Click(object sender, EventArgs e)
        {
            Wyplata wyplata = new Wyplata();
            wyplata.Show();
            this.Hide();
        }

        private void zmien_btn_Click(object sender, EventArgs e)
        {
            ZmienPin zmien = new ZmienPin();
            zmien.Show();
            this.Hide();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

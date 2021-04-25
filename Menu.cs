using System;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(Program.globalCardId=="12345678901")
            add_user_btn.Visible = true;
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

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            Dodaj dodaj = new Dodaj();
            dodaj.Show();
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
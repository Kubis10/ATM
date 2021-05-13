using System;
using System.Drawing;
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
            this.CenterToScreen();
            if (Program.globalCardId == "12345678901")
                admin_btn.Visible = true;

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

        private void przelew_btn_Click(object sender, EventArgs e)
        {
            Przelewy przelewy = new Przelewy();
            przelewy.Show();
            this.Hide();
        }

        private void trans_btn_Click(object sender, EventArgs e)
        {
            Transakcje transakcje = new Transakcje();
            transakcje.Show();
            this.Hide();
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            Historia historia = new Historia();
            historia.Show();
            this.Hide();
        }

        private void kurs_btn_Click(object sender, EventArgs e)
        {
            Kursy kursy = new Kursy();
            kursy.Show();
            this.Hide();
        }

        private void blik_btn_Click(object sender, EventArgs e)
        {
            Blik blik = new Blik();
            blik.Show();
            this.Hide();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void sett_btn_Click(object sender, EventArgs e)
        {
            Ustawienia ustawienia = new Ustawienia();
            ustawienia.Show();
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
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
    public partial class Ustawienia : Form
    {
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void zmien_pin_btn_Click(object sender, EventArgs e)
        {
            ZmienPin zmien = new ZmienPin();
            zmien.Show();
            this.Hide();
        }

        private void chn_theme_Click(object sender, EventArgs e)
        {
            if (Program.theme)
            {
                Program.theme = false;
                Color Warn1Color = Color.FromArgb(70, 70, 70);
                this.BackColor = Warn1Color;
            }
            else
            {
                Program.theme = true;
                this.BackColor = Control.DefaultBackColor;
            }
        }

        private void Ustawienia_Load(object sender, EventArgs e)
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

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
    public partial class Przelewy : Form
    {
        public Przelewy()
        {
            InitializeComponent();
        }

        private void telp_btn_Click(object sender, EventArgs e)
        {
            PrzelewT przelewT = new PrzelewT();
            przelewT.Show();
            this.Hide();
        }

        private void cardp_btn_Click(object sender, EventArgs e)
        {
            PrzelewK przelewK = new PrzelewK();
            przelewK.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Przelewy_Load(object sender, EventArgs e)
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

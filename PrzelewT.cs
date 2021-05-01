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
    public partial class PrzelewT : Form
    {
        public PrzelewT()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Przelewy przelewy = new Przelewy();
            przelewy.Show();
            this.Hide();
        }
    }
}

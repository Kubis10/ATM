using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Blik : Form
    {

        public Blik()
        {
            InitializeComponent();
            InitializeMyTimer();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Blik_Load(object sender, EventArgs e)
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
            progressBar.Value=0;
            Random rnd = new Random();
            int fst = rnd.Next(100, 999);
            int scn = rnd.Next(100, 999);
            blik_nr.Text = fst + " " + scn;
            timer.Enabled = true;
            timer.Start();
        }
        private Timer time = new Timer();

        private void InitializeMyTimer()
        {
            time.Interval = 1000;
            time.Tick += new EventHandler(IncreaseProgressBar);
            time.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            progressBar.Increment(1);
        }
    }
}

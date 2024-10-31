using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd;
        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Sifirla();
            timer1.Start();
        }
        private void Sifirla()
        {
            pbxBeyaz.Left = pbxSiyah.Left = 30;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Yaris();

            if (pbxBeyaz.Left + pbxBeyaz.Width > btnFinish.Left || pbxSiyah.Left + pbxSiyah.Width > btnFinish.Left) { timer1.Stop(); Mesaj(); }
        }
        private void Yaris()
        {
            pbxBeyaz.Left += rnd.Next(10);
            pbxSiyah.Left += rnd.Next(10);
        }

        private void Mesaj()
        {
            if (pbxBeyaz.Left > pbxSiyah.Left)
            {
                MessageBox.Show("White horse win!");
            }
            else if (pbxSiyah.Left > pbxBeyaz.Left)
            {
                MessageBox.Show("Black Horse win !");
            }
            else
            {
                MessageBox.Show("Head to head!");
            }
        }

        private void btnBasaAl_Click(object sender, EventArgs e)
        {
            Sifirla();
            timer1.Stop();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                btnDevam.Text = "GO On";
                timer1.Stop();
            }
            else
            {
                btnDevam.Text = "Stop";
                timer1.Start();
            }
        }
    }
}

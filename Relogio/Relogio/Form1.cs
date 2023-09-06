using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relogio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLigar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void BtnDesligar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            txtData.Text = "";
            txtHora.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txtData.Text = System.DateTime.Today.ToShortDateString();
            txtHora.Text = System.DateTime.Now.ToLongTimeString();
        }
    }
}

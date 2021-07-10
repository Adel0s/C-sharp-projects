using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Win : Form
    {
        Color FirstColor = Color.White;
        Color SecondColor = Color.Gold;
        string nume;
        int timp_rezolvare;
        public Win(string nume, int timp_rezolvare)
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.nume = nume;
            this.timp_rezolvare = timp_rezolvare;
        }

        private void Win_Load(object sender, EventArgs e)
        {
            label2.Text = label2.Text + nume;
            label3.Text = label3.Text + timp_rezolvare + " secunde";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.ForeColor == FirstColor)
                label1.ForeColor = SecondColor;
            else label1.ForeColor = FirstColor;
        }
    }
}

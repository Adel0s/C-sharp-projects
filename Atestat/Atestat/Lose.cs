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
    public partial class Lose : Form
    {
        Color FirstColor = Color.Transparent;
        Color SecondColor = Color.Red;
        public Lose()
        {
            InitializeComponent();
        }

        private void Lose_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.BackColor == FirstColor)
                label1.BackColor = SecondColor;
            else label1.BackColor = FirstColor;
        }
    }
}

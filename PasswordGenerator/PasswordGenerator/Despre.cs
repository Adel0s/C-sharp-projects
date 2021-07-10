using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Despre : Form
    {
        public Despre()
        {
            InitializeComponent();
        }

        private void Despre_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("user.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\PasswordGeneratorDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True; MultipleActiveResultSets = True;");
            InitializeComponent();
            con.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("bkg3BLUR.png");
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Green;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Lime;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register register = new Register(con);
            this.Hide();
            register.Show();
            register.FormClosed += (a, b) =>
            {
                this.Show();
            };
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login(con);
            this.Hide();
            login.Show();
            login.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Turismul_in_Europa
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\TurismEuropaDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True; MultipleActiveResultSets = True;");
            con.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.BackgroundImage = Image.FromFile("logo-europa.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile("logo-europa.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atractii atractii = new Atractii();
            this.Hide();
            atractii.Show();
            atractii.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rezerva rezerva = new Rezerva(con);
            this.Hide();
            rezerva.Show();
            rezerva.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void inchideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Despre despre = new Despre();
            this.Hide();
            despre.Show();
            despre.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void rezervaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervarile_mele rezervari = new Rezervarile_mele(con);
            this.Hide();
            rezervari.Show();
            rezervari.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

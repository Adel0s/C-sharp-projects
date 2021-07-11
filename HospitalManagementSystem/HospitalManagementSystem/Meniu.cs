using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class Meniu : Form
    {
        SqlConnection con;
        public Meniu()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Hospital.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True; MultipleActiveResultSets = true;");
            con.Open();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            button1.Image = Image.FromFile("registration.png");
            button2.Image = Image.FromFile("info.png");
            button3.Image = Image.FromFile("doctor.png");
            button4.Image = Image.FromFile("close.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PacientNou pacient = new PacientNou(con);
            this.Hide();
            pacient.Show();
            pacient.FormClosed += (a,b) =>
            {
                this.Show();
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InfoPacienti info = new InfoPacienti(con);
            this.Hide();
            info.Show();
            info.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void despreAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Despre despre = new Despre();
            this.Hide();
            despre.Show();
            despre.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inchideAplicatiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doctori doctori = new Doctori(con);
            this.Hide();
            doctori.Show();
            doctori.FormClosed += (a, b) =>
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

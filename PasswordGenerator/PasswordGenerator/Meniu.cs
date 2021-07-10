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
    public partial class Meniu : Form
    {
        SqlConnection con;
        Utilizatori utilizatori;
        public Meniu(SqlConnection con, Utilizatori utilizatori)
        {
            InitializeComponent();
            this.con = con;
            this.utilizatori = utilizatori;
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            emailToolStripMenuItem.Text = utilizatori.email;
        }

        private void deconectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generareParolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = utilizatori.ID;
            GeneratorParola gp = new GeneratorParola(con, new Utilizatori(con,id));
            this.Hide();
            gp.Show();
            gp.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void verificareParolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerificaParola vp = new VerificaParola();
            this.Hide();
            vp.Show();
            vp.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void paroleleMeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = utilizatori.ID;
            Parolele_mele parole = new Parolele_mele(con,new Utilizatori(con,id));
            this.Hide();
            parole.Show();
            parole.FormClosed += (a, b) =>
            {
                this.Show();
            };
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

        private void button1_Click(object sender, EventArgs e)
        {
            int id = utilizatori.ID;
            GeneratorParola gp = new GeneratorParola(con, new Utilizatori(con, id));
            this.Hide();
            gp.Show();
            gp.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificaParola vp = new VerificaParola();
            this.Hide();
            vp.Show();
            vp.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = utilizatori.ID;
            Parolele_mele parole = new Parolele_mele(con, new Utilizatori(con, id));
            this.Hide();
            parole.Show();
            parole.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }
    }
}

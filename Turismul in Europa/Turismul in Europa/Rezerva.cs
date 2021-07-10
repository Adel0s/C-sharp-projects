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
    public partial class Rezerva : Form
    {
        SqlConnection con;
        private List<Vacanta> vacante;
        private int currIndex = -1;

        public Rezerva(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;

            loadVacanta();
        }

        private void Rezerva_Load(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            currIndex++;
            loadForCurrent();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            currIndex--;
            loadForCurrent();
        }

        public void loadVacanta()
        {
            vacante = new List<Vacanta>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vacante", con);
            var red = cmd.ExecuteReader();

            while (red.Read())
            {
                vacante.Add(new Vacanta
                {
                    IdVacanta = Convert.ToInt32(red[0]),
                    NumeVacanta = red[1].ToString(),
                    CaleFisier = red[2].ToString(),
                    Pret = Convert.ToInt32(red[3]),
                });
            }

            if (vacante.Count > 0 && currIndex == -1)
                currIndex = 0;
            loadForCurrent();
        }

        public void loadForCurrent()
        {
            prev.Enabled = next.Enabled = true;
            if (currIndex == -1)
            {
                prev.Enabled = next.Enabled = false;
                return;
            }
            if (currIndex == 0)
                prev.Enabled = false;
            if (currIndex == vacante.Count - 1)
                next.Enabled = false;
            label2.Text = "Pagina " + (currIndex + 1) + " din " + vacante.Count;
            label1.Text = vacante[currIndex].NumeVacanta;
            //label2.Text = vacante[currIndex].Pret.ToString() + " Lei";
            panel1.BackgroundImage = Image.FromFile(vacante[currIndex].CaleFisier);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezerva_acum rezerva_acum = new Rezerva_acum(con,vacante[currIndex]);
            this.Hide();
            rezerva_acum.Show();
            rezerva_acum.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezervarile_mele rezervari = new Rezervarile_mele(con);
            this.Hide();
            rezervari.Show();
            rezervari.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }
    }
}

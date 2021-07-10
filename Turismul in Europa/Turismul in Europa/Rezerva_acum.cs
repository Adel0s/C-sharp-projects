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
    public partial class Rezerva_acum : Form
    {
        private Vacanta vacanta;
        SqlConnection con;
        public Rezerva_acum(SqlConnection con,Vacanta vacanta)
        {
            InitializeComponent();
            this.con = con;
            this.vacanta = vacanta;
            load();
        }

        private void Rezerva_acum_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value.ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        void load()
        {
            numericUpDown1.Minimum = 1;
            panel1.BackgroundImage = Image.FromFile(vacanta.CaleFisier);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            label7.Text = vacanta.NumeVacanta;
            label2.Text = vacanta.Pret.ToString();
            update();
        }

        void update()
        {
            label2.Text = (vacanta.Pret * (double)numericUpDown1.Value).ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
                MessageBox.Show("Data de inceput nu poate fi mai mare decat cea de final!");
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Rezervari(NumeVacanta,PretVacanta,Persoane,DataInceput,DataFinal) VALUES(@nume,@pret,@pers,@dataI,@dataF)", con);
                cmd.Parameters.AddWithValue("nume",label7.Text);
                cmd.Parameters.AddWithValue("pret", Convert.ToInt32(label2.Text));
                cmd.Parameters.AddWithValue("pers", Convert.ToInt32(numericUpDown1.Value));
                cmd.Parameters.AddWithValue("dataI", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("dataF", dateTimePicker2.Value);
                int i = cmd.ExecuteNonQuery();
                if (i == 1) MessageBox.Show("Vacanta inregistrata!");
                else MessageBox.Show("Confirmare nereusita!");
                this.Close();
            }
        }
    }
}

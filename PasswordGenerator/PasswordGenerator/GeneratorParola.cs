using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PasswordGenerator
{
    public partial class GeneratorParola : Form
    {
        SqlConnection con;
        Utilizatori utilizatori;
        const string LitereMici = "abcdefghijklmnopqrstuvxyz";
        const string LitereMari = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
        const string Cifre = "123456789";
        const string SemneDePunctuatie = ".,;:";
        const string Paranteze = "()[]{}<>";
        const string CaractereSpeciale = "!@#$%^&*-+";
        string c;
        public GeneratorParola(SqlConnection con,Utilizatori utilizatori)
        {
            InitializeComponent();
            this.con = con;
            this.utilizatori = utilizatori;
        }

        private void GeneratorParola_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Facebook");
            comboBox1.Items.Add("Instagram");
            comboBox1.Items.Add("Google account");
            comboBox1.Items.Add("Yahoo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    c += LitereMici;
                }
                if (checkBox2.Checked)
                {
                    c += LitereMari;
                }
                if (checkBox3.Checked)
                {
                    c += Cifre;
                }
                if (checkBox4.Checked)
                {
                    c += SemneDePunctuatie;
                }
                if (checkBox5.Checked)
                {
                    c += Paranteze;
                }
                if (checkBox6.Checked)
                {
                    c += CaractereSpeciale;
                }
                StringBuilder sb = new StringBuilder();
                Random rnd = new Random();
                int i = Convert.ToInt32(numericUpDown1.Value);
                while (0 < i--)
                {
                    sb.Append(c[rnd.Next(c.Length)]);
                }
                textBox1.Text = sb.ToString();
                c = "";
            }
            catch (Exception)
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Selecteaza cel putin o optiune!";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (comboBox1.Text != "")
                {
                    SqlCommand cmd1;
                    cmd1 = new SqlCommand("SELECT COUNT(*) FROM Parole WHERE idUtilizator = @id AND Platforma = @platforma", con);
                    cmd1.Parameters.AddWithValue("id", utilizatori.ID);
                    cmd1.Parameters.AddWithValue("platforma", comboBox1.Text);
                    int records = (int)cmd1.ExecuteScalar();
                    if (records == 0)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Parole(idUtilizator,Platforma,Parola) VALUES(@id,@platforma,@parola)", con);
                        cmd.Parameters.AddWithValue("id", utilizatori.ID);
                        cmd.Parameters.AddWithValue("platforma", comboBox1.Text);
                        cmd.Parameters.AddWithValue("parola", textBox1.Text);
                        int ok = cmd.ExecuteNonQuery();
                        if (ok == 1)
                        {
                            MessageBox.Show("Parola salvată cu succes!");
                            this.Close();
                        }
                        else MessageBox.Show("Salvare eșuată");
                    }
                    else
                    {
                        if (MessageBox.Show("Parola deja salvata pentru aceasta platforma! Doresti sa inlocuiesti parola salvata cu cea generata acum?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            SqlCommand cmd2 = new SqlCommand("UPDATE Parole SET Parola = @parola WHERE IdUtilizator = @idU AND Platforma = @platforma", con);
                            cmd2.Parameters.AddWithValue("idU", utilizatori.ID);
                            cmd2.Parameters.AddWithValue("platforma", comboBox1.Text);
                            cmd2.Parameters.AddWithValue("parola", textBox1.Text);
                            int i = cmd2.ExecuteNonQuery();
                            if (i == 1)
                            {
                                MessageBox.Show("Actualizare reusita cu succes!");
                            }
                            else MessageBox.Show("Actualizare esuata!");
                        }
                    }
                }
                else MessageBox.Show("Trebuie selectata platforma pentru care salvezi parola generata!");
            }
            else MessageBox.Show("Trebuie sa generezi o parola mai întâi!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

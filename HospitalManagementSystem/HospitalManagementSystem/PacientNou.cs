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
    public partial class PacientNou : Form
    {
        SqlConnection con;
        public PacientNou(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            comboBox1.Items.Add("Grupa 01");
            comboBox1.Items.Add("Grupa A2");
            comboBox1.Items.Add("Grupa B3");
            comboBox1.Items.Add("Grupa AB4");
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Toate campurile sunt obligatorii!");
            }
            else
            {
                SqlCommand cmd;
                cmd = new SqlCommand("INSERT INTO Pacienti(Nume,Sex,Varsta,Adresa,Telefon,Simptome,Diagnostic,Stare,Camera,Patul,GrupaSange,Data) VALUES(@nume,@sex,@varsta,@adresa,@telefon,@simptome,@diagnostic,@stare,@camera,@patul,@grupa,@data)", con);
                cmd.Parameters.AddWithValue("nume", textBox1.Text);
                if(radioButton1.Checked == true) cmd.Parameters.AddWithValue("sex", radioButton1.Text);
                else cmd.Parameters.AddWithValue("sex", radioButton2.Text);
                cmd.Parameters.AddWithValue("varsta", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("adresa", textBox2.Text);
                cmd.Parameters.AddWithValue("telefon", textBox3.Text);
                cmd.Parameters.AddWithValue("simptome", textBox6.Text);
                cmd.Parameters.AddWithValue("diagnostic", textBox4.Text);
                cmd.Parameters.AddWithValue("stare", textBox5.Text);
                cmd.Parameters.AddWithValue("camera", numericUpDown2.Value);
                cmd.Parameters.AddWithValue("patul", numericUpDown3.Value);
                cmd.Parameters.AddWithValue("grupa", comboBox1.Text);
                cmd.Parameters.AddWithValue("data", dateTimePicker1.Text);
                int i = cmd.ExecuteNonQuery();
                if(i==1)
                {
                    MessageBox.Show("Pacient nou adaugat cu succes!");
                }
                else MessageBox.Show("Eroare la adaugare. Mai incearca!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            numericUpDown1.Value = numericUpDown1.Minimum;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

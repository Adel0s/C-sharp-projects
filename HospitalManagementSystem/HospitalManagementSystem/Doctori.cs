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
    public partial class Doctori : Form
    {
        SqlConnection con;
        int id;
        public Doctori(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            dataGridView1.CellClick += (a, b) =>
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString();
                numericUpDown1.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].FormattedValue);
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
            };
        }

        void populate()
        {
            SqlCommand cmd;
            cmd = new SqlCommand("SELECT * FROM Doctori", con);
            var red = cmd.ExecuteReader();
            while (red.Read())
            {
                dataGridView1.Rows.Add(red[0].ToString(), red[1].ToString(), red[2].ToString(), red[3].ToString(), red[4].ToString());
            }
        }

        private void Doctori_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Toate campurile sunt obligatorii!");
            }
            else
            {
                SqlCommand cmd;
                cmd = new SqlCommand("INSERT INTO Doctori(Nume,Sectia,Experienta,Telefon) VALUES(@nume,@sectie,@experienta,@telefon)", con);
                cmd.Parameters.AddWithValue("nume", textBox1.Text);
                cmd.Parameters.AddWithValue("sectie", textBox2.Text);
                cmd.Parameters.AddWithValue("experienta", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("telefon", textBox4.Text);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Doctor nou adaugat cu succes!");
                    dataGridView1.Rows.Clear();
                    populate();
                }
                else MessageBox.Show("Eroare la adaugare. Mai incearca!");
            }
                /*SqlCommand cmd2;
                cmd2 = new SqlCommand("SELECT * FROM Doctori ORDER BY idDoctor DESC LIMIT 1", con);
                var red = cmd2.ExecuteReader();
                red.Read();
                int id = Convert.ToInt32(red[0]);
                dataGridView1.Rows.Add(id,textBox1.Text, textBox2.Text, numericUpDown1.Value, textBox4.Text);*/
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].FormattedValue);
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
            dataGridView1.Rows.RemoveAt(rowIndex);
            SqlCommand cmd = new SqlCommand("DELETE FROM Doctori WHERE idDoctor = @id", con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();

            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = numericUpDown1.Minimum;
            textBox4.Text = "";
            //populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

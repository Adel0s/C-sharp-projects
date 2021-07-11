using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace HospitalManagementSystem
{
    public partial class InfoPacienti : Form
    {
        SqlConnection con;
        public InfoPacienti(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;

            dataGridView1.CellClick += (a, b) =>
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].FormattedValue.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[6].FormattedValue.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[7].FormattedValue.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[8].FormattedValue.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[9].FormattedValue.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[10].FormattedValue.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[11].FormattedValue.ToString();
                textBox12.Text = dataGridView1.CurrentRow.Cells[12].FormattedValue.ToString();
            };
        }

        void populate()
        {
            SqlCommand cmd;
            cmd = new SqlCommand("SELECT * FROM Pacienti", con);
            var red = cmd.ExecuteReader();
            while (red.Read())
            {
                dataGridView1.Rows.Add(red[0].ToString(), red[1].ToString(), red[2].ToString(), red[3].ToString(), red[4].ToString(), red[5].ToString(), red[6].ToString(), red[7].ToString(), red[8].ToString(), red[9].ToString(), red[10].ToString(), red[11].ToString(), red[12].ToString());
            }
        }

        private void InfoPacienti_Load(object sender, EventArgs e)
        {

            populate();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox11.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].FormattedValue);
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
            newDataRow.Cells[1].Value = textBox1.Text;
            newDataRow.Cells[2].Value = textBox2.Text;
            newDataRow.Cells[3].Value = textBox3.Text;
            newDataRow.Cells[4].Value = textBox4.Text;
            newDataRow.Cells[5].Value = textBox5.Text;
            newDataRow.Cells[6].Value = textBox6.Text;
            newDataRow.Cells[7].Value = textBox7.Text;
            newDataRow.Cells[8].Value = textBox8.Text;
            newDataRow.Cells[9].Value = textBox9.Text;
            newDataRow.Cells[10].Value = textBox10.Text;
            newDataRow.Cells[11].Value = textBox11.Text;
            newDataRow.Cells[12].Value = textBox12.Text;

            SqlCommand cmd = new SqlCommand("UPDATE Pacienti SET Nume = @nume,Sex = @sex,Varsta = @varsta,Adresa = @adresa,Telefon = @telefon,Simptome = @simptome,Diagnostic = @diagnostic,Stare = @stare,Camera = @camera,Patul = @patul,GrupaSange = @grupa,Data = @data WHERE IdPacient = @id", con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("nume", textBox1.Text);
            cmd.Parameters.AddWithValue("sex", textBox2.Text);
            cmd.Parameters.AddWithValue("varsta", textBox3.Text);
            cmd.Parameters.AddWithValue("adresa", textBox4.Text);

            cmd.Parameters.AddWithValue("telefon", textBox5.Text);
            cmd.Parameters.AddWithValue("simptome", textBox6.Text);
            cmd.Parameters.AddWithValue("diagnostic", textBox7.Text);
            cmd.Parameters.AddWithValue("stare", textBox8.Text);
            cmd.Parameters.AddWithValue("camera", textBox9.Text);
            cmd.Parameters.AddWithValue("patul", textBox10.Text);
            cmd.Parameters.AddWithValue("grupa", textBox11.Text);
            cmd.Parameters.AddWithValue("data", textBox12.Text);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Modificare in baza de date reusita!");
                dataGridView1.Rows.Clear();
                populate();
            }
            else MessageBox.Show("Modificare esuata. Mai incearca!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].FormattedValue);
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
            dataGridView1.Rows.RemoveAt(rowIndex);
            SqlCommand cmd = new SqlCommand("DELETE FROM Pacienti WHERE IdPacient = @id", con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
            DateTime dataCurenta = DateTime.UtcNow.Date;
            string dataInternare = dataGridView1.CurrentRow.Cells[12].FormattedValue.ToString();
            string dataExternare = dataCurenta.ToString();
            string numePacient = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();
            dataExternare = dataCurenta.ToString("dd/MM/yyyy");

            if (MessageBox.Show("Printati externarea?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PrintPreviewDialog p = new PrintPreviewDialog();
                p.Document = new PrintDocument();
                p.Document.PrintPage += (a, b) =>
                {
                    //b.Graphics.DrawRectangle(Pens.Black,250, 0, 400, 400);
                    b.Graphics.DrawString("======================================================", DefaultFont, Brushes.Black, 10, 140);
                    b.Graphics.DrawString("Nume pacient: " + numePacient, DefaultFont, Brushes.Black, 10, 200);
                    b.Graphics.DrawString("Data internare: " + dataInternare, DefaultFont, Brushes.Black,10,240);
                    b.Graphics.DrawString("Data externare: " + dataExternare, DefaultFont, Brushes.Black, 10, 280);
                    b.Graphics.DrawString("======================================================", DefaultFont, Brushes.Black, 10, 320);
                };
                p.ShowDialog();
            }
        }
    }
}

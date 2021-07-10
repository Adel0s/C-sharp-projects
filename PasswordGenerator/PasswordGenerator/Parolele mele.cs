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
    public partial class Parolele_mele : Form
    {
        SqlConnection con;
        Utilizatori utilizatori;
        public Parolele_mele(SqlConnection con, Utilizatori utilizatori)
        {
            InitializeComponent();
            this.con = con;
            this.utilizatori = utilizatori;

            dataGridView1.CellClick += (a, b) =>
            {
                try
                {
                    Clipboard.SetText(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString());
                    MessageBox.Show("Parola copiata cu succes!");
                    /*DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridView1.CurrentRow.Cells[2];
                    buttonCell.FlatStyle = FlatStyle.Popup;
                    buttonCell.Style.BackColor = System.Drawing.Color.Green;*/
                }
                catch (Exception)
                {
                    MessageBox.Show("Ai selectat un camp null. Te rog sa alegi platforma pentru care vrei sa copiezi parola!");
                }
            };
        }

        private void Parolele_mele_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cmd = new SqlCommand("SELECT * FROM Parole WHERE idUtilizator = @id", con);
            cmd.Parameters.AddWithValue("id",utilizatori.ID);
            var red = cmd.ExecuteReader();
            while (red.Read())
            {
                dataGridView1.Rows.Add(red[3].ToString(), red[2].ToString(),"Copy");
            }
            pictureBox1.BackgroundImage = Image.FromFile("facebook.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile("instagram.png");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackgroundImage = Image.FromFile("gmail.png");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackgroundImage = Image.FromFile("yahoo.png");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/");
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ro.yahoo.com/");
        }
    }
}

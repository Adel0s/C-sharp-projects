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
    public partial class Login : Form
    {
        SqlConnection con;
        public Login(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("login.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cmd = new SqlCommand("SELECT * FROM Utilizatori WHERE Email = @email AND Parola = @parola",con);
            cmd.Parameters.AddWithValue("email", textBox1.Text);
            cmd.Parameters.AddWithValue("parola", textBox2.Text);

            var red = cmd.ExecuteReader();
            if (red.Read())
            {
                int id = Convert.ToInt32(red[0]);
                Meniu meniu = new Meniu(con,new Utilizatori(con,id));
                this.Hide();
                meniu.Show();
                meniu.FormClosed += (a, b) =>
                {
                    this.Show();
                    textBox2.Text = "";
                };
            }
            else MessageBox.Show("Date de logare incorecte! Mai incearca.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

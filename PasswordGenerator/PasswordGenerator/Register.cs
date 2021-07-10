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
    public partial class Register : Form
    {
        SqlConnection con;
        public Register(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(16, 54, 16);
            this.BackColor = Color.FromArgb(0, 24, 110);
            pictureBox1.BackgroundImage = Image.FromFile("registration.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                if (textBox4.Text == textBox5.Text)
                {
                    if (validareEmail(textBox3.Text))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Utilizatori(Nume,Prenume,Email,Parola) VALUES(@nume, @prenume, @email, @parola)", con);
                        cmd.Parameters.AddWithValue("nume", textBox1.Text);
                        cmd.Parameters.AddWithValue("prenume", textBox2.Text);
                        cmd.Parameters.AddWithValue("email", textBox3.Text);
                        cmd.Parameters.AddWithValue("parola", textBox4.Text);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Te-ai inregistrat cu succes!");
                            this.Close();
                        }
                        else MessageBox.Show("Inregistrare esuata!");
                    }
                    else MessageBox.Show("Introduceti un email valid!");
                }
                else MessageBox.Show("Parola nu coincide!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Trebuie completate toate campurile!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool validareEmail(string email)
        {
            if (email.Count(x => x == '@') != 1)
                return false;
            var ind = email.IndexOf('@');
            email = email.Substring(ind + 1);
            if (email.Count(x => x == '.') != 1)
                return false;
            ind = email.IndexOf('.');
            if (ind == 0 || ind == email.Length - 1)
                return false;
            return true;
        }
    }
}

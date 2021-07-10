using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class VerificaParola : Form
    {
        bool hasDigit = false;
        bool hasLow = false;
        bool hasUpper = false;
        bool hasSpec = false;

        int digits = 0;
        int lowers = 0;
        int uppers = 0;
        int specials = 0;
        int passwordLength = 0;

        int score = 0;

        public VerificaParola()
        {
            InitializeComponent();
        }

        private void VerificaParola_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightGray;
            pictureBox2.BackColor = Color.LightGray;
            pictureBox3.BackColor = Color.LightGray;
            pictureBox4.BackColor = Color.LightGray;
            pictureBox5.BackColor = Color.LightGray;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            progressBar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char currentChar;
            score = 0;
            progressBar1.Value = 0;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox2.BackColor = Color.LightGray;
            pictureBox3.BackColor = Color.LightGray;
            pictureBox4.BackColor = Color.LightGray;
            pictureBox5.BackColor = Color.LightGray;
            label2.Text = "";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            hasDigit = false;
            hasLow = false;
            hasUpper = false;
            hasSpec = false;
            digits = 0;
            lowers = 0;
            uppers = 0;
            specials = 0;

            string password = textBox1.Text;
            passwordLength = password.Length;

            for (int i = 0; i < password.Length; i++)
            {
                currentChar = password[i];
                if (char.IsDigit(currentChar))
                {
                    hasDigit = true;
                    digits++;
                }
                else if (char.IsUpper(currentChar))
                {
                    hasUpper = true;
                    uppers++;
                }
                else if (char.IsLower(currentChar))
                {
                    hasLow = true;
                    lowers++;
                }
                else if (!(char.IsLetterOrDigit(currentChar)))
                {
                    hasSpec = true;
                    specials++;
                }
            }
            
            if (passwordLength >= 12) score++;
            if (hasLow) score++;
            if (hasUpper) score++;
            if (hasDigit) score++;
            if (hasSpec) score++;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduceti parola!");
            }
            else
            {
                progressBar1.Visible = true;
                this.timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (Convert.ToInt32(progressBar1.Value) == 100)
            {
                this.timer1.Stop();
                progressBar1.Visible = false;
                label4.Visible = true;
                label4.Text = "Parola ta contine: litere mici: " + lowers + ", litere mari: " + uppers + ", cifre " + digits + " și simboluri/caractere speciale: " + specials;
                switch (score)
                {
                    case 0:
                        MessageBox.Show("Nu ati introdus parola!");
                        break;
                    case 1:
                        pictureBox1.BackColor = Color.Red;
                        label2.Visible = true;
                        label2.Text = "Puterea parolei este foarte slaba";
                        label3.Visible = true;
                        label3.Text = "☹️";
                        break;
                    case 2:
                        pictureBox1.BackColor = Color.Red;
                        pictureBox2.BackColor = Color.Orange;
                        label2.Visible = true;
                        label2.Text = "Puterea parolei este slaba";
                        label3.Visible = true;
                        label3.Text = "🙁";
                        break;
                    case 3:
                        pictureBox1.BackColor = Color.Red;
                        pictureBox2.BackColor = Color.Orange;
                        pictureBox5.BackColor = Color.Yellow;
                        label2.Visible = true;
                        label2.Text = "Puterea parolei este medie";
                        label3.Visible = true;
                        label3.Text = "😐";
                        break;
                    case 4:
                        pictureBox1.BackColor = Color.Red;
                        pictureBox2.BackColor = Color.Orange;
                        pictureBox5.BackColor = Color.Yellow;
                        pictureBox3.BackColor = Color.Lime;
                        label2.Visible = true;
                        label2.Text = "Parola ta este puternica";
                        label3.Visible = true;
                        label3.Text = "🙂";
                        break;
                    case 5:
                        pictureBox1.BackColor = Color.Red;
                        pictureBox2.BackColor = Color.Orange;
                        pictureBox5.BackColor = Color.Yellow;
                        pictureBox3.BackColor = Color.Lime;
                        pictureBox4.BackColor = Color.Green;
                        label2.Visible = true;
                        label2.Text = "Parola ta este foarte puternica(imposibila)";
                        label3.Visible = true;
                        label3.Text = "😀";
                        break;
                }

                /*
                if (hasLow && hasUpper && hasDigit && hasSpec && passwordLength>=8)
                {
                    pictureBox1.BackColor = Color.Red;
                    pictureBox2.BackColor = Color.Orange;
                    pictureBox2.BackColor = Color.Lime;
                    pictureBox2.BackColor = Color.Green;
                    label2.Text = label2.Text + "imposibila";
                }
                else if (hasLow && hasUpper && (hasDigit || hasSpec))
                {
                    pictureBox1.BackColor = Color.Red;
                    pictureBox2.BackColor = Color.Orange;
                    pictureBox2.BackColor = Color.Lime;
                    label2.Text = label2.Text + "grea";
                }
                else if (hasLow && hasUpper)
                {
                    pictureBox1.BackColor = Color.Red;
                    pictureBox2.BackColor = Color.Orange;
                    label2.Text = label2.Text + "medie";
                }
                else if (hasLow || hasUpper || hasDigit || hasSpec)
                {
                    pictureBox1.BackColor = Color.Red;
                    label2.Visible = true;
                    label2.Text = label2.Text + "ușoară";
                }
                 * */
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

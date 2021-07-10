using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string difficulty = "normal";
            string nume;
            nume = textBox1.Text;
            if (radioButton4.Checked) difficulty = "imposibil";
            if (radioButton1.Checked) difficulty = "greu";
            if (radioButton2.Checked) difficulty = "normal";
            if(radioButton3.Checked) difficulty = "usor";

            if (textBox1.Text != "")
            {
                Game game = new Game(difficulty, nume);
                this.Hide();
                game.Show();

                game.FormClosed += (a, b) =>
                {
                    this.Show();
                };
            }
            else MessageBox.Show("Trebuie să îți introduci numele!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            pictureBox1.BackgroundImage = Image.FromFile("user.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox2.BackgroundImage = Image.FromFile("info.png");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            this.Hide();
            autor.Show();
            autor.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Descriere descriere = new Descriere();
            this.Hide();
            descriere.Show();
            descriere.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }
    }
}

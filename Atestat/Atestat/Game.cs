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
    public partial class Game : Form
    {
        string difficulty;
        string nume;
        
        Random rnd = new Random();
        List<string> numbers = new List<string>()
        {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" 
        };

        int nextButton;
        int nextButtonCopy;
        int s = 30;
        int t = 30;
        int timp_rezolvare;

        public Game(string difficulty,string nume)
        {
            InitializeComponent();
            this.difficulty = difficulty;
            this.nume = nume;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            button27.Visible = false;
            button26.Visible = true;
            label1.Text =  difficulty;
            label5.Text = label5.Text + nume + " !";

            if (difficulty == "imposibil")
            {
                label1.ForeColor = Color.DarkRed;
                label3.Text = "15 seconds";
                nextButton = 25;
                nextButtonCopy = nextButton;
                s = 15;
                t = s;
                label2.Text = "    Ai la dispoziție " + s + " secunde pentru a apăsa în ordine descrescătoare numerele!";
            }
            else if (difficulty == "greu")
            {
                label1.ForeColor = Color.Orange;
                label3.Text = "16 seconds";
                nextButton = 1;
                nextButtonCopy = nextButton;
                s = 16;
                t = s;
                label2.Text = "    Ai la dispoziție " + s + " secunde pentru a apăsa în ordine crescătoare numerele!";
            }
            else if (difficulty == "normal")
            {
                label1.ForeColor = Color.Gold;
                label3.Text = "25 seconds";
                nextButton = 1;
                nextButtonCopy = nextButton;
                s = 25;
                t = s;
                label2.Text = "    Ai la dispoziție " + s + " de secunde pentru a apăsa în ordine crescătoare numerele!";
            }
            else
            {
                label1.ForeColor = Color.White;
                label3.Text = "30 seconds";
                nextButton = 1;
                nextButtonCopy = nextButton;
                s = 30;
                t = s;
                label2.Text = "    Ai la dispoziție " + s + " de secunde pentru a apăsa în ordine crescătoare numerele!";
            }

            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
        }

        private void GenereazaNumere()
        {
            Button button;
            int rndNumb;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Button)
                {
                    button = (Button)tableLayoutPanel1.Controls[i];
                }
                else continue;

                rndNumb = rnd.Next(0, numbers.Count);
                button.Text = numbers[rndNumb];

                numbers.RemoveAt(rndNumb);
            }
        }

        private void Restart()
        {
            numbers = new List<string>()
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" 
            };

            if (difficulty == "imposibil")
            {
                label3.Text = "15 seconds";
                s = 15;
                nextButton = 25;
                
            }
            else if (difficulty == "greu")
            {
                label3.Text = "16 seconds";
                s = 16;
                nextButton = 1;
            }
            else if (difficulty == "normal")
            {
                label3.Text = "25 seconds";
                s = 25;
                nextButton = 1;
            }
            else
            {
                label3.Text = "30 seconds";
                s = 30;
                nextButton = 1;
            }

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;

            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;
            button7.BackColor = SystemColors.Control;
            button8.BackColor = SystemColors.Control;
            button9.BackColor = SystemColors.Control;
            button10.BackColor = SystemColors.Control;
            button11.BackColor = SystemColors.Control;
            button12.BackColor = SystemColors.Control;
            button13.BackColor = SystemColors.Control;
            button14.BackColor = SystemColors.Control;
            button15.BackColor = SystemColors.Control;
            button16.BackColor = SystemColors.Control;
            button17.BackColor = SystemColors.Control;
            button18.BackColor = SystemColors.Control;
            button19.BackColor = SystemColors.Control;
            button20.BackColor = SystemColors.Control;
            button21.BackColor = SystemColors.Control;
            button22.BackColor = SystemColors.Control;
            button23.BackColor = SystemColors.Control;
            button24.BackColor = SystemColors.Control;
            button25.BackColor = SystemColors.Control;

            GenereazaNumere();

            timer1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
        }

        private void Winner()
        {
            if (s > 0)
            {
                if (button1.Visible == false && button2.Visible == false && button3.Visible == false && button4.Visible == false && button5.Visible == false && button6.Visible == false && button7.Visible == false
                     && button8.Visible == false && button9.Visible == false && button10.Visible == false && button11.Visible == false && button12.Visible == false && button13.Visible == false && button14.Visible == false
                     && button15.Visible == false && button16.Visible == false && button17.Visible == false && button18.Visible == false && button19.Visible == false && button20.Visible == false && button21.Visible == false
                     && button22.Visible == false && button23.Visible == false && button24.Visible == false && button25.Visible == false)
                {
                    timer1.Stop();
                    timp_rezolvare = t - s;
                    Console.WriteLine(timp_rezolvare);
                    Win win = new Win(nume,timp_rezolvare);
                    this.Hide();
                    win.Show();
                    win.FormClosed += (a, b) =>
                    {
                        this.Close();
                    };
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null)
                return;

            if (nextButtonCopy == 1)
            {
                if (clickedButton.Text == nextButton.ToString())
                {
                    clickedButton.Visible = false;
                    nextButton++;
                    Winner();
                }
                else
                {
                    timer1.Stop();
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button18.Enabled = false;
                    button19.Enabled = false;
                    button20.Enabled = false;
                    button21.Enabled = false;
                    button22.Enabled = false;
                    button23.Enabled = false;
                    button24.Enabled = false;
                    button25.Enabled = false;
                    clickedButton.BackColor = Color.Red;
                    button26.Visible = false;
                    button27.Visible = true;
                    button27.Enabled = true;

                    Lose lose = new Lose();
                    this.Hide();
                    lose.Show();
                    lose.FormClosed += (a, b) =>
                    {
                        this.Show();
                    };
                }
            }
            else
            {
                if (clickedButton.Text == nextButton.ToString())
                {
                    clickedButton.Visible = false;
                    nextButton--;
                    Winner();
                }
                else
                {
                    timer1.Stop();
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button18.Enabled = false;
                    button19.Enabled = false;
                    button20.Enabled = false;
                    button21.Enabled = false;
                    button22.Enabled = false;
                    button23.Enabled = false;
                    button24.Enabled = false;
                    button25.Enabled = false;
                    clickedButton.BackColor = Color.Red;
                    button26.Visible = false;
                    button27.Visible = true;
                    button27.Enabled = true;

                    Lose lose = new Lose();
                    this.Hide();
                    lose.Show();
                    lose.FormClosed += (a, b) =>
                    {
                        this.Show();
                    };
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            s--;
            label3.Text = s.ToString() + " seconds";
            
            if (s <= 0)
            {
                timer1.Stop();
                Lose lose = new Lose();
                this.Hide();
                lose.Show();
                lose.FormClosed += (a, b) =>
                {
                    this.Show();
                };

                button26.Visible = false;
                button27.Visible = true;
                button27.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            GenereazaNumere();
            timer1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true; 
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true; 
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = false; 
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Restart();
            button27.Enabled = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private string WordGuess = "computer";
        private StringBuilder guessedWord = new StringBuilder("", 8);
        private int numWrongGuess = 0;
        public Form1()
        {
            InitializeComponent();
            StringBuilder guess = new StringBuilder("Co?p?t?r");
            label2.Text = guess.ToString();
            label1.Text = new string('.', WordGuess.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text.ToLower();
            if (guess.Length != WordGuess.Length)
            {
                MessageBox.Show("Your guess must have " + WordGuess.Length + " letters.");
                return;
            }
            if (guess == WordGuess)
            {
                label1.Text = WordGuess;
                MessageBox.Show("Congratulation! You guessed the word in " + (numWrongGuess + 1) + " tries.");
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                guessedWord.Append(guess);
                listBox1.Items.Add(guess);
                numWrongGuess++;
                MessageBox.Show("Wrong guess. Try Again. ");
            }
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}

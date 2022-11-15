using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParametersForm
{
    public partial class GameForm : Form
    {
        int randNum;
        int nGuesses = 0;
        int nTicks = 0;
        Random rand = new Random();

        public GameForm(int lowNumber,int highNumber)
        {
            InitializeComponent();
            this.randNum = rand.Next(lowNumber, highNumber);
            this.timer1.Start();
        }

        private void guess_Click(object sender, EventArgs e)
        {
            int guessNum = 0;
            try
            {
                guessNum = Int32.Parse(currentGuess.Text);
            }
            catch
            {

            }

            if (guessNum == randNum)
            {
                this.nGuesses++;
                output.Text = guess.ToString();
                MessageBox.Show($"Woohoo, you guessed {randNum} in {nGuesses} guesses!");
                this.Close();
            }
            else if (guessNum < randNum)
            {
                output.Text = $"{guess} is too low!";
                this.nGuesses++;
            }
            else if (guessNum > randNum)
            {
                output.Text = $"{guess} is too high!";
                this.nGuesses++;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void currentGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                guess.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1 + 1 / 90);
            this.nTicks++;
            if (this.nTicks == this.progressBar1.Maximum)
            {
                this.timer1.Stop();
                MessageBox.Show($"You failed to guess {randNum} in {nGuesses} guesses!");
                this.Close();
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

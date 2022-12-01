using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace UIFromHell
{
    /*Architecture
     * 
     * 1 submit button to submit answers. Enter will be quietly disabled
     * 1 text box to submit answers
     * 1 label to show the current letter to type
     * 1 label showing what to do
     * 1 status strip to contain the...
     * 1 tool strip progress bar, which is powered by...
     * 1 timer, to create a time limit of typing words
     * 1 tool tip to show what DEFINITELY NOT to do in the text box for confused users
     * 1 error provider, to show when there is an incorrect key type (doesn't show for enter to be sneaky)
     */
    public partial class GameForm : Form
    {
        //Creates the letters to choose from and display
        string[] alphabet = new string[26];
        //The answers and the amount of answers given
        List<string> answers = new List<string>();
        int answerNum = 0;
        //Import random
        Random random = new Random();
        //Current letter
        string letter = "";

        public GameForm()
        {
            InitializeComponent();
            //Creates the alphabet
            alphabet[0] = "A";
            alphabet[1] = "B";
            alphabet[2] = "C";
            alphabet[3] = "D";
            alphabet[4] = "E";
            alphabet[5] = "F";
            alphabet[6] = "G";
            alphabet[7] = "H";
            alphabet[8] = "I";
            alphabet[9] = "J";
            alphabet[10] = "K";
            alphabet[11] = "L";
            alphabet[12] = "M";
            alphabet[13] = "N";
            alphabet[14] = "O";
            alphabet[15] = "P";
            alphabet[16] = "Q";
            alphabet[17] = "R";
            alphabet[18] = "S";
            alphabet[19] = "T";
            alphabet[20] = "U";
            alphabet[21] = "V";
            alphabet[22] = "W";
            alphabet[23] = "X";
            alphabet[24] = "Y";
            alphabet[25] = "Z";

            //Keypress event so that we can filter viable keys
            this.textBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            //creates submit button functionality
            this.submitButton.Click += new EventHandler(SubmitButton_Click);
            //Creates a timer tick
            this.timer.Tick += new EventHandler(Timer_Tick);
            //Chooses the first letter
            ChooseLetter();
            //initialze the timer and progress bar
            this.timer.Interval = 1000;
            this.toolStripProgressBar1.Value = 100;
            timer.Start();
        }

        //Function to choose the letter on start and submissions
        //Get a ranndom number between 0-25
        //Grab the letter from alphabet array
        //Change the letter text to the current letter
        private void ChooseLetter()
        {
            int number = random.Next(0, 26);
            letter = alphabet[number];
            letterLabel.Text = letter;
        } 

        //When a key is pressed...
        //If the text box is empty, only allow the user to type the given letter
        //If they do not type the given letter, throw the error provider
        //If it is not the first letter, if the key typed is not a letter, backspace, or enter...
        //Throw an error provider.
        //This adds 0 functionality to the enter key, inconveniencing the user with the submit button
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.textBox.Text == null || this.textBox.Text == "")
            {
                if(e.KeyChar.ToString().ToLower() != letter.ToLower())
                {
                    e.Handled = true;
                    this.errorProvider.SetError(textBox, "The word must start with " + letter);
                }
            }
            else if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = true;
                this.errorProvider.SetError(textBox, "The word can only contain letters");
            }
            else
            {
                this.errorProvider.SetError(textBox, null);
            }
        }
        //When the submit button is pressed...
        //If the word is more than just the starting letter and the text box isn't empty...
        //Add the word to the list and increase the answer number, then choose a new letter and clear the text box
        //If the text box is empty, throw an error provider
        //If the text box is only 1 letter, throw an error provider
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(this.textBox.Text != null && this.textBox.Text.Length > 1)
            {
                answers.Add(this.textBox.Text);
                answerNum++;
                textBox.Clear();
                ChooseLetter();
            }
            else if(this.textBox.Text != null || this.textBox.Text.Length == 0)
            {
                this.errorProvider.SetError(textBox, "Must enter a word starting with " + letter);
            }
            else if(this.textBox.Text.Length == 1)
            {
                this.errorProvider.SetError(textBox, "Your word can't just be " + letter + "!");
            }
        }

        //As the timer ticks...
        //Decrease the progress bar
        //If the progres bar is up...
        //Stop the timer, change the type label to display that the user is out of time, and wait 1 second
        //Start the end-form
        private void Timer_Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar1.Value;
            if (this.toolStripProgressBar1.Value == 0)
            {
                this.timer.Stop();
                this.commandLabel.Text = "You're out of time!";
                Thread.Sleep(1000);
                EndForm form = new EndForm(this.answers, this.answerNum);
                form.Show();
                
            }
        }
    }
}

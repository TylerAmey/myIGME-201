using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFromHell
{
    public partial class EndForm : Form
    {
        //Create the global answer list and the number of correct answers
        List<string> answers;
        int answerNums;
        //Import random
        Random random = new Random();
        public EndForm(List<string> answers, int answerNums)
        {
            InitializeComponent();
            //Set the answerss sent in by form 2 to the globals
            this.answers = answers;
            this.answerNums = answerNums;
            //Set event handlers for the exit button
            this.exitButton.Click += new EventHandler(ExitButton_Click);
            //Set the mouse-hover as hinted in form 1, that disorients the user
            this.exitButton.MouseHover += new EventHandler(ExitButton_Hover);

            //Set the score label to the amount of words typed
            this.scoreLabel.Text = this.answerNums.ToString();

            //Loop through the list of words and add them to the label in the flow box
            string finalWords = "";
            foreach(string answer in this.answers)
            {
                finalWords += answer + "\n";
            }

            this.wordsListLabel.Text = finalWords;
        }
        //Exit button functionality
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //When the exit button is hovered on...
        //Move the button to a random point on the form using random coordinates.
        private void ExitButton_Hover(object sender, EventArgs e)
        {
            int x = random.Next(0,725);
            int y = random.Next(0, 450);
            this.exitButton.Location = new Point(x, y);
        }

    }
}

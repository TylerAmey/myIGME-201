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
 * Thread for counter label
 * 1 Start button to start the game
 * 1 Label to label the start button, to make users think that that is the start button
 * 1 label to count down until the game starts
 */

    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();

            this.counterLabel.Visible = false;
            //Creates functionality of the start button
            this.startButton.Click += new EventHandler(StartButton_Click);
            //Creates the inconvenience of the start button moving. Only moves once to set the user up for the multiple
            //Movements of the exit button on the 3rd form
            this.startButton.MouseHover += new EventHandler(StartButton_Hover);
        }

        //When the start button is clicked...
        //Make the start button and lable invisible and the counter visible
        //Count down from 3 until the game starts.
        //When the timer gets to 2, it "lags" using a thread
        //Show the next form
        private void StartButton_Click(object sender, EventArgs e)
        {
            this.counterLabel.Visible = true;
            this.startLabel.Visible = false;
            this.startButton.Visible = false;

            for (int i = 3; i > 0; --i)
            {
                this.counterLabel.Text = i.ToString();
                this.Refresh();
                Thread.Sleep(1000);
                if(i == 2)
                {
                    Thread.Sleep(3000);
                }
            }

            GameForm form = new GameForm();
            form.Show();
            
        }
        //When the start button is hovered upon...
        //Move the button to the top left corner, and change the text f the start label.
        private void StartButton_Hover(object sender, EventArgs e)
        {
            this.startButton.Location = new Point(12, 12);
            this.startLabel.Text = "What's wrong? Click the start button already!";
            this.startLabel.Location = new Point(150, this.startLabel.Location.Y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PresidentPseudo
{

        /*Architecture
         * 16 Radio Buttons to show the individual president
         * 16 Text Boxes to type the number president each president was
         * 1 picture box to show the president that has the radio button clicked
         * 1 group box for the filter radio buttons
         * 5 radio buttons to filter the presidents by party within the group box
         * 1 group box to hold the web browser
         * 1 web browser to show the wiki of each president and fireworks video
         * 1 exit button to exit the application
         * 1 status strip to hold the toolstrip progress bar
         * 1 tool strip progress bar to represent the timer
         * 1 timer to limit the time to type the numbers in
         * 1 tool tip to show what to type within the text box
         * 1 error provider to show if you are wrong in your answer
         * 
         * Total: 47 controls
         */

    public partial class Presidents : Form
    {
        /*Create arrays of presidents for later use
         * President radio button array
         * President text box array
         * Democrat / Republican arrays
         */

        Control[] presidentButtons = new Control[16];
        Control[] presidentTextBoxes = new Control[16];
        Control[] democratButtons = new Control[7];
        Control[] republicanButtons = new Control[6];
        public Presidents()
        {
            //Initialize the form

            InitializeComponent();

            //Add items to each array for later use
            presidentButtons[0] = harrisonRadioButton;
            presidentButtons[1] = frankRooseveltRadioButton;
            presidentButtons[2] = clintonRadioButton;
            presidentButtons[3] = buchananRadioButton;
            presidentButtons[4] = pierceRadioButton;
            presidentButtons[5] = bushRadioButton;
            presidentButtons[6] = obamaRadioButton;
            presidentButtons[7] = kennedyRadioButton;
            presidentButtons[8] = mcKinleyRadioButton;
            presidentButtons[9] = reaganRadioButton;
            presidentButtons[10] = eisenhowerRadioButton;
            presidentButtons[11] = vanBurenRadioButton;
            presidentButtons[12] = washingtonRadioButton;
            presidentButtons[13] = adamsRadioButton;
            presidentButtons[14] = tedRooseveltRadioButton;
            presidentButtons[15] = jeffersonRadioButton;

            presidentTextBoxes[0] = harrisonTextBox;
            presidentTextBoxes[1] = frankRooseveltTextBox;
            presidentTextBoxes[2] = clintonTextBox;
            presidentTextBoxes[3] = buchananTextBox;
            presidentTextBoxes[4] = pierceTextBox;
            presidentTextBoxes[5] = bushTextBox;
            presidentTextBoxes[6] = obamaTextBox;
            presidentTextBoxes[7] = kennedyTextBox;
            presidentTextBoxes[8] = mcKinleyTextBox;
            presidentTextBoxes[9] = reaganTextBox;
            presidentTextBoxes[10] = eisenhowerTextBox;
            presidentTextBoxes[11] = vanBurenTextBox;
            presidentTextBoxes[12] = washingtonTextBox;
            presidentTextBoxes[13] = adamsTextBox;
            presidentTextBoxes[14] = tedRoosaveltTextBox;
            presidentTextBoxes[15] = jeffersonTextBox;



            republicanButtons[0] = harrisonRadioButton;
            republicanButtons[1] = bushRadioButton;
            republicanButtons[2] = mcKinleyRadioButton;
            republicanButtons[3] = reaganRadioButton;
            republicanButtons[4] = eisenhowerRadioButton;
            republicanButtons[5] = tedRoosaveltTextBox;

            democratButtons[0] = frankRooseveltRadioButton;
            democratButtons[1] = clintonRadioButton;
            democratButtons[2] = buchananRadioButton;
            democratButtons[3] = pierceRadioButton;
            democratButtons[4] = obamaRadioButton;
            democratButtons[5] = kennedyRadioButton;
            democratButtons[6] = vanBurenRadioButton;

            //Add event handlers on each president radio button
            this.harrisonRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.frankRooseveltRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.clintonRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.buchananRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.pierceRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.bushRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.obamaRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.kennedyRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.mcKinleyRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.reaganRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.eisenhowerRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.vanBurenRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.washingtonRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.adamsRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.tedRooseveltRadioButton.Click += new EventHandler(PresidentRadioButton_Click);
            this.jeffersonRadioButton.Click += new EventHandler(PresidentRadioButton_Click);

            //Add event handlers on each filter radio button
            this.allRadioButton.Click += new EventHandler(FilterRadioButton_Click);
            this.democratRadioButton.Click += new EventHandler(FilterRadioButton_Click);
            this.republicanRadioButton.Click += new EventHandler(FilterRadioButton_Click);
            this.demRepRadioButton.Click += new EventHandler(FilterRadioButton_Click);
            this.federalistRadioButton.Click += new EventHandler(FilterRadioButton_Click);

            //Add exit button event handler
            this.exitButton.Click += new EventHandler(ExitButton_Click);

            //Add event handler to the picture box to grow and shrink when hovered on
            this.pictureBox.MouseEnter += new EventHandler(PictureBox_MouseHover);
            this.pictureBox.MouseLeave += new EventHandler(PictureBox_MouseLeave);

            //Add keypress event handlers so only numbers can by typed within the text boxes
            this.harrisonTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.frankRooseveltTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.clintonTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.buchananTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.pierceTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.bushTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.obamaTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.kennedyTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.mcKinleyTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.reaganTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.eisenhowerTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.vanBurenTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.washingtonTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.adamsTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.tedRoosaveltTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.jeffersonTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
  
            //Add INDIVUDUAL event handlers to the text boxes to check to see if the
            //numbers typed are correct
            this.harrisonTextBox.TextChanged += new EventHandler(HarrisonTextBox_TextChanged);
            this.frankRooseveltTextBox.TextChanged += new EventHandler(FrankRooseveltTextBox_TextChanged);
            this.clintonTextBox.TextChanged += new EventHandler(ClintonTextBox_TextChanged);
            this.buchananTextBox.TextChanged += new EventHandler(BuchananTextBox_TextChanged);
            this.pierceTextBox.TextChanged += new EventHandler(PierceTextBox_TextChanged);
            this.bushTextBox.TextChanged += new EventHandler(BushTextBox_TextChanged);
            this.obamaTextBox.TextChanged += new EventHandler(ObamaTextBox_TextChanged);
            this.kennedyTextBox.TextChanged += new EventHandler(KennedyTextBox_TextChanged);
            this.mcKinleyTextBox.TextChanged += new EventHandler(McKinleyTextBox_TextChanged);
            this.reaganTextBox.TextChanged += new EventHandler(ReaganTextBox_TextChanged);
            this.eisenhowerTextBox.TextChanged += new EventHandler(EisenhowerTextBox_TextChanged);
            this.vanBurenTextBox.TextChanged += new EventHandler(VanBurenTextBox_TextChanged);
            this.washingtonTextBox.TextChanged += new EventHandler(WashingtonTextBox_TextChanged);
            this.adamsTextBox.TextChanged += new EventHandler(AdamsTextBox_TextChanged);
            this.tedRoosaveltTextBox.TextChanged += new EventHandler(TedRoosaveltTextBox_TextChanged);
            this.jeffersonTextBox.TextChanged += new EventHandler(JeffersonTextBox_TextChanged);

            //Add a tick event handler to the timer
            this.timer.Tick += new EventHandler(Timer_Tick);
        }

        /*
                Show wiki page for the clicked president
                Change the groupBox label
                Change picture box image to specified president
                Defualt to first radio button on the page
         */

        //When a president radio button clicked...
        //If the radio button is x president...
        //Show x president's url in the webbrowser
        //Change the webbrowser group box text to be the url
        //Change the image within the picture box of the president
        private void PresidentRadioButton_Click(object sender, EventArgs e)
        {
            if (this.harrisonRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\BenjaminHarrison.jpeg";
            }

            else if (this.frankRooseveltRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\FranklinDRoosevelt.jpeg";
            }

            else if (this.clintonRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/William_J_Clinton");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_J_Clinton";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\WilliamJClinton.jpeg";
            }
            else if (this.buchananRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/James_Buchanan");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\JamesBuchanan.jpeg";
            }
            else if (this.pierceRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\FranklinPierce.jpeg";
            }
            else if (this.bushRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/George_W_Bush");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_W_Bush";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\GeorgeWBush.jpeg";
            }
            else if (this.obamaRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Barack_Obama");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\BarackObama.png";
            }
            else if (this.kennedyRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/John_F_Kennedy");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_F_Kennedy";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\JohnFKennedy.jpeg";
            }
            else if (this.mcKinleyRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/William_McKinley");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\WilliamMcKinley.jpeg";
            }
            else if (this.reaganRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\RonaldReagan.jpeg";
            }
            else if (this.eisenhowerRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\DwightDEisenhower.jpeg";
            }
            else if (this.vanBurenRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Martin_VanBuren");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Martin_VanBuren";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\MartinVanBuren.jpeg";
            }
            else if (this.washingtonRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/George_Washington");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\GeorgeWashington.jpeg";
            }
            else if (this.adamsRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/John_Adams");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\JohnAdams.jpeg";
            }
            else if (this.tedRooseveltRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\TheodoreRoosevelt.jpeg";
            }
            else if (this.jeffersonRadioButton.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
                webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
                pictureBox.ImageLocation = @"C:\Users\tyler\Presidents\ThomasJefferson.jpeg";
            }
        }

        //When a filter radio button is clicked...
        private void FilterRadioButton_Click(object sender, EventArgs e)
        {
            //if the "all" radio button was checked, make every button visible
            //check and click the first button on the list
            if (this.allRadioButton.Checked)
            {
                foreach(Control control in presidentButtons)
                {
                    control.Visible = true;
                }
                this.harrisonRadioButton.Checked = true;
                this.harrisonRadioButton.PerformClick();
            }
            //if the "democrat" radio button was checked, loop through the
            //democrat button array and make those buttons visible
            //check and click the first button on the list
            else if (this.democratRadioButton.Checked)
            {
                foreach (Control control in presidentButtons)
                {
                    control.Visible = false;
                    foreach(Control democrat in democratButtons)
                    {
                        if (control == democrat)
                        {
                            control.Visible = true;
                        }
                    }
                }
                this.frankRooseveltRadioButton.Checked = true;
                this.frankRooseveltRadioButton.PerformClick();
            }
            //if the "republican" radio button was checked, loop through the
            //republican button array and make those buttons visible
            //check and click the first button on the list
            else if (this.republicanRadioButton.Checked)
            {
                foreach (Control control in presidentButtons)
                {
                    control.Visible = false;
                    foreach (Control republican in republicanButtons)
                    {
                        if (control == republican)
                        {
                            control.Visible = true;
                        }
                    }
                }
                this.harrisonRadioButton.Checked = true;
                this.harrisonRadioButton.PerformClick();
            }
            //if the "democratic republican" radio button was checked...
            //Make every president invisible except for Thomas Jefferson
            //check and click the Thomas Jefferson button on the list
            else if (this.demRepRadioButton.Checked)
            {
                foreach (Control control in presidentButtons)
                {
                    control.Visible = false;
                    if (control == jeffersonRadioButton)
                    {
                        control.Visible = true;
                    }
                }
                this.jeffersonRadioButton.Checked = true;
                this.jeffersonRadioButton.PerformClick();
            }
            //if the "federalist" radio button was checked...
            //Make every president invisible except for Washington and Adams
            //check and click the first button on the list
            else if (this.federalistRadioButton.Checked)
            {
                foreach (Control control in presidentButtons)
                {
                    control.Visible = false;
                    if (control == washingtonRadioButton || control == adamsRadioButton)
                    {
                        control.Visible = true;
                    }
                }
                this.washingtonRadioButton.Checked = true;
                this.washingtonRadioButton.PerformClick();
            }

        }
        //When the text on the president text boxes are changed, each president
        //will have an individual method in order to check if their number is valud
        //If your answer is not yet correct, you are locked into only typing the
        //correct answer
        //While you answer is incorrect, the error provider will pop up
        //When your answer is correct, you are free to use all buttons and text
        //boxes, and the error provider will disapear
        private void HarrisonTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.harrisonTextBox.Text != "23")
            {
                PresidentControlsDisabled(this.harrisonTextBox);
                
            }
            else
            {
                PresidentControlEnabled(this.harrisonTextBox);
            }
        }

        private void FrankRooseveltTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.frankRooseveltTextBox.Text != "32")
            {
                PresidentControlsDisabled(this.frankRooseveltTextBox);
                
            }
            else
            {
                PresidentControlEnabled(this.frankRooseveltTextBox);
            }
        }

        private void ClintonTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.clintonTextBox.Text != "42")
            {
                PresidentControlsDisabled(this.clintonTextBox);
            }
            else
            {
                PresidentControlEnabled(this.clintonTextBox);
            }
        }

        private void BuchananTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.buchananTextBox.Text != "15")
            {
                PresidentControlsDisabled(this.buchananTextBox);
            }
            else
            {
                PresidentControlEnabled(this.buchananTextBox);
            }
        }

        private void PierceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.pierceTextBox.Text != "14")
            {
                PresidentControlsDisabled(this.pierceTextBox);
            }
            else
            {
                PresidentControlEnabled(this.pierceTextBox);
            }
        }

        private void BushTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.bushTextBox.Text != "43")
            {
                PresidentControlsDisabled(this.bushTextBox);
            }
            else
            {
                PresidentControlEnabled(this.bushTextBox);
            }
        }

        private void ObamaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.obamaTextBox.Text != "44")
            {
                PresidentControlsDisabled(this.obamaTextBox);
            }
            else
            {
                PresidentControlEnabled(this.obamaTextBox);
            }
        }

        private void KennedyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.kennedyTextBox.Text != "35")
            {
                PresidentControlsDisabled(this.kennedyTextBox);
            }
            else
            {
                PresidentControlEnabled(this.kennedyTextBox);
            }
        }

        private void McKinleyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.mcKinleyTextBox.Text != "25")
            {
                PresidentControlsDisabled(this.mcKinleyTextBox);
            }
            else
            {
                PresidentControlEnabled(this.mcKinleyTextBox);
            }
        }

        private void ReaganTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.reaganTextBox.Text != "40")
            {
                PresidentControlsDisabled(this.reaganTextBox);
            }
            else
            {
                PresidentControlEnabled(this.reaganTextBox);
            }
        }

        private void EisenhowerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.eisenhowerTextBox.Text != "34")
            {
                PresidentControlsDisabled(this.eisenhowerTextBox);
            }
            else
            {
                PresidentControlEnabled(this.eisenhowerTextBox);
            }
        }

        private void VanBurenTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.vanBurenTextBox.Text != "8")
            {
                PresidentControlsDisabled(this.vanBurenTextBox);
            }
            else
            {
                PresidentControlEnabled(this.vanBurenTextBox);
            }
        }

        private void WashingtonTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.washingtonTextBox.Text != "1")
            {
                PresidentControlsDisabled(this.washingtonTextBox);
            }
            else
            {
                PresidentControlEnabled(this.washingtonTextBox);
            }
        }

        private void AdamsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.adamsTextBox.Text != "2")
            {
                PresidentControlsDisabled(this.adamsTextBox);
            }
            else
            {
                PresidentControlEnabled(this.adamsTextBox);
            }
        }

        private void TedRoosaveltTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.tedRoosaveltTextBox.Text != "26")
            {
                PresidentControlsDisabled(this.tedRoosaveltTextBox);
            }
            else
            {
                PresidentControlEnabled(this.tedRoosaveltTextBox);
            }
        }

        private void JeffersonTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.jeffersonTextBox.Text != "3")
            {
                PresidentControlsDisabled(this.jeffersonTextBox);
            }
            else
            {
                PresidentControlEnabled(this.jeffersonTextBox);
            }
        }
        //Everytime a correct answer is given, the code will check to see if ALL
        //correct answers are provided.
        //If they are, return true. If not, return false.
        private bool Check_Win()
        {
            bool win = true;
            if (this.jeffersonTextBox.Text != "3")
            {
                win = false;
            }
            else if (this.tedRoosaveltTextBox.Text != "26")
            {
                win = false;
            }
            else if (this.adamsTextBox.Text != "2")
            {
                win = false;
            }
            else if (this.washingtonTextBox.Text != "1")
            {
                win = false;
            }
            else if (this.vanBurenTextBox.Text != "8")
            {
                win = false;
            }
            else if (this.eisenhowerTextBox.Text != "34")
            {
                win = false;
            }
            else if (this.reaganTextBox.Text != "40")
            {
                win = false;
            }
            else if (this.mcKinleyTextBox.Text != "25")
            {
                win = false;
            }
            else if (this.kennedyTextBox.Text != "35")
            {
                win = false;
            }
            else if (this.obamaTextBox.Text != "44")
            {
                win = false;
            }
            else if (this.bushTextBox.Text != "43")
            {
                win = false;
            }
            else if (this.pierceTextBox.Text != "14")
            {
                win = false;
            }
            else if (this.buchananTextBox.Text != "15")
            {
                win = false;
            }
            else if (this.clintonTextBox.Text != "42")
            {
                win = false;
            }
            else if (this.frankRooseveltTextBox.Text != "32")
            {
                win = false;
            }
            else if (this.harrisonTextBox.Text != "23")
            {
                win = false;
            }

            return win;
        }
        //When the picture box is hovered upon, double the size
        private void PictureBox_MouseHover(object sender, EventArgs e)
        {
            pictureBox.Size = new Size(pictureBox.Width * 2, pictureBox.Height * 2);
        }
        //When the picture box is no longer hovered upon, set the size back to normal
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            pictureBox.Size = new Size(pictureBox.Width / 2, pictureBox.Height / 2);
        }
        //When the exit button is clicked, exit the application.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //This is to help with text box control
        //While the correct answer is not typed...
        //The error provider will show, and all president radio buttons and
        //text boxes are disabled except for the CURRENT text box
        private void PresidentControlsDisabled(Control currentTextBox)
        {
            foreach (Control radio in presidentButtons)
            {
                radio.Enabled = false;
                this.errorProvider.SetError(currentTextBox, "That is the wrong number.");
            }
            foreach (Control text in presidentTextBoxes)
            {
                text.Enabled = true;
                if (text != currentTextBox)
                {
                    text.Enabled = false;
                }
            }
        }
        //This is to help with text box control
        //When the correct answer is typed...
        //Enable all text boxes and president radio buttons
        //Also, check to see if all text boxes are correct using the "Check_Win()" function
        //If so, change the url of the web browser to the youtube video for celebration
        //Stop the timer after the win
        private void PresidentControlEnabled(Control currentTextBox)
        {
            this.errorProvider.SetError(currentTextBox, null);
            foreach (Control radio in presidentButtons)
            {
                radio.Enabled = true;
            }
            foreach (Control text in presidentTextBoxes)
            {
                text.Enabled = true;
            }

            if(Check_Win() == true)
            {
                webBrowser.Url = new Uri("https://www.youtube.com/embed/18212B4yfLg?autoplay=1");
                timer.Stop();
            }
        }
        //When a key is pressed...
        //The only characters that can be typed are numbers
        //If this is the first time a text box has been edited...
        //Initialize the timer
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (timer.Enabled == false)
            {
                this.timer.Interval = 500;
                this.toolStripProgressBar1.Value = 200;
                timer.Start();
            }
        }
        //Timer tick function
        //As the timer ticks, reduce the progress bar
        //if the progress bar is empty...
        //stop the timer and reset the progress bar
        //set all president text boxes back to 0.
        private void Timer_Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar1.Value;
            if (this.toolStripProgressBar1.Value == 0)
            {
                this.timer.Stop();
                this.toolStripProgressBar1.Value = 100;
                
                foreach(Control textBox in presidentTextBoxes)
                {
                    textBox.Text = "0";
                }
            }
        }
    }
}

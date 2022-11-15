namespace ParametersForm
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.currentGuess = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentGuess
            // 
            this.currentGuess.Location = new System.Drawing.Point(115, 156);
            this.currentGuess.Name = "currentGuess";
            this.currentGuess.Size = new System.Drawing.Size(100, 20);
            this.currentGuess.TabIndex = 0;
            this.currentGuess.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(125, 249);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(89, 13);
            this.output.TabIndex = 1;
            this.output.Text = "Guess a Number!";
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(128, 198);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(75, 23);
            this.guess.TabIndex = 2;
            this.guess.Text = "Guess";
            this.guess.UseVisualStyleBackColor = true;
            this.guess.Click += new System.EventHandler(this.guess_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(313, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "Timer:";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // GameForm
            // 
            this.AcceptButton = this.guess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 317);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.output);
            this.Controls.Add(this.currentGuess);
            this.Name = "GameForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentGuess;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button guess;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
    }
}
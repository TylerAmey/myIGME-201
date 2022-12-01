namespace UIFromHell
{
    partial class EndForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.displayScoreLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.wordsListLabel = new System.Windows.Forms.Label();
            this.displayWordsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(360, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Leave.";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // displayScoreLabel
            // 
            this.displayScoreLabel.AutoSize = true;
            this.displayScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.displayScoreLabel.Font = new System.Drawing.Font("PeachyKeenJF", 50F);
            this.displayScoreLabel.ForeColor = System.Drawing.Color.White;
            this.displayScoreLabel.Location = new System.Drawing.Point(179, 27);
            this.displayScoreLabel.Name = "displayScoreLabel";
            this.displayScoreLabel.Size = new System.Drawing.Size(448, 97);
            this.displayScoreLabel.TabIndex = 1;
            this.displayScoreLabel.Text = "Your Score!";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(386, 152);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(13, 13);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "0";
            // 
            // wordsListLabel
            // 
            this.wordsListLabel.AutoSize = true;
            this.wordsListLabel.Location = new System.Drawing.Point(3, 0);
            this.wordsListLabel.Name = "wordsListLabel";
            this.wordsListLabel.Size = new System.Drawing.Size(13, 13);
            this.wordsListLabel.TabIndex = 4;
            this.wordsListLabel.Text = "0";
            // 
            // displayWordsLabel
            // 
            this.displayWordsLabel.AutoSize = true;
            this.displayWordsLabel.BackColor = System.Drawing.Color.Transparent;
            this.displayWordsLabel.Font = new System.Drawing.Font("PeachyKeenJF", 50F);
            this.displayWordsLabel.ForeColor = System.Drawing.Color.White;
            this.displayWordsLabel.Location = new System.Drawing.Point(162, 194);
            this.displayWordsLabel.Name = "displayWordsLabel";
            this.displayWordsLabel.Size = new System.Drawing.Size(481, 97);
            this.displayWordsLabel.TabIndex = 3;
            this.displayWordsLabel.Text = "Your Words!";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.wordsListLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(354, 280);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(90, 100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UIFromHell.Properties.Resources.Zen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.displayWordsLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.displayScoreLabel);
            this.Name = "EndForm";
            this.Text = "UI From Hell";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label displayScoreLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label wordsListLabel;
        private System.Windows.Forms.Label displayWordsLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
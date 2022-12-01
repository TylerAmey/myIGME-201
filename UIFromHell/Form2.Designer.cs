namespace UIFromHell
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
            this.submitButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.letterLabel = new System.Windows.Forms.Label();
            this.commandLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(369, 287);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(60, 21);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(302, 261);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(197, 20);
            this.textBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox, "Definitely DON\'T type words that begin with this letter");
            // 
            // letterLabel
            // 
            this.letterLabel.AutoSize = true;
            this.letterLabel.BackColor = System.Drawing.Color.Transparent;
            this.letterLabel.Font = new System.Drawing.Font("MV Boli", 50F, System.Drawing.FontStyle.Bold);
            this.letterLabel.ForeColor = System.Drawing.Color.White;
            this.letterLabel.Location = new System.Drawing.Point(354, 103);
            this.letterLabel.Name = "letterLabel";
            this.letterLabel.Size = new System.Drawing.Size(84, 87);
            this.letterLabel.TabIndex = 2;
            this.letterLabel.Text = "A";
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.BackColor = System.Drawing.Color.Black;
            this.commandLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.commandLabel.Location = new System.Drawing.Point(359, 204);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(79, 28);
            this.commandLabel.TabIndex = 3;
            this.commandLabel.Text = "TYPE!";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(750, 16);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Wrong Information";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UIFromHell.Properties.Resources.Zen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.letterLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.submitButton);
            this.Name = "GameForm";
            this.Text = "1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label letterLabel;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
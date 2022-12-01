namespace UIFromHell
{
    partial class StartForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.startButton.Cursor = System.Windows.Forms.Cursors.No;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.Font = new System.Drawing.Font("Old English Text MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.startButton.Location = new System.Drawing.Point(318, 309);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 20);
            this.startButton.TabIndex = 0;
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Green;
            this.startLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startLabel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.startLabel.Font = new System.Drawing.Font("TS Block Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startLabel.Location = new System.Drawing.Point(350, 236);
            this.startLabel.Name = "startLabel";
            this.startLabel.Padding = new System.Windows.Forms.Padding(10);
            this.startLabel.Size = new System.Drawing.Size(87, 34);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "STart";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.BackColor = System.Drawing.Color.Transparent;
            this.counterLabel.Font = new System.Drawing.Font("MV Boli", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.ForeColor = System.Drawing.Color.White;
            this.counterLabel.Location = new System.Drawing.Point(355, 139);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(82, 87);
            this.counterLabel.TabIndex = 2;
            this.counterLabel.Text = "3";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UIFromHell.Properties.Resources.Zen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "StartForm";
            this.Text = "UI From Hell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label counterLabel;
    }
}


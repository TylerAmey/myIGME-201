namespace Dyscord
{
    partial class DyscordForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.convRichTextBox = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.msgTextBox = new System.Windows.Forms.RichTextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.logginButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Controls.Add(this.convRichTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversation";
            // 
            // convRichTextBox
            // 
            this.convRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.convRichTextBox.Name = "convRichTextBox";
            this.convRichTextBox.Size = new System.Drawing.Size(794, 431);
            this.convRichTextBox.TabIndex = 0;
            this.convRichTextBox.Text = "";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowser1.Location = new System.Drawing.Point(3, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(794, 278);
            this.webBrowser1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 356);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.msgTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Panel2.Controls.Add(this.usersButton);
            this.splitContainer1.Panel2.Controls.Add(this.sendButton);
            this.splitContainer1.Panel2.Controls.Add(this.logginButton);
            this.splitContainer1.Panel2.Controls.Add(this.userTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 94);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 1;
            // 
            // msgTextBox
            // 
            this.msgTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgTextBox.Location = new System.Drawing.Point(0, 0);
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(535, 94);
            this.msgTextBox.TabIndex = 0;
            this.msgTextBox.Text = "";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(5, 15);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(148, 20);
            this.userTextBox.TabIndex = 0;
            // 
            // logginButton
            // 
            this.logginButton.Location = new System.Drawing.Point(174, 15);
            this.logginButton.Name = "logginButton";
            this.logginButton.Size = new System.Drawing.Size(75, 23);
            this.logginButton.TabIndex = 1;
            this.logginButton.Text = "Loggin";
            this.logginButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(5, 55);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(86, 55);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(75, 23);
            this.usersButton.TabIndex = 3;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(174, 55);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // DyscordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DyscordForm";
            this.Text = "Dyscord";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox convRichTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox msgTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button logginButton;
        private System.Windows.Forms.TextBox userTextBox;
    }
}
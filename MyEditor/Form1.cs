using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_Click);
            this.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem_Click);
            this.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);

            this.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem_Click);
            this.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem_Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem_Click);

            this.toolStrip1.ItemClicked += new ToolStripItemClickedEventHandler(ToolStip_ItemClick);

            this.Text = "MyEditor";
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.Text = "MyEditor";
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = new RichTextBoxStreamType();
                if (openFileDialog1.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox1.LoadFile(openFileDialog1.FileName, richTextBoxStreamType);
                this.Text = "MyEditor (" + openFileDialog1.FileName + ")";
            }
        }


        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = openFileDialog1.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = new RichTextBoxStreamType();
                if (saveFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox1.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);
                this.Text = "MyEditor (" + saveFileDialog.FileName + ")";
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ToolStip_ItemClick(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            if(e.ClickedItem == this.boldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;
            }


            else if (e.ClickedItem == this.italicsToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton;
            }

            else if (e.ClickedItem == this.underlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            }

            else if(e.ClickedItem == this.colorToolStripButton)
            {
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;
                }
            }

            if( fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }

        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox1.SelectionFont;
            if(selectionFont == null)
            {
                selectionFont = richTextBox1.Font;
            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox1.SelectionFont = newFont;
        }










        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIFFinder
{
    public partial class SearchForm : Form
    {
        public string response;
        public string searchTerm;
        public int maxItems;
        public SearchForm()
        {
            InitializeComponent();

            this.cancelButton.Click += new EventHandler(CancelButton_Click);
            this.cancelButton.Click += new EventHandler(OkButton_Click);
            this.maxItemsTextBox.KeyPress += new KeyPressEventHandler(MaxItemsTextBox_KeyPress);

        }

        private void MaxItemsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.response = "Cancel";
            this.searchTerm = searchTermTextBox.Text;
            this.maxItems = Convert.ToInt32(maxItemsTextBox.Text);
            this.Hide();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.response = "OK";
            this.searchTerm = searchTermTextBox.Text;
            this.maxItems = Convert.ToInt32(maxItemsTextBox.Text);
            this.Hide();
        }













        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

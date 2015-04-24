﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaMMBo.Test
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void searchByNameButton_Click(object sender, EventArgs e)
        {
            if (Controller.frmSearch.searchFormLabel1.Text.Trim() == "")
                MessageBox.Show("Check your input please.");
            else
            {
                Proxy.searchByName(Controller.frmSearch.searchFormTextBox.Text);
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            
            if (Proxy.choice == 1)
            {
                searchFormDropBox.Items.Add("Rap");
                searchFormDropBox.Items.Add("Rock");
                searchFormDropBox.Items.Add("Hip Hop");
                searchFormDropBox.Items.Add("Country");
                searchFormDropBox.Items.Add("Metal");
                searchFormDropBox.Items.Add("Pop");
                searchFormDropBox.Items.Add("Electronic");

            }
            else if (Proxy.choice == 2)
            {
                searchFormDropBox.Items.Add("Comedy");
                searchFormDropBox.Items.Add("Thriller");
                searchFormDropBox.Items.Add("Fantasy");
                searchFormDropBox.Items.Add("Action");
                searchFormDropBox.Items.Add("Romance");

            }

            else if (Proxy.choice == 3)
            {
                searchFormDropBox.Items.Add("Romance");
                searchFormDropBox.Items.Add("Fantasy");
                searchFormDropBox.Items.Add("Mystery");
                searchFormDropBox.Items.Add("Thriller");
                searchFormDropBox.Items.Add("Science");
                searchFormDropBox.Items.Add("Fiction");
                searchFormDropBox.Items.Add("Novel");
                searchFormDropBox.Items.Add("Autobiography");
                searchFormDropBox.Items.Add("Young Adult");

            }
            else if (Proxy.choice == 4)
            {
                searchFormDropBox.Items.Add("Strategy");
                searchFormDropBox.Items.Add("Sports");
                searchFormDropBox.Items.Add("Adventure");
                searchFormDropBox.Items.Add("Fighting");
                searchFormDropBox.Items.Add("Racing");
                searchFormDropBox.Items.Add("RPG");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  searchFormDropBox.Text;
        }
    }
}
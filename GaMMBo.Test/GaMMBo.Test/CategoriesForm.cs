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
    public partial class CategoriesForm : Form
    {

        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        if (Controller.guest)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Do you want to save your changes and create an account? ", 
                    "Last Chance",MessageBoxButtons.YesNoCancel);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        Controller.frmCategories.Hide();
                        Controller.frmLogin.ShowDialog();
                        break;
                    case DialogResult.No:
                        Account.deleteTemproraryAccount();
                        break;
                    case DialogResult.Cancel:
                        Controller.frmCategories.ShowDialog();
                        break;

                }
            }

            Controller.frmCategories.Hide();
            Controller.frmMain.Show();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            
           // PrefMenu prefMenu = new PrefMenu(1);
            Controller.catName = "Music";
            Controller.frmPref.choice = 1;
            Controller.frmCategories.Hide();
            Controller.frmPref.ShowDialog();
            

        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            //PrefMenu prefMenu = new PrefMenu(2);
            Controller.catName = "Movies";
            Controller.frmPref.choice = 2;
            Controller.frmCategories.Hide();
            Controller.frmPref.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            //PrefMenu prefMenu = new PrefMenu(3);
            Controller.catName = "Books";
            Controller.frmPref.choice = 3;
            Controller.frmCategories.Hide();
            Controller.frmPref.ShowDialog();
           
        }

        private void gamesButton_Click(object sender, EventArgs e)
        {
            //PrefMenu prefMenu = new PrefMenu(4);

            Controller.catName = "Games";
            Controller.frmPref.choice = 4;
            Controller.frmCategories.Hide();
            Controller.frmPref.ShowDialog();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proxy.choice = 4;
            Controller.frmSearch.searchFormTextBox.Text = "";
            Controller.catName = "Games";
            Controller.frmPref.choice = 4;
            Controller.frmCategories.Hide();
            Controller.frmSearch.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proxy.choice = 1;
            Controller.frmSearch.searchFormTextBox.Text = "";
            Controller.catName = "Music";
            Controller.frmPref.choice = 1;
            Controller.frmCategories.Hide();
            Controller.frmSearch.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Proxy.choice = 2;
            Controller.frmSearch.searchFormTextBox.Text = "";
            Controller.catName = "Movies";
            Controller.frmPref.choice = 2;
            Controller.frmCategories.Hide();
            Controller.frmSearch.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proxy.choice = 3;
            Controller.frmSearch.searchFormTextBox.Text = "";
            Controller.catName = "Books";
            Controller.frmPref.choice = 3;
            Controller.frmCategories.Hide();
            Controller.frmSearch.ShowDialog();
        }
    }
}

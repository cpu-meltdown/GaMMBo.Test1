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
    }
}

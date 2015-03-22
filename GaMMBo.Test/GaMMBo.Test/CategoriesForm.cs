using System;
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

        char categoryType;
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MainForm frmMain = new MainForm();
            this.Hide();
            frmMain.ShowDialog();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            PrefMenu prefMenu = new PrefMenu();
            categoryType = '1';            // music category was chosen
            this.Hide();
            prefMenu.displayRandomObject(categoryType);
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            PrefMenu prefMenu = new PrefMenu();
            categoryType = '2';            // movies category was chosen
            this.Hide();
            prefMenu.displayRandomObject(categoryType);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            PrefMenu prefMenu = new PrefMenu();
            categoryType = '3';            // books category was chosen
            this.Hide();
            prefMenu.displayRandomObject(categoryType);
        }

        private void gamesButton_Click(object sender, EventArgs e)
        {
            PrefMenu prefMenu = new PrefMenu();
            categoryType = '4';            // games category was chosen
            this.Hide();
            prefMenu.displayRandomObject(categoryType);
        }
    }
}

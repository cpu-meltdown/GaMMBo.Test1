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
            PrefMenu prefMenu = new PrefMenu(1);
           
            this.Hide();
            prefMenu.ShowDialog();
           
            

        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            PrefMenu prefMenu = new PrefMenu(2);
    
            this.Hide();
            prefMenu.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            PrefMenu prefMenu = new PrefMenu(3);
           
            this.Hide();
            prefMenu.ShowDialog();
           
        }

        private void gamesButton_Click(object sender, EventArgs e)
        {
            PrefMenu prefMenu = new PrefMenu(4);
            
            this.Hide();
            prefMenu.ShowDialog();
        }
    }
}

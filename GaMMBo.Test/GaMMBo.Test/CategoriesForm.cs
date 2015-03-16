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
            MusicForm musicForm = new MusicForm();
            this.Hide();
            musicForm.ShowDialog();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            MoviesForm _moviesForm = new MoviesForm();
            this.Hide();
            _moviesForm.ShowDialog();
        }
    }
}

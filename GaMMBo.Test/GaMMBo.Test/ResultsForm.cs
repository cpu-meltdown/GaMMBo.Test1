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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void categoryImage_Click(object sender, EventArgs e)
        {
            Controller.frmPref.btnLike.Visible = false;
            Controller.frmPref.btnDislike.Visible = false;
            Controller.frmPref.btnSkip.Visible = false;
            Controller.frmPref.btnSearch.Visible = false;
            Controller.frmPref.btnSearch.Visible = false;
            Controller.frmPref.categoryImage.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\2.jpg");

            Controller.frmPref.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void top2_Click(object sender, EventArgs e)
        {

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            top1.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\2.jpg");
            top2.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\21.jpg");
            top3.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\22.jpg");
            top4.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\23.jpg");
            top5.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\24.jpg");
            top6.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\25.jpg");
            top7.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\26.jpg");
            top8.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\27.jpg");
            top9.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\28.jpg");
            top10.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\29.jpg");



        }

    }
}

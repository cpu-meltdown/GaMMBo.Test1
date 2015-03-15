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
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoriesDataSet1);

        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoriesDataSet1.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.categoriesDataSet1.Movies);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm _categoriesForm = new CategoriesForm();
            _categoriesForm.ShowDialog();
        }
    }
}

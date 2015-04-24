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
                comboBox1.Items.Add("Rap");
                comboBox1.Items.Add("Rock");
                comboBox1.Items.Add("Hip Hop");
                comboBox1.Items.Add("Country");
                comboBox1.Items.Add("Metal");
                comboBox1.Items.Add("Pop");
                comboBox1.Items.Add("Electronic");

            }
            else if (Proxy.choice == 2)
            {
                comboBox1.Items.Add("Comedy");
                comboBox1.Items.Add("Thriller");
                comboBox1.Items.Add("Fantasy");
                comboBox1.Items.Add("Action");
                comboBox1.Items.Add("Romance");

            }

            else if (Proxy.choice == 3)
            {
                comboBox1.Items.Add("Romance");
                comboBox1.Items.Add("Fantasy");
                comboBox1.Items.Add("Mystery");
                comboBox1.Items.Add("Thriller");
                comboBox1.Items.Add("Science");
                comboBox1.Items.Add("Fiction");
                comboBox1.Items.Add("Novel");
                comboBox1.Items.Add("Autobiography");
                comboBox1.Items.Add("Young Adult");

            }
            else if (Proxy.choice == 4)
            {
                comboBox1.Items.Add("Strategy");
                comboBox1.Items.Add("Sports");
                comboBox1.Items.Add("Adventure");
                comboBox1.Items.Add("Fighting");
                comboBox1.Items.Add("Racing");
                comboBox1.Items.Add("RPG");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

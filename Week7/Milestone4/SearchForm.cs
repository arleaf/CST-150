using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone4
{
    public partial class SearchForm : Form
    {
        //Search Form Class
        InventoryManager im;
        public SearchForm(InventoryManager im)
        {
            InitializeComponent();
            this.im = im;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            
            string found =im.search(brandcomboBox.Text, colortextBox.Text).ToString();
            MessageBox.Show("Found!" +"\n" + found);
        }
    }
}

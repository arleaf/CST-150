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
    public partial class AddForm : Form
    { 
        InventoryManager im;
        public AddForm(InventoryManager im)
        {
            //Sets combobox to index 0
            InitializeComponent();
            storagecomboBox.SelectedIndex = 0;
            brandcomboBox.SelectedIndex = 0;
            carriercomboBox.SelectedIndex = 0;
            this.im = im;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create phone object with select inputs from form
            Phone phone = new Phone(phoneNametextBox.Text, colorTextBox.Text, storagecomboBox.Text, brandcomboBox.Text, carriercomboBox.Text);
            //add to Inventory Manger object
            im.addInventory(phone);
            im.displayInventoryManager();
            this.Close();

        }
    }
}

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
    public partial class RestockForm : Form
    {
        //Restock Form Class
        InventoryManager im;

        
        public RestockForm(InventoryManager im)
        {
            InitializeComponent();
            this.im = im;
            //Add each phone name in Inventory Manger to the combobox
            foreach (Phone phone in im.inventoryManager)
            {
                restockcomboBox.Items.Add(phone.Name);
            }
        }

        private void RestockForm_Load(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restockButton_Click(object sender, EventArgs e)
        {

            int postion = restockcomboBox.SelectedIndex;
            int numRestock;
            //number of how much you would like to add to quantity
            int.TryParse(quantitytextBox.Text, out numRestock);
            //Call restock method
            im.restockInventory(im.inventoryManager[postion], numRestock);
            //Display new quantity amount
            newQuantityLabel.Text = im.inventoryManager[postion].Quantity.ToString();
        }
    }
}

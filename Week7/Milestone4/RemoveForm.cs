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
    public partial class RemoveForm : Form
    {
        InventoryManager im;
        public RemoveForm(InventoryManager im)
        {
            InitializeComponent();
            this.im = im;
            foreach(Phone phone in im.inventoryManager)
            {
                removeComboBox.Items.Add(phone.Name);
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
           int position = removeComboBox.SelectedIndex;
           im.removeIventory(im.inventoryManager[position]);
           im.displayInventoryManager();
           this.Close();
        }
    }
}

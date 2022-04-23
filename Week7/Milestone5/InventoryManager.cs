using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone4
{
    public class InventoryManager
    {
        //Array with Phone items
       public  List<Phone> inventoryManager;

        //Constructor which requires a phone to add to list
        public InventoryManager()
        {
            inventoryManager = new List<Phone>() {};
        }

        //*METHODS*
        //this method will add a phone to the inventory manager array
        public void addInventory(Phone phone)
        {
            inventoryManager.Add(phone);
        }
        //This method will remove the item in inventory manager 
        public void removeIventory(Phone phone)
        {
                    inventoryManager.Remove(phone);

        }
        //This method will add to the quantity property of the phone
        public void restockInventory(Phone phone, int numOfRestock)
        {
            //Adds number of items restocked to the phone quantity value
            phone.Quantity += numOfRestock;
        }
        //This method will display each phone in the InvetoryManager
        public void displayInventoryManager()
        {
            //loops through each phone in the array
            foreach (Phone phone in inventoryManager)
            {
                //I am printing only name property for simplicity
                MessageBox.Show((phone.Name));
               
            }
        }
        //This method will search the array & return Inventory Item based on criteria (brand and color)
        public Phone search(string brand, string color)
        {
            //Using sequential search algorithm
            bool found = false;
            int index = 0;
            int position = -1;
            //search the array
            while (!found && index < inventoryManager.Count)
            {
                if (inventoryManager[index].Brand == brand && inventoryManager[index].Color == color)
                {
                    found = true;
                    position = index;
                }
                index++;
            }
            return inventoryManager[position];
        }
        
    }
}

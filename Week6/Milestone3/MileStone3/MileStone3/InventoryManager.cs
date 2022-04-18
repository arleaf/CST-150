using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3
{
    //Phone is the inventory item
    class InventoryManager
    {
        //Inventory Manager Properties
        //Size of array
        int size;
        //Array with Phone items
        Phone[] inventoryManager;
        
        //Constructor which requires a phone to add to array
        public InventoryManager(Phone phone)
        {
            inventoryManager = new Phone[] { phone };
            this.size = 1;
        }

        //*METHODS*
        //this method will add a phone to the inventory manager array
        public void addInventory(Phone phone)
        {
            //adds to the size variable and creates new array with updated size
            this.size++;
            Phone[] newInventoryManager = new Phone[size];
            //loop through current to add to new array
            for (int count = 0; count < inventoryManager.Length; count++)
            {
                newInventoryManager[count] = inventoryManager[count];
            }
            //Once all current elements added, we can add new element to new array
            newInventoryManager[size-1] = phone;
            //changing inventoryManager to reference the new array with added item
            this.inventoryManager = newInventoryManager;
        }
        //This method will remove the item in inventory manager 
        public void removeIventory (Phone phone)
        {
            //decreases the size variable and creates new arraay with updated size
            size--;
            Phone[] newInventoryManager = new Phone[size];
            //new Index is the new index for new array.This is needed when we want to go to next item in current array
            //but not increase new array index
            int newIndex = 0;
            //loop through current array
            for (int count = 0; count < inventoryManager.Length; count++)
            {
                //Checks if the phone is phone. If found it continues to next loop and will not execute below
                if(inventoryManager[count] == phone)
                {
                    continue;

                }
                //If phone is not found it will not add it to the new array
                newInventoryManager[newIndex] = inventoryManager[count];
                newIndex++;
            }
            //Changinging reference to refer to the new array not including the value
            this.inventoryManager = newInventoryManager;

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
            foreach(Phone phone in inventoryManager)
            {
                //I am printing only name property for simplicity
                Console.WriteLine(phone.Name);
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
            while( !found && index < inventoryManager.Length)
            {
                if(inventoryManager[index].Brand == brand && inventoryManager[index].Color == color)
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

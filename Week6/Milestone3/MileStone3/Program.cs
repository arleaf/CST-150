
//Create Inventory Manager
namespace MileStone3
{
    class Program
    {
        static public void Main(String[] args)
        {
            //Create 3 phone objects
            Phone iphone11 = new Phone("iphone11","Purple","256 GB","apple","Tmoblie");
            Phone samsung = new Phone("samsungNote","Black", "128 GB", "Samsung", "AT&T");
            Phone stylo5 = new Phone("Stylo5","Gray", "64 GB", "LG", "MetroPCS");
            //Create Inventory Manager
            InventoryManager inventoryManager = new InventoryManager(iphone11);

            //*TESTING THE CLASS METHODS
            //Before Calling Add method
            Console.WriteLine("Before adding");
            inventoryManager.displayInventoryManager();
            //After Adding the objects to inventory
            Console.WriteLine("");
            Console.WriteLine("After adding");
            inventoryManager.addInventory(samsung);
            inventoryManager.addInventory(stylo5);
            inventoryManager.displayInventoryManager();
            //Removing An object
            Console.WriteLine("");
            Console.WriteLine("Before Removing:");
            inventoryManager.displayInventoryManager();
            inventoryManager.removeIventory(samsung);
            Console.WriteLine("");
            Console.WriteLine("After Removing");
            inventoryManager.displayInventoryManager();
            //Restocking a Phone item
            Console.WriteLine("");
            Console.WriteLine("Quantity Before Restock:" + iphone11.Quantity.ToString());
            inventoryManager.restockInventory(iphone11, 5);
            inventoryManager.restockInventory(iphone11, 10);
            Console.WriteLine("");
            Console.WriteLine("Quantity after restock:" + iphone11.Quantity.ToString());
            //Searching for a phone item
            Console.WriteLine("");
            Console.WriteLine("Searching for " + stylo5.Name);
            Console.WriteLine("Found: "+ inventoryManager.search(stylo5.Brand, stylo5.Color).Name);
        }
    }
}


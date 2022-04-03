using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    class Phone
    {
        //attributes of Phone
        string color;
        string storage;
        string brand;
        string carrier;

        //Constructor
        public Phone()
        {
            color = "";
            storage = "";
            brand = "";
            carrier = "" ;
        }

        // Get and Set Methods
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Storage
        {
            get { return storage; }
            set { storage = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Carrier
        {
            get { return carrier; }
            set { carrier = value; }
        }

        //Calculates total Price including shipping and taxes rounded by 2
        public double calculateTotalPrice(double basePrice = 589.89, double taxRate = 0.15, double shippingPrice = 15.00)
        {
            double taxPrice = basePrice * taxRate;
            return Math.Round(basePrice + taxPrice + shippingPrice, 2);
        }

        //Displays Phone Details
        public void displayPhoneDetails()
        {
            MessageBox.Show("Brand: "+ brand + " Storage: " + storage + " Color: " + color + " Carrier: " + carrier);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_Inventory
{
    class Shipper
    {
        int arrayCounter = 0;
        IShippable[] ShippingArray = new IShippable[10];
        public void Add(IShippable shipObject)
        {
            //Formality since it shouldnt exceed 10
            if (arrayCounter < 10)
            {
                ShippingArray[arrayCounter] = shipObject;
                arrayCounter++;
            }
            else return;
        }
        public decimal Compute()
        {
            decimal computed = 0;
            for (int i = 0; i < arrayCounter; i++)
            {
                computed += ShippingArray[i].ShipCost;
            }
            return computed;
        }
        public string ListItems()
        {
            //return ShippingArray[itemNumber].Product;
            int Bikes = 0;
            int Crackers = 0;
            int Gloves = 0;
            int Mowers = 0;
            //This feels messy, improvement?
            for (int i = 0; i < arrayCounter; i++)
            {
                string product = ShippingArray[i].Product;
                if (product == "Bicycle")
                    Bikes++;
                else if (product == "Lawn Mower")
                    Mowers++;
                else if (product == "Crackers")
                    Crackers++;
                else if (product == "Baseball Glove")
                    Gloves++;
            }
            return "Shipment manifest \n" +
                Bikes + " Bicycles\n" +
                Gloves + " Baseball Gloves\n" +
                Mowers + " Lawn Mowers\n" +
                Crackers + " Crackers\n";
        }
        public int GetArrayCounter()
        {
            return arrayCounter;
        }
    }
}

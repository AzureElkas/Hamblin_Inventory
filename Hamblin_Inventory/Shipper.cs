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
            string itemList = "Shipment manifest: \n";
            int Bikes = 0;
            int Crackers = 0;
            int Gloves = 0;
            int Mowers = 0;
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
            if (Bikes > 1)
                itemList += Bikes + " Bicycles \n";
            else if (Bikes == 1)
                itemList += Bikes + " Bicycle \n";
            if (Gloves > 1)
                itemList += Gloves + " Baseball Gloves \n";
            else if (Gloves == 1)
                itemList += Gloves + " Baseball Glove \n";
            if (Mowers > 1)
                itemList += Mowers + " Lawn Mowers \n";
            else if (Mowers == 1)
                itemList += Mowers + " Lawn Mower \n";
            if (Crackers > 0)
                itemList += Crackers + " Crackers \n";
            return itemList;
        }
        public int GetArrayCounter()
        {
            return arrayCounter;
        }
    }
}

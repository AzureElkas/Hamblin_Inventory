using System;

namespace Hamblin_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper Shipping = new Shipper();
            bool continueLoop = true;
            while (continueLoop)
            {
            Console.WriteLine("Please Choose From the Following Options:");
            Console.WriteLine("1. Add a Bicycle to the Shipment \n" +
                "2. Add a Lawn Mower to the Shipment \n" +
                "3. Add a Baseball Glove to the Shipment \n" +
                "4. Add Crackers to the Shipment \n" +
                "5. List Shipment Items \n" +
                "6. Compute Shipping Charges");
            string response = Console.ReadLine().ToString();
                //TODO If else chain can probably be improved, look into it
                if (response == "1")
                {
                    Console.Clear();
                    Bicycle newBike = new Bicycle();
                    Shipping.Add(newBike);
                }
                else if (response == "2")
                {
                    Console.Clear();
                    LawnMower newMower = new LawnMower();
                    Shipping.Add(newMower);
                }
                else if (response == "3")
                {
                    Console.Clear();
                    BaseballGlove newGlove = new BaseballGlove();
                    Shipping.Add(newGlove);
                }
                else if (response == "4")
                {
                    Console.Clear();
                    Crackers newCrackers = new Crackers();
                    Shipping.Add(newCrackers);
                }
                else if (response == "5")
                {
                    Console.Clear();
                    Console.WriteLine(Shipping.ListItems());
                }
                else if (response == "6")
                {
                    Console.Clear();
                    Console.WriteLine(Shipping.Compute());
                    continueLoop = false;
                }
            }
        } 
    }
}

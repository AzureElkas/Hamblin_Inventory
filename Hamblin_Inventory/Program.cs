using System;


/*Jace Hamblin
 *IT112
 *NOTES: The project works as far as I'm aware, but I feel there are some things that could be cleaned up better if i had more time
 *and didn't have other classes vying for my attention
 *BEHAVIORS NOT IMPLEMENTED AND WHY: None, to my knowledge
*/
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
                if (response == "1")
                {
                    Console.Clear();
                    Console.WriteLine("One Bicycle Added \n");
                    Bicycle newBike = new Bicycle();
                    Shipping.Add(newBike);
                }
                else if (response == "2")
                {
                    Console.Clear();
                    Console.WriteLine("One Lawn Mower Added \n");
                    LawnMower newMower = new LawnMower();
                    Shipping.Add(newMower);
                }
                else if (response == "3")
                {
                    Console.Clear();
                    Console.WriteLine("One Baseball Glove Added \n");
                    BaseballGlove newGlove = new BaseballGlove();
                    Shipping.Add(newGlove);
                }
                else if (response == "4")
                {
                    Console.Clear();
                    Console.WriteLine("One Box of Crackers Added \n");
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
                    Console.WriteLine("The cost to ship this order is " + Shipping.Compute().ToString("C2") + ", thank you for using this program \n" +
                        "Please press any key to terminate this program");
                    Console.ReadKey();
                    continueLoop = false;
                }
            }
        } 
    }
}

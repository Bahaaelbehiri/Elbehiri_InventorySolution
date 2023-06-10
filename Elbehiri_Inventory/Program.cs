//Bahaa Elbehiri
//IT112
namespace Elbehiri_Inventory
{
   class Program
    {
         static void Main(string[] args)
        {
            Shipper Shipper = new Shipper();
            Shipper.ShipCost = 0m;
            try
            {
                int num = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Choose from the following options:");
                    Console.WriteLine("1. Add a Bicycle to the shipment");
                    Console.WriteLine("2. Add a Lawn Mower to the Shipment");
                    Console.WriteLine("3. Add a Baseball Glove to the shipment");
                    Console.WriteLine("4. Add Crackers to the shipment");
                    Console.WriteLine("5. List Shipment Items");
                    Console.WriteLine("6. Compute Shipping Charges");

                    num = Convert.ToInt32(Console.ReadLine());
   
                    switch (num)
                    {
                        case 1:
                            Shipper.Add("Bicycles");
                            break;
                        case 2:
                            Shipper.Add("Lawn Mowers");
                            break;
                        case 3:
                            Shipper.Add("Baseball Gloves");
                            break;
                        case 4:
                            Shipper.Add("Crackers");
                            break;
                        case 5:
                             Console.WriteLine("Shipment manifest:");
                             Console.WriteLine(Shipper.CountBicycles + " Bicycles");
                             Console.WriteLine(Shipper.CountBaseball + " Baseball Glove");
                             Console.WriteLine(Shipper.CountLawnMowers + " Lawn Mowers");
                             Console.WriteLine(Shipper.CountCrackers + " Crackers");
                        break;

                        case 6:
                            Console.WriteLine("Total shipping cost for this order is " + Shipper.ShipCost);
                        break;
                    }
                    if (num >= 1 && num <= 4 )
                    {
                        if (Shipper.TotalCount != 10) {
                        Console.WriteLine("1 " + Shipper._ProdName + " has been added ");
                        Console.WriteLine("\nPress any key to return to the menu...");
                        
                        }
                        else
                        {
                            Console.WriteLine("\nthe shippable products will never exceed 10....");
                        }
                        Console.ReadKey();
                    }
                    else
                    { 
                        Console.WriteLine("\nPress any key to return to the menu ...");
                        Console.ReadKey();
                    }
                 } while (num != 7);
                
            }
            catch (System.FormatException)
            {
            }
        }
    }
}
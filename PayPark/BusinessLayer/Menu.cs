using PayPark.Models;
using System;

namespace PayPark.BusinessLayer
{
    public class Menu
    {
        public static void DisplayTextMenu() 
        {
            Console.Write("\n");
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Park a car");
            Console.WriteLine("2. View parked cars");
            Console.WriteLine("3. Unpark car");
            Console.WriteLine("4. View free parking lot");
            Console.WriteLine("5. Display all parked cars");
            Console.WriteLine("6. Exit");
            Console.Write("\n");
            Console.WriteLine("Enter your choice:");
        }
        
    }
}

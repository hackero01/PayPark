using PayPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPark.Messages
{
    public class CarMessages
    {
        public static void EnterNumberOfVehicle()
        {
            Console.Write("Please enter number plate of vehicle :  ");
        }
        public static void CarAlreadyExistMessage()
        {
            Console.Write("This car already exist");
        }
        public static void CarParkedMessage()
        {
            Console.Write("This car was parked.");
        }
        public static void CarDoesNotExistMessage()
        {
            Console.Write("This car not exist");
        }
        public static void DisplayParkedCars(int i, CarModel car)
        {
           
            Console.Write("SLOT " + (i) + ": " + car.plateNumber + "\n");
            
        }
        public static void WeDontHaveAnyFreeSpaces()
        {
            Console.Write("We dont have any free park spaces");
        }
    }
}

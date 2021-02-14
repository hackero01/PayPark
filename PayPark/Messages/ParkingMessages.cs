using PayPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPark.Messages
{
    public class ParkingMessages
    {
        public static void ParkingTimeInformation(CarModel car, TimeSpan parkTime)
        {


            Console.Write("------------------   Parking INFO   ------------------ \n");
            Console.Write("The vehicle with number plate: " + car.plateNumber + "\n");
            Console.Write("Parked at : " + car.enterTime + "\n");
            Console.Write("Exit at: " + car.exitTime + "\n");
            Console.Write("Time : " + parkTime.Minutes + " minutes \n");
            Console.Write("------------------------------------------------------ \n");
        }
        public static void TotalSumOfPay(CarModel car, int totalPrice)
        {
            Console.Write("The car with number plate : " + car.plateNumber + " must pay: " + totalPrice + " lei \n");
        }
        public static void TotalNumberOfFreeParkingLot(int freeSlot)
        {
            Console.Write("Total free parking slot: " + freeSlot + "\n");
            Console.Write("\n");
        }
        public static void DisplayFreeSpaceText(int i)
        {
            Console.Write("SLOT " + (i) + ": FREE SPACE \n");
        }
        public static void ParkEmpty()
        {
            Console.Write("Parking is empty");
        }
    }
}

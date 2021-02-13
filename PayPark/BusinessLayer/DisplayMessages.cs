using PayPark.Models;
using System;

namespace PayPark.BusinessLayer
{
    class DisplayMessages
    {
        public static void EnterNumberOfVehicle()
        {
            Console.Write("Please enter number plate of vehicle :  ");
        }
        public static void ParkingTimeInformation(CarModel car,TimeSpan parkTime)
        {


            Console.Write("------------------   Parking INFO   ------------------ \n");
            Console.Write("The vehicle with number plate: " + car.plateNumber + "\n");
            Console.Write("Parked at : " + car.enterTime + "\n");
            Console.Write("Exit at: " +car.exitTime + "\n");
            Console.Write("Time : " + parkTime.Minutes + " minutes \n");
            Console.Write("------------------------------------------------------ \n");
        }
        public static void TotalSumOfPay(CarModel car,int totalPrice)
        {
            Console.Write("The car with number plate : " + car.plateNumber + " must pay: " + totalPrice + " lei \n");
        }
        public static void TotalNumberOfFreeParkingLot(int freeSlot)
        {
            Console.Write("Total free parking slot: " + freeSlot + "\n");
            Console.Write("\n");
            Console.Write("List of vehicles who is in our parking: \n");

        }
        public static void DisplayFreeSpaceText(int i)
        {
            Console.Write("SLOT " + (i + 1) + ": FREE SPACE \n");
        }
        public static void DisplayParkedCars(int i,CarModel car)
        {
            Console.Write("SLOT " + (i + 1) + ": " + car.plateNumber + "\n");
        }
        public static void ParkEmpty()
        {
            Console.Write("Parking is empty");
        }
        public static void DisplayTextMenu()
        {
            Console.Write("\n");
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Add car");
            Console.WriteLine("2. View parked cars");
            Console.WriteLine("3. Delete a car from our parking");
            Console.WriteLine("4. View free parking lot");
            Console.WriteLine("5. Display all parked cars");
            Console.WriteLine("6. Exit");
            Console.Write("\n");
            Console.WriteLine("Enter your choice:");
        }
    }
}

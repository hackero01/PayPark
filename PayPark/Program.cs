using PayPark.BusinessLayer;
using PayPark.Classes;
using System;

namespace PayPark
{
    class Program
    {

        static void Main(string[] args)
        {
            IParkingServices _parkingServices = new ParkingServices();
            int choice = 0;
            _parkingServices.InitializeParkingSlot();
            do
            {
                DisplayMessages.DisplayTextMenu();
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        _parkingServices.AddCar();
                        break;
                    case 2:
                        _parkingServices.ViewParkedCar();
                        break;
                    case 3:
                        _parkingServices.OutCarFromParking();
                        break;
                    case 4:
                        _parkingServices.GetFreeParkingLot();
                        break;
                    case 5:
                        _parkingServices.DisplayParkedCars();
                        break;
                    default:
                        Console.Write("Input correct option\n");
                        break;
                }
            } while (choice != 0);
        }
     
    }
}


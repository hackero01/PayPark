using PayPark.BusinessLayer;
using PayPark.Classes;
using PayPark.Messages;
using System;

namespace PayPark
{
    public class Program
    {

        static void Main(string[] args)
        {

            IParkingServices _parkingServices = new ParkingServices();
            int choice = 0;
            do
            {
                Menu.DisplayTextMenu();
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CarMessages.EnterNumberOfVehicle();
                        string plateNumber = Console.ReadLine();
                        _parkingServices.AddCar(plateNumber);
                        break;
                    case 2:
                        _parkingServices.ViewParkedCar();
                        break;
                    case 3:
                        CarMessages.EnterNumberOfVehicle();
                        plateNumber = Console.ReadLine();
                        _parkingServices.UnParkCar(plateNumber);
                        break;
                    case 4:
                        _parkingServices.GetFreeParkingLot();
                        break;
                    case 5:
                        _parkingServices.DisplayParkedCars();
                        break;
                    default:
                        Console.Write("Application will be closed\n");
                        break;
                }
            } while (choice != 0);
        }

    }
}


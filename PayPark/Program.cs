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
            int choice;
            string userInput;
            while(true)
            {

                Menu.DisplayTextMenu();
                userInput = Console.ReadLine();
                bool validUserInput = int.TryParse(userInput, out choice);
                if (validUserInput)
                {
                  
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
                            Console.WriteLine("Enter a valid number between 1 and 5");
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number from list menu not a string");
                }
            } 
        }

    }
}


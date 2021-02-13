using PayPark.BusinessLayer;
using PayPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PayPark.Classes
{
    class ParkingServices:IParkingServices
    {

        private static List<ParkSlotModel> slots = new List<ParkSlotModel>();
        private static int noParkingSlotId = -1;
        private static int maxSlotPark = 10;

       
        public  void InitializeParkingSlot()
        {
            for (int i = 0; i < maxSlotPark; i++)
            {
                string initializedDate = "11/12/2020";
                DateTime standardDate = DateTime.Parse(initializedDate);
                slots.Add(new ParkSlotModel(false));
            }

        }
        public  void AddCar()
        {
            DisplayMessages.EnterNumberOfVehicle();
            string plateNumber = Console.ReadLine();

            if (GetFirstFreeParkSlot() == noParkingSlotId)
            {
                Console.Write("We dont have any free park spaces");
            }
            else
            {
                CarModel car = new CarModel(plateNumber);
                slots[GetFirstFreeParkSlot()] = new ParkSlotModel(true, car);

                



            }

        }
        public  void DisplayParkedCars()
        {
            int freeSlot = GetNumbersOfFreeSpaces();
            int parkedCar = 0;
            DisplayMessages.TotalNumberOfFreeParkingLot(freeSlot);
            
            for (int i = 0; i < slots.Count(); i++)
            {

                if (slots[i].isOcupied == true)
                {
                    
                    DisplayMessages.DisplayParkedCars(i, slots[i].car);
                    parkedCar++;
                }


            }
            if (parkedCar == 0)
            {
                DisplayMessages.ParkEmpty();
            }
        }
        public  void GetFreeParkingLot()
        {


            int freeSlot = GetNumbersOfFreeSpaces();
            DisplayMessages.TotalNumberOfFreeParkingLot(freeSlot);
            for (int i = 0; i < slots.Count(); i++)
            {

                if (slots[i].isOcupied == false)
                {
                    DisplayMessages.DisplayFreeSpaceText(i);
                }

            }
        }
        public  int GetNumbersOfFreeSpaces()
        {
            int freeSlot = 0;
            for (int i = 0; i < slots.Count(); i++)
            {
                if (!slots[i].isOcupied)
                {
                    freeSlot++;
                }
            } 
            return freeSlot;
        }
        public  void ViewParkedCar()
        {

            int freeSlot = GetNumbersOfFreeSpaces();

            DisplayMessages.TotalNumberOfFreeParkingLot(freeSlot);
            for (int i = 0; i < slots.Count(); i++)
            {

                if (slots[i].isOcupied == false)
                {
                    DisplayMessages.DisplayFreeSpaceText(i);
                }
                else
                {
                    DisplayMessages.DisplayParkedCars(i, slots[i].car);
                }
            }

        }
        public  void OutCarFromParking()
        {

            DisplayMessages.EnterNumberOfVehicle();
            string plateNumber = Console.ReadLine();
            TaxCalculator(plateNumber);
            int index = slots.FindIndex(a => a.car.plateNumber == plateNumber);
            slots[index].car.plateNumber = "";
            slots[index].isOcupied = false;
          




        }
        public  int TaxCalculator(string plateNumber)
        {
            int index = slots.FindIndex(a => a.car.plateNumber == plateNumber);
            var exitTime = DateTime.Now;
            var exitTtime = new DateTime(exitTime.Year, exitTime.Month, exitTime.Day, exitTime.Hour, exitTime.Minute, 0);
            int pretFinal = 10, extraPrice = 0, totalPrice = 0;
            TimeSpan totalParkTime = exitTtime - slots[index].car.enterTime;
            slots[index].car.exitTime = DateTime.Now;
            DisplayMessages.ParkingTimeInformation(slots[index].car, totalParkTime);
            if (totalParkTime.Minutes <= 1)
            {
                pretFinal = 10;
                extraPrice = 0;

            }
            else
            {
                extraPrice = 5 * (totalParkTime.Minutes - 1);
            }
            totalPrice = pretFinal + extraPrice;
            DisplayMessages.TotalSumOfPay(slots[index].car, totalPrice);
            return totalPrice;
        }
        private static int GetFirstFreeParkSlot()
        {
            for (int i = 0; i < slots.Count(); i++)
            {
                if (!slots[i].isOcupied)
                {
                    return i;
                }

            }
            return noParkingSlotId;
        }
    }
}

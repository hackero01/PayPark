using PayPark.BusinessLayer;
using PayPark.Messages;
using PayPark.Models;
using System;
using System.Collections.Generic;
using System.Configuration;


namespace PayPark.Classes
{
    public class ParkingServices : IParkingServices
    {
        static int parkingLots = Int32.Parse(ConfigurationManager.AppSettings["ParkingLots"]);

        private static List<ParkSlotModel> slots = CarSlotFactory.getSlots(parkingLots);

        int parkedCar = 0;
        public void AddCar(string plateNumber)
        {
            
            if (CheckIfCarExist(plateNumber))
            {
                CarMessages.CarAlreadyExistMessage();
            }
            else
            {
                foreach (ParkSlotModel slot in slots)
                {
                    if (!slot.isOccupied)
                    {
                       
                        slot.addCar(new CarModel(plateNumber));
                        CarMessages.CarParkedMessage();
                        parkedCar++;
                        return;
                    }
                }
                if (parkedCar == parkingLots)
                {
                    CarMessages.WeDontHaveAnyFreeSpaces();
                }
            }

        }
        public bool CheckIfCarExist(string plateNumber)
        {
            foreach (ParkSlotModel slot in slots)
            {
                if (slot.isOccupied)
                {
                    if (slot.car.plateNumber == plateNumber)
                        return true;

                }
            }
            return false;
        }

        public void DisplayParkedCars()
        {

            int parkedCar = 0;
            foreach (ParkSlotModel slot in slots)
            {
                if (slot.isOccupied)
                {
                    CarMessages.DisplayParkedCars(slot.slotId, slot.car);
                    parkedCar++;
                }
            }
            if (parkedCar == 0)
            {
                ParkingMessages.ParkEmpty();
            }
        }
        public void GetFreeParkingLot()
        {
             
            int numberOfOcupatedSlots = 0;
            int numberOfFreeSlots = 0;
            foreach (ParkSlotModel slot in slots)
            {
                if (slot.isOccupied == false)
                {
                    numberOfOcupatedSlots++;
                    ParkingMessages.DisplayFreeSpaceText(slot.slotId);
                }
                else
                {
                    numberOfFreeSlots++;
                }
            }
            ParkingMessages.TotalNumberOfFreeParkingLot(numberOfOcupatedSlots);

        }

        public void ViewParkedCar()
        {
            foreach (ParkSlotModel slot in slots)
            {
                if (!slot.isOccupied)
                {
                    ParkingMessages.DisplayFreeSpaceText(slot.slotId);
                }
                else
                {
                    CarMessages.DisplayParkedCars(slot.slotId, slot.car);
                }
            }
        }
        public void UnParkCar(string plateNumber)
        {           
            if (!CheckIfCarExist(plateNumber))
            {
                CarMessages.CarDoesNotExistMessage();
            }
            else
            {
                TollParkCalculator.TollCalculator(plateNumber, slots);
                int index = slots.FindIndex(a => a.car.plateNumber == plateNumber);
                slots[index].car = null;
                slots[index].isOccupied = false;
            }
        }
        
      

    }
}

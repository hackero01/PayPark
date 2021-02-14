using PayPark.Models;
using System;
using System.Collections.Generic;


namespace PayPark.BusinessLayer
{
    public class CarSlotFactory
    {
        private static List<ParkSlotModel> slots = new List<ParkSlotModel>();
        public static List<ParkSlotModel> getSlots(int numberOfSlots)
        {
            for (int i = 1; i <= numberOfSlots; i++)
            {
                slots.Add(new ParkSlotModel(i));
            }
            return slots;
        }
    }
}

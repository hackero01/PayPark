using PayPark.Messages;
using PayPark.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPark.BusinessLayer
{
    public class TollParkCalculator
    {
        static int priceForHour = Int32.Parse(ConfigurationManager.AppSettings["PriceForHour"]);
        static int extraPrice = Int32.Parse(ConfigurationManager.AppSettings["ExtraPrice"]);

        public static int TollCalculator(string plateNumber,List<ParkSlotModel> slots)
        {

            int index = slots.FindIndex(a => a.car.plateNumber == plateNumber);
            var exitTime = DateTime.Now;
            var exitTtime = new DateTime(exitTime.Year, exitTime.Month, exitTime.Day, exitTime.Hour, exitTime.Minute, 0);
            int totalPrice = 0;

            TimeSpan totalParkTime = exitTtime - slots[index].car.enterTime;
            slots[index].car.exitTime = DateTime.Now;
            ParkingMessages.ParkingTimeInformation(slots[index].car, totalParkTime);
            if (totalParkTime.Minutes <= 1)
            {
                totalPrice = priceForHour;
    
            }
            else
            {
                totalPrice = totalPrice + (extraPrice * (totalParkTime.Minutes - 1));
            }

            ParkingMessages.TotalSumOfPay(slots[index].car, totalPrice);
            return totalPrice;
        }
    }
}

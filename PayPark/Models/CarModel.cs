
using System;

namespace PayPark.Models
{
    class CarModel
    {

        public string plateNumber { get; set; }

        public DateTime enterTime { get; set; }

        public DateTime? exitTime = null;

        public CarModel(string plateNumber)
        {
            this.plateNumber = plateNumber;
            this.enterTime = DateTime.Now;
           
        }
        public CarModel(string plateNumber, DateTime enterTime, DateTime? exitTime)
        {
            this.plateNumber = plateNumber;
            this.enterTime = DateTime.Now;
            this.exitTime = exitTime;
        }
    }
}

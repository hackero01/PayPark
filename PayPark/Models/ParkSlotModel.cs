using System;


namespace PayPark.Models
{
    public class ParkSlotModel
    {
        
        public bool isOcupied { get; set; }
        public int slotId { get; set; }
        public CarModel car { get; set; }
        public int ocupiedPlaces { get; set; }

        public void addCar(CarModel car)
        {
            this.car = car;
            this.isOcupied = true;
            ocupiedPlaces++;
        }
       
        public ParkSlotModel(int slotId)
        {
            this.isOcupied = false;
            this.slotId = slotId;
        }
        
    }
}

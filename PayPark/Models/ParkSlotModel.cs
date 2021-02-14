using System;


namespace PayPark.Models
{
    public class ParkSlotModel
    {
        
        public bool isOccupied { get; set; }
        public int slotId { get; set; }
        public CarModel car { get; set; }
        public int ocupiedPlaces { get; set; }

        public void addCar(CarModel car)
        {
            this.car = car;
            this.isOccupied = true;
            ocupiedPlaces++;
        }
       
        public ParkSlotModel(int slotId)
        {
            this.isOccupied = false;
            this.slotId = slotId;
        }
        
    }
}

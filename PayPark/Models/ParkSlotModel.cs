using System;


namespace PayPark.Models
{
    class ParkSlotModel
    {
        
        public bool isOcupied { get; set; }
    
        public CarModel car { get; set; }
        public ParkSlotModel(bool isOcupied,CarModel car)
        {
            
            this.isOcupied = isOcupied;
            this.car = car;
            
        }
        public ParkSlotModel(bool isOcupied)
        {
            this.isOcupied = isOcupied;
        }
        
    }
}

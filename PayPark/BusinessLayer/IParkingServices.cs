using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPark.BusinessLayer
{
   public interface IParkingServices
    {
        public void AddCar();
        public void ViewParkedCar();
        public void OutCarFromParking();
        public void GetFreeParkingLot();
        public void DisplayParkedCars();
        public void InitializeParkingSlot();
    }
}

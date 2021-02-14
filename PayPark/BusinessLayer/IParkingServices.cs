using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPark.BusinessLayer
{
   public interface IParkingServices
    {
        public void AddCar(string plateNumber);
        public void ViewParkedCar();
        public void UnParkCar(string plateNumber);
        public void GetFreeParkingLot();
        public void DisplayParkedCars();
       
    }
}

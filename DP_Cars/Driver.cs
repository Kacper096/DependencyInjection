using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Cars
{
    public class Driver
    {
        private ICar _car = null;

        
        public Driver(ICar car)
        {
            _car = car ?? throw new ArgumentNullException(nameof(car));
        }
        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile",_car.GetType().Name,_car.Run());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Cars
{
    public class Bugatti : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }
}

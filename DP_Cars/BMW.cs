using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Cars
{
    public class BMW : ICar
    {
        private int _miles = 0;
        public int Run() => ++_miles;
       
    }
}

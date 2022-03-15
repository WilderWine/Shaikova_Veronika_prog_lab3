using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_2.Services
{
    public class ScaryFunc
    {
        public double TheScaryFunc(double x)
        {
            double y = Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(Math.Pow(x, 3)), 5) + Math.Log(Math.Pow(x, (2 / 5)));

            return y;
        }
    }
}

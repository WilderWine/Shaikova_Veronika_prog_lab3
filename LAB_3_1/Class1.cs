using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_3_1
{
    /*
     * variant 4
     * 
    Разработать метод f(x), который вычисляет значение по
следующей формуле:f(x)=cosx-sin2x. Определить, в какой из точек а или b,
функция принимает наименьшее значение.
    */
   public class MyFunk
    {
        public double FCos2SinSum(double x)
        {
            return Math.Cos(x) - Math.Sin(2 * x);
        }

        public double MinValue(double a, double b)
        {
            double c = (FCos2SinSum(a) < FCos2SinSum(b) ? a : b);
            return c;
        }

    }
}

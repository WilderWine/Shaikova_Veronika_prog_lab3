using NUnit.Framework;
using LAB_3_1;


namespace zTest1
{
    /*
     public double MinValue(double a, double b)
        {
            double c = (FCos2SinSum(a) < FCos2SinSum(b)) ? a : b;
            return c;
        }
     */
    public class Tests
    {
        
        [Test]
        public void MinValueFind()
        {
            MyFunk el = new MyFunk();
            double a = 12, b = 0.2;
            double expected = b;
            //Value of f(a) or f(b)!!!
            double actual = el.MinValue(a, b);


            Assert.AreEqual(expected, actual);
        }

        /*
         public double FCos2SinSum(double x)
        {
            return Math.Cos(x) - Math.Sin(2 * x);
        }
        */

        [Test]
        public void FuncValue()
        {
            MyFunk el = new MyFunk();
            double a = 0;

            double actual = el.FCos2SinSum(a);
            
            Assert.AreEqual(1, actual);
        }
    }
}
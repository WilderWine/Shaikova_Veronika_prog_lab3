using System;
namespace LAB_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyFunk el = new MyFunk();

            Console.WriteLine("Here we'll count \t f(x) = cos(x) - sin(2x) \t and find it's min value of given angles a and b" +
                "\n\nInput first value:");
         
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Now input second value:");

            double b = double.Parse(Console.ReadLine());

            double f1 = el.FCos2SinSum(a), f2 = el.FCos2SinSum(b);
            if (!(f1 == f2)) 
            {
                double minfval = (f1 < f2) ? a : b;
                double maxval = (f1 > f2) ? a : b;
                double minf = (f1 < f2) ? f1 : f2;
                double maxf = (f1 > f2) ? f1 : f2;
                Console.WriteLine($"f({minfval}) < f({maxval}) : \n\n" +
                    $"f({minfval}) = cos({minfval}) - sin(2*{minfval}) = {minf}\n" +
                    $"f({maxval}) = cos ({maxval}) - sin(2*{maxval}) = {maxf}\n\n\n");
            }
            else
            {
                Console.WriteLine($"f({a}) = f({b}) = {f1}");
            }

        }
    }
}

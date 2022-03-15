using System;


namespace LAB_3_2
{

    // variant 16
    class Program
    {
        static void Main(string[] args)
        {
            Services.ScaryFunc el = new Services.ScaryFunc();
            Console.WriteLine("Input value z that will be converted into x-parameter for our func:\n");
            double z = double.Parse(Console.ReadLine());
            double x;
            int branch;
            if (z >=0)
            {
                x = 2 * z + 1;
                branch = 1;
            }
            else if(z < 0)
            {
                x = Math.Log(z * z - z);
                branch = 2;
            }
            else
            {
                Console.WriteLine("Can not be proceeded");
                return;
            }

            string sbranch = "";
            switch(branch)
            {
                case 1:
                    {
                        sbranch = " 2z + 1 ";
                        break;
                    }
                 case 2:
                    {
                        sbranch = " ln(z*z - z) ";
                        break;
                    }
            }

            double y = el.TheScaryFunc(x);
            Console.WriteLine($"y = {y}\nBranch {branch} :\t{sbranch}");

            Console.ReadKey();
        }
    }
}

using System;

namespace LAB_3_3
{
    class Program
    {
        static void Main(string[] args)
        {

            DateService el = new DateService();

            int day;
            do
            {
                Console.WriteLine("Input day:\n");
                day = int.Parse(Console.ReadLine());
            } while (day < 1 || day > 31);
            int month;
            do
            {
                Console.WriteLine("Input Month:\n");
                month = int.Parse(Console.ReadLine());
            } while (month < 1 || month > 12);
            int year;
            do
            {
                Console.WriteLine("Input year:\n");
                year = int.Parse(Console.ReadLine());
            } while (year < 1 || year > 9999);

            string strday = (day < 10) ? ("0" + day.ToString()) : day.ToString();
            string strmonth = (month < 10) ? ("0" + month.ToString()) : month.ToString();
            string stryear;
            if (year < 10) stryear = "000" + year.ToString();
            else if (year < 100 && year > 9) stryear = "00" + year.ToString();
            else if (year > 99 && year < 1000) stryear = "0" + year.ToString();
            else stryear = year.ToString();

            string strdate = strday + "." + strmonth + "." + stryear;
            string dayofweek = el.GetDayOfWeek(strdate);
            int daysbetween = el.DaysFromCurrent(day, month, year);

            Console.WriteLine($"День недели {strdate} ─ {dayofweek}");
            Console.WriteLine($"Между {strdate} и сегодня ─ {daysbetween} дней.");

            Console.ReadKey();
        }
    }
}

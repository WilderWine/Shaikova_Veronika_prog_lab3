using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_3
{
    
    public class DateService
    {
        public string GetDayOfWeek(string date)
        {
            int day = int.Parse(date.Substring(0, 2));
            int month = int.Parse(date.Substring(3, 2));
            int year = int.Parse(date.Substring(6, 4));
            DateTime dateValue = new DateTime(year, month, day);
            string sday = dateValue.ToString("dddd");
            return sday;
        }

        public int DaysFromCurrent(int day, int month, int year)
        {
            
            int currday = DateTime.Now.DayOfYear;
            int curryear = DateTime.Now.Year;

            int td = 0;
            if (month == 1) { td = day; }
            else if (month == 2) { td = 31 + day; }
            else if (month == 3) { td = 59 + day; }
            else if (month == 4) { td = 90 + day; }
            else if (month == 5) { td = 120 + day; }
            else if (month == 6) { td = 151 + day; }
            else if (month == 7) { td = 181 + day; }
            else if (month == 8) { td = 212 + day; }
            else if (month == 9) { td = 243 + day; }
            else if (month == 10) { td = 273 + day; }
            else if (month == 11) { td = 304 + day; }
            else { td = 334 + day; }


            int allcurrdays = (curryear - 1) * 365 + (curryear - 1) / 4 + currday;
            int allthatdays = (year - 1) * 365 + (year - 1) / 4 + td;


            return Math.Abs(allcurrdays - allthatdays);
        }
    }
}

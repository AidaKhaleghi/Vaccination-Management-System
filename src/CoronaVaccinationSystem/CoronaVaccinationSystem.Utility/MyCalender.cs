using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CoronaVaccinationSystem.Utility
{
    public class MyCalender
    {

        public static int GetNumberOfDaysinSelectedMounth(int year, int mounth)
        {
            PersianCalendar p = new PersianCalendar();
            return p.GetDaysInMonth(year, mounth);
        }
        public static List<object> GetYearsForCbYears()
        {
            List<object> GetNumberOfYears = new List<object>();
            GetNumberOfYears.Add("سال");
            for (int i = 1300; i <= 1400; i++)
            {
                GetNumberOfYears.Add(i);
            }

            return GetNumberOfYears;
        }
        public static int GetMounthNumberBasedMonthName(string mounthName)
        {
            if (mounthName == "فروردین")
            {
                return 1;
            }
            else if (mounthName == "اردیبهشت")
            {
                return 2;
            }
            else if (mounthName == "خرداد")
            {
                return 3;
            }
            else if (mounthName == "تیر")
            {
                return 4;
            }
            else if (mounthName == "مرداد")
            {
                return 5;
            }
            else if (mounthName == "شهریور")
            {
                return 6;
            }
            else if (mounthName == "مهر")
            {
                return 7;
            }
            else if (mounthName == "آبان")
            {
                return 8;
            }
            else if (mounthName == "آذر")
            {
                return 9;
            }
            else if (mounthName == "دی")
            {
                return 10;
            }
            else if (mounthName == "بهمن")
            {
                return 11;
            }
            else if (mounthName == "اسفند")
            {
                return 12;
            }
            else
                return 0;
        }
        public static int GetTodayNumber()
        {
            PersianCalendar p = new PersianCalendar();
            DateTime d = DateTime.Now;
            return p.GetDayOfMonth(d);
        }
        public static int GetThisMonthNumber()
        {
            PersianCalendar p = new PersianCalendar();
            DateTime d = DateTime.Now;
            return p.GetMonth(d);
        }
        public static int GetThisYearNumber()
        {
            PersianCalendar p = new PersianCalendar();
            DateTime d = DateTime.Now;
            return p.GetYear(d);
        }
        public static int Get21DaysNextFromTodayDayNumber()
        {
            PersianCalendar p = new PersianCalendar();
            DateTime d = DateTime.Now;
            return p.GetDayOfMonth(d.AddDays(21));
        }
        public static int Get21DaysNextFromTodayMonthNumber()
        {
            PersianCalendar p = new PersianCalendar();
            DateTime d = DateTime.Now;
            return p.GetMonth(d.AddDays(21));
        }
        public static int Get21DaysNextFromTodayYearNumber()
        {
            PersianCalendar p = new PersianCalendar();
            DateTime d = DateTime.Now;
            return p.GetYear(d.AddDays(21));
        }
        public static string GetNameOfMonthBasedMonthNumber(int month)
        {
            if (month == 1)
            {
                return "فروردین";
            }
            else if (month == 2)
            {
                return "اردیبهشت";
            }
            else if (month == 3)
            {
                return "خرداد";
            }
            else if (month == 4)
            {
                return "تیر";
            }
            else if (month == 5)
            {
                return "مرداد";
            }
            else if (month == 6)
            {
                return "شهریور";
            }
            else if (month == 7)
            {
                return "مهر";
            }
            else if (month == 8)
            {
                return "آبان";
            }
            else if (month == 9)
            {
                return "آذر";
            }
            else if (month == 10)
            {
                return "دی";
            }
            else if (month == 11)
            {
                return "بهمن";
            }
            else
            {
                return "اسفند";
            }
        }
        public static bool CompareDates(string firstDate, string secondDate)
        {
            PersianCalendar p = new PersianCalendar();

            List<string> FirstDozeDate = firstDate.Split('/').ToList();
            DateTime FirstDozeDateTime = p.ToDateTime(int.Parse(FirstDozeDate[0]), int.Parse(FirstDozeDate[1]), int.Parse(FirstDozeDate[2]), 0, 0, 0, 0);

            List<string> SecondDozeDate = secondDate.Split('/').ToList();
            DateTime SecondDozeDateTime = p.ToDateTime(int.Parse(SecondDozeDate[0]), int.Parse(SecondDozeDate[1]), int.Parse(SecondDozeDate[2]), 0, 0, 0, 0);

            if (FirstDozeDateTime.AddDays(21) <= SecondDozeDateTime)
                return true;
            else
                return false;
        }


    }
}

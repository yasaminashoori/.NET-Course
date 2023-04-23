using System;

namespace calculate_date_time
{
    class Program
    {
        public int DaysBetweenDates(string dateNumberOne, string dateNumberTwo)
        {
            return Math.Abs(DaysFrom1971(dateNumberTwo) - DaysFrom1971(dateNumberOne));
        }

        private int DaysFrom1971(string date)
        {
            var year = Convert.ToInt32(date.Split('-')[0]);
            var month = Convert.ToInt32(date.Split('-')[1]);
            var days = Convert.ToInt32(date.Split('-')[2]);

            // dont count current month
            while (--month > 0)
            {
                if ((new int[] { 1, 3, 5, 7, 8, 10, 12 }).Contains(month))
                    days += 31;
                else if ((new int[] { 4, 6, 9, 11 }).Contains(month))
                    days += 30;
                else
                    days += IsLeap(year) ? 29 : 28;
            }

            // check if year prior isLeap, not current
            while (year > 1971)
            {
                days += IsLeap(--year) ? 366 : 365;
            }

            return days;
        }

        private bool IsLeap(int year)
        {
            return year % 400 == 0
                || (year % 4 == 0
                    && year % 100 != 0);
        }
    }
}

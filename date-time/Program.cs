using System;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = new DateTime(2020, 8, 1);
            DateTime end = new DateTime(2020, 8, 31);
            DateTime[] holidays = { new DateTime(2020, 8, 24) };
            int work_days = CountWorkingDays(start, end, holidays);
            Console.WriteLine(work_days);
        }

        public static int CountWorkingDays(DateTime start, DateTime end, DateTime[] holidays)
        {
            int counter = 0;
            bool searched;

            while (start != end)
            {
                if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday)
                {
                    searched = false;
                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (start == holidays[i])
                        {
                            searched = true;
                        }
                    }
                    if (searched != true)
                    {
                        counter++;
                    }
                }
                start = start.AddDays(1);
            }
            return counter;
        }
    }
}

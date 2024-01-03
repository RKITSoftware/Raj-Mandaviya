using System;

namespace DateTimeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get current time
            DateTime dateTime = DateTime.Now;
            DateTime dt = new DateTime(2023, 10, 31, 11, 50, 23);
            Console.WriteLine("dt: " + dt.ToString());

            Console.WriteLine(dateTime);

            //Individual Fields
            Console.Write(dateTime.Day + " ");
            Console.Write(dateTime.Month + " ");
            Console.Write(dateTime.Year + " ");
            Console.Write(dateTime.Hour + " ");
            Console.Write(dateTime.Minute + " ");
            Console.Write(dateTime.Second + "\n");

            // Custom DateTime Format
            Console.WriteLine(dateTime.ToString("yyyy/dd/MM"));

            //Arithmetic Operations on Datetime
            //Adds 24 Hours to Current Time
            DateTime futureDate = dateTime.AddHours(24);
            //Subtracts 30 Minutes to Current Time
            DateTime pastDate = dateTime.AddMinutes(-30);
            //Adds Days to Current Time
            DateTime dueDate = dateTime.AddDays(15);
            Console.WriteLine("Due Date: " + dueDate);

            //Get Last day of month
            Console.WriteLine("Days in a November 2023: " + DateTime.DaysInMonth(2023, 11));
            

            //Find leap year
            Console.WriteLine("Is 2024 a leap year? " + DateTime.IsLeapYear(2024));

            //TimeSpan represents a Time Interval
            TimeSpan difference = futureDate - pastDate;
            Console.WriteLine("Time Difference: " + difference);



        }
    }
}

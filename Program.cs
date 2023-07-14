using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment03_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert string to integer using TryParse
            string intStr = "30";
            int convertedInt;
            if (int.TryParse(intStr, out convertedInt))
            {
                int multipliedValue = convertedInt * 5;
                Console.WriteLine("Final value: " + multipliedValue);
            }
            else
            {
                Console.WriteLine("Error occured : Invalid integer format");
            }

            // Convert string to DateTime using Convert
            string dateTimeStr = "2023-05-29";
            try
            {
                DateTime convertedDateTime = Convert.ToDateTime(dateTimeStr);
                DateTime subtractedDateTime = convertedDateTime.AddMonths(-1);
                Console.WriteLine("Subtracted DateTime: " + subtractedDateTime);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error occured: Invalid DateTime format");
            }

            // Convert string to TimeSpan using Parse
            string timeSpanStr = "03:15:00";
            try
            {
                TimeSpan convertedTimeSpan = TimeSpan.Parse(timeSpanStr);
                TimeSpan addedTimeSpan = convertedTimeSpan.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine("Added TimeSpan: " + addedTimeSpan);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error occured: Invalid TimeSpan format");
            }
            Console.ReadKey();
        }
    }
}

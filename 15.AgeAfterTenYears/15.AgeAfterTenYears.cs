using System;
using System.Globalization;

namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.Write("Enter your birthday (dd-mm-yyyy): ");
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(),
                "d-M-yyyy", CultureInfo.CurrentCulture);
            TimeSpan diff = DateTime.Now - birthday;
            int yearsOld = GetYears(diff);
            Console.WriteLine("You are {0} years old. \nAfter ten years you will be {1} years old.", yearsOld, yearsOld + 10);

        }
        public static int GetYears(TimeSpan timespan)
        {
            return (int)((double)timespan.Days / 365.2425);
        }
    }
}
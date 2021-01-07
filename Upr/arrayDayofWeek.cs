using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] dayOfWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thurday",
                "Friday",
                "Saturday",
                "Sunday",

            };
            int dayNumber = int.Parse(Console.ReadLine());
            if(dayNumber>=1 && dayNumber<=7)
            {
                Console.WriteLine(dayOfWeek[dayNumber-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }           
            Console.ReadLine();
        }


    }
}

/*
 * Weekday or Weekend
 * Pawelski
 * 1/3/2022
 * Read the code and run the program a few times so you understand
 * what the program does and how it works. Once you understand what
 * the program does and how it works, modify the program so it
 * accomplishes the goal described on the activity sheet. Finally,
 * answer any questions on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekdayWeekend
{
    class Program
    {
        static void Main(string[] args)
        {
            string day;
            Console.Write("Enter a day of the week >> ");
            day = Console.ReadLine();
            if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine("It is the weekend!");
            }
            // Add your code here! 
        }
    }
}

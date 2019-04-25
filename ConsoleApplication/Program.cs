using System;

namespace ConsoleApplication
{
    class MainClass
    {
        /// <summary>
        /// Sample console program
        /// </summary>
        public static void Main(string[] args)
        {
            Console.Write("What is your full name? ");
            string fullName = Console.ReadLine();

            Console.Write("Where are you From? ");
            string location = Console.ReadLine();

            DateTime today = DateTime.Now;
            DateTime christmas = new DateTime(
                 today.Month == 12 && today.Day > 25 ?
                 today.Year + 1 :
                  today.Year, 12, 25);
            TimeSpan timeSpanToChristmas = christmas - today;

            Console.WriteLine($"My name is {fullName}");
            Console.WriteLine($"I am from {location}");
            Console.WriteLine($"Today is {today.ToShortDateString()}");
            Console.WriteLine($"There are {timeSpanToChristmas.Days} day(s) until Christmas! (Not including today)");

            // C# Programming Yellow Book - Rob Miles - “Cheese” Edition 8.2 November 2016
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Please enter a width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter a height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
                   woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                   glassArea + " square metres");

            Console.WriteLine("Program is completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}

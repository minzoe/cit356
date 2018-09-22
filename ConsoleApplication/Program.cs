using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string name, location;
            int daysTill;
            DateTime today, christmas;

            // Prompt for name and location
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter where your from: ");
            location = Console.ReadLine();

            // Print Name and Location
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am from " + location);

            // Print Today's Date
            today = DateTime.Today;
            Console.WriteLine(today.ToShortDateString());

            // Calc & Print Days till Christmas
            christmas = new DateTime(today.Year, 12, 25);
            daysTill = (christmas - today).Days;
            Console.WriteLine("Days till christmas " + daysTill);

            // Call Book Function
            GlazerCalc();

            // Exit
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        static void GlazerCalc()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length;
            double Width;
            double Height;
            bool Restart = true; // restarting the program with a do while loop

            do
            {
                Console.WriteLine("Please enter the length of the room (in decimal form):"); // user input to add the length
                Length = double.Parse(Console.ReadLine()); // converting all given input numbers to a double data type for decimals

                Console.WriteLine("Please enter the width of the room:"); // user input to add the width
                Width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of the room:"); // user input to add the height for volume. EXTRA!!
                Height = double.Parse(Console.ReadLine());

                double Area = Length * Width;
                double Perimeter = 2 * (Length + Width);
                double Volume = (Length * Width) * Height;

                Console.WriteLine($"The area of the room is {Area}, the perimeter of the room is {Perimeter}, and the volume of the room is {Volume}");
                // result of user inputs to give area, perimeter and volume of a room or space.

                Console.WriteLine("Do you want to continue? (True or False)");
                Restart = bool.Parse(Console.ReadLine()); // converting to bool to enable a true/false input

            } while (Restart == true); // do.. while loop to restart the program if user input is true. false closes the program.

        }
    }
}

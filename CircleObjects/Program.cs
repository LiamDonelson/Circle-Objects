using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace CircleObjects
{
    internal class Program
    {
        static void Main()
        {
            int i = 0;
            while (true)
            {
                i++;

                Console.WriteLine("Enter Radius:");
                double radius = 0;
                try
                {
                    radius = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You have not enters a valid answer. Please try again with only numbers");
                    i--;
                }

                Circle c = new Circle(radius);
                c.CalculateCircumference(radius);

                Console.WriteLine($"Circumfrence: {c.CalculateCircumference(radius)}");

                Console.WriteLine($"Area: {c.CalculateArea(radius)}");




                if (RunAgain() == false)
                {
                    Console.WriteLine("Number of circles made:" + i);
                    break;
                }

            }
        }

        static bool RunAgain()
        {
            

            Console.WriteLine("Would you like to enter another Radius? Y/N");
            string restart = Console.ReadLine().ToLower();
            if (restart == "y")
            {
                return true;
            }
            else if (restart == "n")
            {
                // ends the program
                Console.WriteLine(" Have a great day !");
                return false;
            }
            else
            {
                // runs the program again
                Console.WriteLine(" Im sorry, im not sure what that meant.");
                return RunAgain();
            }

        }
    }
}
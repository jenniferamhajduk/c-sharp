using System;

namespace Program
{
    class arithmetic_functions
    {
        public static void aoc()
        {
            Console.WriteLine("\n Please enter the Radius of the Circle:");
            double radius = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("The area of the circle is: {0}", (Math.Pow(radius, 2) * 3.141592654));
        }
        public static void ftc()
        {
            Console.WriteLine("\n Please enter the Feet Measurement:");
            double feet = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("The conversion to centimeters is: {0}", (feet * 30.48));
        }
        public static void nt()
        {
            Console.WriteLine("\n Please enter the Number:");
            double number = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("The nearest thousand is: {0}", (Math.Round(number/1000) * 1000));
        }
        public static void stm()
        {
            Console.WriteLine("\n Please enter the Second:");
            double second = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("The Conversion to Minutes is: {0}", (second / 60));
        }
    }

    class Test
    {
        public static void Main()
        {
            System.Console.WriteLine("What would you like to do: \n 1: Calculate Area of a Circle \n 2: Feet to Centimeters \n 3: Find the Nearest Thousand \n 4: Seconds to Minutes");
            int selection = Convert.ToInt32(System.Console.ReadLine());
            switch (selection)
            {
                case 1:
                    arithmetic_functions.aoc();
                    break;
                case 2:
                    arithmetic_functions.ftc();
                    break;
                case 3:
                    arithmetic_functions.nt();
                    break;
                case 4:
                    arithmetic_functions.stm();
                    break;
                default:
                    System.Console.Write("\n The entered selection " + selection + " was not a valid choice. Terminating...");
                    break;

            }
        }
    }

}

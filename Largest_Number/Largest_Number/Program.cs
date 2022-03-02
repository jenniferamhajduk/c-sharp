using System;

namespace Largest_Number
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[3];
            System.Console.WriteLine("Please enter positive numbers, each on a new line:");
            double largest_number = double.NegativeInfinity; 
            for (int i = 0; i < 3; i ++)
            {
                numbers[i] = Convert.ToInt32(System.Console.ReadLine());
                if (numbers[i] > largest_number)
                {
                    largest_number = numbers[i];
                }
            }
            System.Console.WriteLine("The largest number entered is: {0}", largest_number);
        }
    }
}

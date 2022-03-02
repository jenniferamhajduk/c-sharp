using System;

namespace Height_Category
{
    class HeightFunctions
    {
        public static string height_function(double h, out string hc)
        {
            if (h >= 66.0)
            {
                hc = "Tall";
            }
            else
            {
                hc = "Short";
            }
            return hc;
        }
    }
    class DetermineHeight
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a height in inches:");
            double height = Convert.ToDouble(System.Console.ReadLine());
            string hc = string.Empty;
            HeightFunctions.height_function(height, out hc);
            System.Console.WriteLine("The height you entered is categorized as: {0}", hc);
        }
    }
}

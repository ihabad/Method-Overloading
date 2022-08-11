using System;

namespace Method_Overloading
{
    internal class Program
    {
        public static int Add(int number1, int number2)
        {
            return (number1 + number2);

        }

        public static decimal Add(decimal number1, decimal number2)
        {
            return(number1 + number2);
        }

        public static string Add(int number1, int number2, bool isTrue)
        {
            var sum=0;
            var response = "";
            

            if (true)
            {
                sum = (number1 + number2);
            }
            if (sum ==1)
            {
                Console.WriteLine($"{sum} dollar");
            }
            else
            {
                Console.WriteLine($"{sum} dollar");
            }

            return response;
           
        }
        static void Main(string[] args)
        {
            Add(0, 1, true);
            Add(2, 3, true);
            Add(4, 12, true);
            Console.WriteLine();
        }
    }
}

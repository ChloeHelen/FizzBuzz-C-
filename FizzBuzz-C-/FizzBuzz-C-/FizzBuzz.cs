using System;

namespace FizzBuzz_C_
{
    public class FizzBuzz
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 16; i++)
            {
                DivisibleByThree(i);
                DivisibleByFive(i);
                DivisibleByFifteen(i);
            }
            
        }

        public static void DivisibleByThree(int num)
        {
            if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
         
        }

        public static void DivisibleByFive(int num)
        {
            if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }

        public static void DivisibleByFifteen(int num)
        {
            if (num % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
        }
    }
}

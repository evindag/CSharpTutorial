﻿using System;

namespace Project_PrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }
             static bool IsPrimeNumber(int number)
            {
                bool result = true;
                for (int i = 2; i < number-1; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        i = number;
                    }

                }
                return result;
            }
        }
    }
}

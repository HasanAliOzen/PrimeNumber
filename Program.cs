using System;

//  Define a PrimeNumber class. In this class:
// -The inputNumber function should provide a value to the number member variable from the
//  keyboard.
// -The isPrime function should return the information whether the number member variable is
//  prime or not.
// -closesetPrimeNumber function should return the largest prime number closest to the object
//  member


namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber primeObj = new PrimeNumber();
            primeObj.inputNumber();
            primeObj.isPrime();
        }
    }

    class PrimeNumber
    {
        private int number;
        private bool prime = true;

        public void inputNumber()
        {
            System.Console.Write("Enter a number : ");
            number = int.Parse(Console.ReadLine());
        }

        public void isPrime()
        {
            if (number < 2)
            {
                prime = false;
                System.Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                        System.Console.WriteLine("Not Prime");
                        break;
                    }
                }
                if (prime == true)
                    System.Console.WriteLine("Prime");
            }
        }

        // public void closesetPrimeNumber()
        // {
        //     if (prime)
        //         System.Console.WriteLine("The number is a Prime");
        //     else
        //     {
        //         for (int i = number++; ; i++) { }
        //     }
        // }
    }
}

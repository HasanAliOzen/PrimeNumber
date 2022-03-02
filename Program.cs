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
            Console.WriteLine("Hello World!");
        }
    }

    class PrimeNumber
    {
        private int number;

        public inputNumber()
        {
            System.Console.WriteLine("Enter a number : ");
            number = Int.parse(Console.ReadLine());
        }

        public isPrime() { }
    }
}

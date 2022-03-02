using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber primeObj = new PrimeNumber();
            primeObj.inputNumber();
            bool prime = primeObj.isPrime(primeObj.mNumber);
            if (prime == true)
                System.Console.WriteLine("Prime");
            else
            {
                System.Console.WriteLine("Not Prime");
                System.Console.WriteLine(
                    "Closest large prime number is :"
                        + primeObj.closesetPrimeNumber(primeObj.mNumber)
                );
            }
        }
    }

    //  Define a PrimeNumber class.
    class PrimeNumber
    {
        private int number;

        public int mNumber
        {
            get { return number; }
        }

        /* -The inputNumber function should provide a value 
        to the number member variable from the keyboard. */
        public void inputNumber()
        {
            System.Console.Write("Enter a number : ");
            number = int.Parse(Console.ReadLine());
        }

        /* -The isPrime function should return the information whether the number member variable is
        prime or not.*/
        public bool isPrime(int num)
        {
            // Numbers will think as they are prime
            bool primeStat = true;

            if (num < 2)
            {
                primeStat = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        primeStat = false;
                        break;
                    }
                }
            }
            return primeStat;
        }

        /* -closesetPrimeNumber function should return the largest prime number closest to the object
        member */

        public int closesetPrimeNumber(int inputNumber)
        {
            int largestPrime = inputNumber;
            while (!isPrime(largestPrime))
            {
                largestPrime++;
            }

            return largestPrime;
        }
    }
}

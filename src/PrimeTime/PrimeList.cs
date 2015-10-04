using System;
using System.Collections.Generic;

namespace PrimeTime
{
    public class PrimeList
    {
        private static readonly List<int> EmptyList = new List<int>(); 

        public static List<int> With(int numberOfElements)
        {
            if (numberOfElements == 0) return EmptyList;

            var primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < numberOfElements)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;

        }

        static bool IsPrimeNumber(int num)
        {
            bool bPrime = true;
            int factor = num / 2;

            int i = 0;

            for (i = 2; i <= factor; i++)
            {
                if ((num % i) == 0)
                    bPrime = false;
            }
            return bPrime;
        }
    }
}
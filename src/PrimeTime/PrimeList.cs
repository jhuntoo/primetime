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

            var primes = new List<int> {2};
            var nextPrime = 3;
            while (primes.Count < numberOfElements)
            {
                var sqrt = (int)Math.Sqrt(nextPrime);
                var isPrime = true;
                for (var i = 0; (int)primes[i] <= sqrt; i++)
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

    }
}
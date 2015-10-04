using System;

namespace PrimeTime
{
    public class PrimeTable
    {
        private readonly int _size;

        private PrimeTable(int size)
        {
            _size = size;
        }

        public static PrimeTable WithSizeOf(int size)
        {
            return new PrimeTable(size);
        }

        public int[,] ToGridArray()
        {
            if (_size == 0) return new int[0,0];
            if (_size == 1) return new int[,] { {1} };

            var gridArray = new int[_size, _size];

            gridArray[0, 0] = 1;

            var numberOfPrimes = _size - 1;
            var primes = PrimeList.With(numberOfPrimes);

            for (int primeNumberIndex = 0; primeNumberIndex < primes.Count; primeNumberIndex++)
            {
                var adjustedIndex = primeNumberIndex + 1;
                gridArray[0, adjustedIndex] = primes[primeNumberIndex];
                gridArray[adjustedIndex, 0] = primes[primeNumberIndex];
            }


            for (int rowIndex = 1; rowIndex <= numberOfPrimes; rowIndex++)
            {
                var rowPrimeValue = primes[rowIndex - 1];
                for (int columnIndex = 1; columnIndex <= numberOfPrimes; columnIndex++)
                {
                    var columnPrimeValue = primes[columnIndex - 1];
                    var productOfPrimes = rowPrimeValue*columnPrimeValue;
                    gridArray[rowIndex, columnIndex] = productOfPrimes;
                }
            }

            return gridArray;


        }
    }
}
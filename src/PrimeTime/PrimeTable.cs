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
            if (_size == 1) return new [,] { {1} };

            var gridArray = new int[_size, _size];
            gridArray[0, 0] = 1;
            var numberOfPrimes = _size - 1;
            var primes = PrimeList.With(numberOfPrimes);
            gridArray.SetAxisValues(primes);
            gridArray.CalculateAndSetProducts();
            return gridArray;
        }

        public void PrintToConsole()
        {
            var gridArray = ToGridArray();
            for (int rowIndex = 0; rowIndex < gridArray.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < gridArray.GetLength(1); columnIndex++)
                {
                    Console.Write(gridArray[rowIndex, columnIndex] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
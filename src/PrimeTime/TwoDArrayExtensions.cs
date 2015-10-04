using System.Collections.Generic;

namespace PrimeTime
{
    internal static class TwoDArrayExtensions
    {
        public static void SetAxisValues(this int[,] gridArray, List<int> values)
        {
            for (int primeNumberIndex = 0; primeNumberIndex < values.Count; primeNumberIndex++)
            {
                var adjustedIndex = primeNumberIndex + 1;
                gridArray[0, adjustedIndex] = values[primeNumberIndex];
                gridArray[adjustedIndex, 0] = values[primeNumberIndex];
            }
        }

        public static void CalculateAndSetProducts(this int[,] gridArray)
        {
            var numberOfPrimes = gridArray.NumberOfPrimes();
            for (var rowIndex = 1; rowIndex <= numberOfPrimes; rowIndex++)
            {
                for (var columnIndex = 1; columnIndex <= numberOfPrimes; columnIndex++)
                {
                    gridArray.SetProductValueAt(rowIndex, columnIndex);
                }
            }
        }

        private static void SetProductValueAt(this int[,] gridArray, int rowIndex, int columnIndex)
        {
            gridArray[rowIndex, columnIndex] = gridArray.PrimeValueOfRow(rowIndex) * gridArray.PrimeValueOfColumn(columnIndex);
        }

        private static int NumberOfPrimes(this int[,] gridArray)
        {
            return gridArray.GetLength(0) - 1;
        }

        private static int PrimeValueOfRow(this int[,] gridArray, int rowIndex)
        {
            return gridArray[rowIndex, 0];
        }

        private static int PrimeValueOfColumn(this int[,] gridArray, int columnIndex)
        {
            return gridArray[0, columnIndex];
        }

    }
}
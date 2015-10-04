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
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;

namespace PrimeTime
{
    public class PrimeList
    {
        private static readonly List<int> EmptyList = new List<int>(); 

        public static List<int> With(int numberOfElement)
        {
            if (numberOfElement == 0) return EmptyList;
            throw new NotImplementedException();
        }
    }
}
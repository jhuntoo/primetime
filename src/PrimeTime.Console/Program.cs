﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTime.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1) return;
            var size = int.Parse(args.First());
            var primeTable = PrimeTable.WithSizeOf(size);
            primeTable.PrintToConsole();

        }
    }
}

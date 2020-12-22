﻿using System;
using static System.Console;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Ch09_PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            Write("Press ENTER to start. ");
            ReadLine();
            watch.Start();
            IEnumerable<int> numbers = Enumerable.Range(1, 200000000);
            //var squares = numbers.Select(number => number * 2).ToArray();
            var squares = numbers.AsParallel()
              .Select(number => number * 2).ToArray();
            watch.Stop();
            WriteLine($"{watch.ElapsedMilliseconds:#,##0} elapsed milliseconds.");
        }
    }
}

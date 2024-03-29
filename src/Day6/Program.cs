﻿using System;

namespace Day6
{
    class Program
    {
        public static int day = 6;
        public static string inputPath = "../../../input/input";

        static void Main(string[] args)
        {
            Console.WriteLine("AOC 2021 Day " + day);
            Console.WriteLine("Solution Part 1:");
            Console.WriteLine(Solver.Solve(inputPath, 80));
            Console.WriteLine("Solution Part 2:");
            Console.WriteLine(Solver.Solve(inputPath, 256));
            Console.ReadLine();
        }
	}
}

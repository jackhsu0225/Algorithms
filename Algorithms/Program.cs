﻿using Algorithms.RecursionAndDynamicProgramming;
using Algorithms.SearchingAlgorithms;
using Algorithms.SearchingAlgorithms.Problems;
using Algorithms.SortingAlgorithms.Problems;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var alg = new MinCostClimbingStairs();
            var nums = new int[]
            { 1,2,3,4,5};
            var res = alg.Execute(nums);
            Console.WriteLine(res);
        }
    }
}

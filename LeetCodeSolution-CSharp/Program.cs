// See https://aka.ms/new-console-template for more information

using System;
using LeetCodeSolution_CSharp.Easy;

class Program
{
    static void Main()
    {
        var solutions = new Solutions();
        solutions.GetTwoSumSolution();
    }
}

class Solutions
{
    internal void GetTwoSumSolution()
    {
        var solver = new TwoSum();
        int[] result = solver.Main([2, 7, 11, 15], 9);
        Console.WriteLine($"Result: [{string.Join(", ", result)}]");
    }
}
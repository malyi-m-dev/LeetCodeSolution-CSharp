// See https://aka.ms/new-console-template for more information

using System;
using LeetCodeSolution_CSharp.Easy;

class Program
{
    static void Main()
    {
        var solutions = new Solutions();
        solutions.GetTwoSumSolution();
        solutions.GetPalindromeSolution();
    }
}

class Solutions
{
    internal void GetTwoSumSolution()
    {
        var solver = new TwoSum();
        int[] result = solver.Main([2, 7, 11, 15], 9);
        Console.WriteLine($"Result TwoSum: [{string.Join(", ", result)}]");
    }

    internal void GetPalindromeSolution()
    {
        var solver = new PalindromeNumber();
        var resultFirst = solver.IsPalindrome(121);
        var resultSecond = solver.IsPalindrome(-121);
        var resultThird = solver.IsPalindrome(10);
        Console.WriteLine($"Result: 1: {resultFirst} 2:{resultSecond} 3:{resultThird}");
        
    }
}
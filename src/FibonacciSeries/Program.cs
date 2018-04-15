using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new FibonacciSeriesBottomUpSolution();
            Console.WriteLine(solution.CalculateFibonacci(1000));
            Console.ReadLine();
        }
    }
}

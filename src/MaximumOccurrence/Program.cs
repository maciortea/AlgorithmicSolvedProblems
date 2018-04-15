using System;

namespace MaximumOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Pulkit is a dog!!!!!!!!!!!!        ! 12";
            var solution = new MaximumOccurrenceSolution();
            var occurence = solution.FindCharacterWithMaxOccurrence(str);
            Console.WriteLine("{0} {1}", occurence.Item1, occurence.Item2);
            Console.ReadLine();
        }
    }
}

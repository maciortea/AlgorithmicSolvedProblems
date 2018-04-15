using System;

namespace ReturnFirstRecurringCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new ReturnFirstRecurringCharacterSolution();

            // ABCA -> A
            Console.WriteLine(solution.GetFirstRecurringCharacter("ABCA"));

            // ABCBA -> B
            Console.WriteLine(solution.GetFirstRecurringCharacter("ABCBA"));

            // ABC -> null
            Console.WriteLine(solution.GetFirstRecurringCharacter("ABC"));

            Console.ReadLine();
        }
    }
}

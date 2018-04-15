using System;

namespace ReturnFirstNonRecurringCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new ReturnFirstNonRecurringCharacterSolution();

            // AABBC -> C
            Console.WriteLine(solution.GetFirstNonRecurringCharacter("AABBC"));

            // AAABBC -> C
            Console.WriteLine(solution.GetFirstNonRecurringCharacter("AAABBC"));

            // ABC -> A
            Console.WriteLine(solution.GetFirstNonRecurringCharacter("ABC"));

            // AABB -> null
            Console.WriteLine(solution.GetFirstNonRecurringCharacter("AABB"));

            Console.ReadLine();
        }
    }
}

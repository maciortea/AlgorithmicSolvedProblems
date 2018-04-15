using System;

namespace FindAllPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new FindAllPalindromesSolution();
            var palindromes = solution.GetAllPaliondromes("ababaa");
            foreach (var palindrome in palindromes)
            {
                Console.WriteLine(palindrome);
            }
            Console.ReadLine();
        }
    }
}

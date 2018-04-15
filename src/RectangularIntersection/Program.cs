using System;

namespace RectangularIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle1 = new Rectangle(1, 1, 1, 1);
            var rectangle2 = new Rectangle(2, 2, 3, 3);
            var solution = new RectangularIntersectionSolution();
            Rectangle intersectionRectangle = solution.GetIntersection(rectangle1, rectangle2);
            Console.ReadLine();
        }
    }
}

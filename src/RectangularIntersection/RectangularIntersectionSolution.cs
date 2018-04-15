using System;

namespace RectangularIntersection
{
    public class RectangularIntersectionSolution
    {
        public Rectangle GetIntersection(Rectangle r1, Rectangle r2)
        {
            var xSegment = GetOverlappingSegment(r1.LeftX, r1.Width, r2.LeftX, r2.Width);
            if (xSegment.Item1 == 0 && xSegment.Item2 == 0)
            {
                return new Rectangle(0, 0, 0, 0);
            }

            Tuple<int, int> ySegment = GetOverlappingSegment(r1.BottomY, r1.Height, r2.BottomY, r2.Height);
            if (ySegment.Item1 == 0 && ySegment.Item2 == 0)
            {
                return new Rectangle(0, 0, 0, 0);
            }

            return new Rectangle(xSegment.Item1, ySegment.Item1, xSegment.Item2 - xSegment.Item1, ySegment.Item2 - ySegment.Item1);
        }

        private Tuple<int, int> GetOverlappingSegment(int start1, int width1, int start2, int width2)
        {
            int newStart = Math.Max(start1, start2);
            int newEnd = Math.Min(start1 + width1, start2 + width2);
            if (newStart >= newEnd)
            {
                return Tuple.Create(0, 0);
            }
            return Tuple.Create(newStart, newEnd);
        }
    }
}

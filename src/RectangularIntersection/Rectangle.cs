namespace RectangularIntersection
{
    public class Rectangle
    {
        // Coordinates of bottom left corner
        public int LeftX { get; set; }
        public int BottomY { get; set; }

        // Dimensions
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }

        public Rectangle(int leftX, int bottomY, int width, int height)
        {
            LeftX = leftX;
            BottomY = bottomY;
            Width = width;
            Height = height;
        }
    }
}

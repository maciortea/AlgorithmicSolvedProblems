namespace HighestProductOfK
{
    public class Product
    {
        public int Highest { get; set; }
        public int Lowest { get; set; }

        public Product()
        {
        }

        public Product(int highest, int lowest)
        {
            Highest = highest;
            Lowest = lowest;
        }
    }
}

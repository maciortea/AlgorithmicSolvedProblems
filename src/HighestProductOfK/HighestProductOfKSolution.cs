using System;

namespace HighestProductOfK
{
    // Given an array of integers, find the highest product you can get from K of the integers.
    // Time complexity: O(n * k)
    // Space complexity: O(k)
    public class HighestProductOfKSolution
    {
        public int GetHighestProductOfK(int[] arr, int k)
        {
            if (arr.Length < k)
            {
                throw new ArgumentException($"Less than {k} items");
            }

            if (k < 2)
            {
                throw new ArgumentException("At least two items required");
            }

            Product[] products = new Product[k];

            products[0] = new Product
            {
                Highest = Math.Max(arr[0], arr[1]),
                Lowest = Math.Min(arr[0], arr[1])
            };

            for (int i = 1; i < k; i++)
            {
                int product = 1;
                for (int j = 0; j <= i; j++)
                {
                    product *= arr[j];
                }
                products[i] = new Product(product, product);
            }

            for (int i = k - 1; i < arr.Length; i++)
            {
                int current = arr[i];

                for (int j = k - 1; j >= 1; j--)
                {
                    products[j].Highest = Math.Max(Math.Max(
                        products[j].Highest,
                        current * products[j - 1].Highest),
                        current * products[j - 1].Lowest);


                    products[j].Lowest = Math.Min(Math.Min(
                        products[j].Lowest,
                        current * products[j - 1].Highest),
                        current * products[j - 1].Lowest);
                }

                products[0].Highest = Math.Max(products[0].Highest, current);
                products[0].Lowest = Math.Min(products[0].Lowest, current);
            }

            // Last product is the highest product of K items
            return products[k - 1].Highest;
        }
    }
}

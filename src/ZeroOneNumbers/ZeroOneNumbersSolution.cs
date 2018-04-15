using System.Collections.Generic;
using System.Linq;

namespace ZeroOneNumbers
{
    public class ZeroOneNumbersSolution
    {
        public IEnumerable<IEnumerable<int>> Combine(IEnumerable<int> source, int count)
        {
            int i = 0;
            foreach (var item in source)
            {
                if (count == 1)
                {
                    yield return new int[] { item };
                }
                else
                {
                    foreach (var result in Combine(source.Skip(i + 1).ToArray(), count - 1))
                    {
                        yield return new int[] { item }.Concat(result);
                    }
                }
                i++;
            }
        }
    }
}

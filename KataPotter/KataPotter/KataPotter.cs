using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo
{
    public static class KataPotter
    {
        public static int GetPricing(int[] books)
        {
            int result = 0;

            if (books == null)
                throw new ArgumentNullException();

            if (books.Any(b => b < 1 || b > 5))
                throw new ArgumentOutOfRangeException();
            else if (books.Distinct().Count() == 1)
                result = 8 * books.Length;

            return result;
        }
    }
}

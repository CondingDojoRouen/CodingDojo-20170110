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

            if (books.Any(b => b > 5))
                throw new ArgumentOutOfRangeException();
            else if (books.Count() == 1)
                result = 8;
            else if (books.Distinct().Count() == 1)
                result = 16;

            return result;
        }
    }
}

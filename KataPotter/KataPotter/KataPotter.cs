using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo
{
    public static class KataPotter
    {
        public static double GetPricing(int[] books)
        {
            double result = 0;

            if (books == null)
                throw new ArgumentNullException();

            if (books.Any(b => b < 1 || b > 5))
                throw new ArgumentOutOfRangeException();
            else if (books.Distinct().Count() == 1)
                result = 8 * books.Length;
            else
            {
                int numberOfDistinctBook = books.Length;
                result = 8 * numberOfDistinctBook * GetDiscount(numberOfDistinctBook);
            }
            return result;
        }



        private static double GetDiscount(int numberOfDistinctBook)
        {
            switch (numberOfDistinctBook)
            {
                case 2:
                    return 0.95;
                case 3:
                    return 0.90;
                case 4:
                    return 0.80;
                case 5:
                    return 0.75;
                default:
                    return 1;
            }
        }
    }
}

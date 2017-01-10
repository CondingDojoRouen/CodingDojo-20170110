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
            else if (books.Count() == 1)
                result = 8;
            return result;
        }
    }
}

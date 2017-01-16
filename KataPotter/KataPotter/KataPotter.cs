using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingDojo
{
    public static class KataPotter
    {
        public static double GetPricing(int[] books)
        {
            if (books == null)
                throw new ArgumentNullException();

            if (books.Any(b => b < 1 || b > 5))
                throw new ArgumentOutOfRangeException();

            //Construire la liste de liste
            var listOfDuplicates = new List<List<int>>();
            var listOfDuplicates2 = new List<List<int>>();

            foreach (var b in books)
            {
                List<int> currentList = listOfDuplicates.FirstOrDefault(arr => !arr.Contains(b));
                if(currentList == default(List<int>))
                {
                    listOfDuplicates.Add(new List<int> { b });
                }
                else
                {
                    currentList.Add(b);
                }

                List<int> currentList2 = listOfDuplicates2.OrderBy(arr => arr.Count())
                    .FirstOrDefault(arr => !arr.Contains(b));
                if (currentList2 == default(List<int>))
                {
                    listOfDuplicates2.Add(new List<int> { b });
                }
                else
                {
                    currentList2.Add(b);
                }
            }
            
            return Math.Min(Calc(listOfDuplicates), Calc(listOfDuplicates2));
        }

        private static double Calc(List<List<int>> listOfDuplicates)
        {
            double result = 0;
            //Pour chaque liste
            foreach (var list in listOfDuplicates)
            {
                var distinctBook = list.Distinct().Count();
                var discount = GetDiscount(distinctBook);
                //Nombre d'occurence de chacun des livres
                result += 8 * distinctBook * discount + (list.Count() - distinctBook) * 8;
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

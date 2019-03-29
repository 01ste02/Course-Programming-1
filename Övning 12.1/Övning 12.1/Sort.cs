using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_12._1
{
    class Sort
    {

        public Sort()
        {

        }

        public int[] SortInt (int[] toSort)
        {
            int i, n;
            int temp;

            for (n = 1; n < toSort.Length; n++)
            {
                temp = toSort[n];
                i = n - 1;

                while (i >= 0 && toSort[i] > temp)
                {
                    toSort[i + 1] = toSort[i];
                    i--;
                }

                toSort[i + 1] = temp;
            }

            return toSort;
        }
    }
}

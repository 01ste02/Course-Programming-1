using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_12._3
{
    class Search
    {

        public Search()
        {

        }

        public int SearchRegularInt (int[] toSearch, int toFind)
        {
            for (int i = 0; i < toSearch.Length; i++)
            {
                if (toSearch[i] == toFind)
                {
                    return i;
                }
            }
            return -1; //Should never get here
        }

        public int SearchBinInt (int[] toSearch, int toFind)
        {
            int min = 0;
            int mid;
            int max = toSearch.Length - 1;

            while (min <= max)
            {
                mid = (min + max) / 2;

                if (toSearch[mid] < toFind)
                {
                    min += 1;
                }
                else if (toSearch[mid] > toFind)
                {
                    max -= 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1; //Should never get here
        }
    }
}

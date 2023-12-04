using DataStructAndAlgorithm.Abstractions.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAndAlgorithm.Implementations.Search
{
    public class SearchList : ISearchList
    {
        public bool BinarySearch(int[] hayStack, int needle)
        {
            var low = 0;
            var high = hayStack.Length;


            do
            {
                var middle = (int)Math.Floor(low + (high - low) / 2m);
                var value = hayStack[middle];

                if (value == needle)
                {
                    return true;
                }
                else if (value > needle)
                {
                    high = middle;
                }
                else
                {
                    low = middle + 1;
                }

            } while (low < high);

            return false;
        }

        public bool LinearSearch(int[] hayStack, int needle)
        {
            for (int i = 0; i < hayStack.Length; i++)
            {
                if (hayStack[i] == needle)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

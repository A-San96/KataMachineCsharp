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
            throw new NotImplementedException();
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

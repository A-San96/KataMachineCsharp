using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAndAlgorithm.Abstractions.Search
{
    public interface ISearchList
    {
        bool LinearSearch(int[] hayStack, int needle);
        bool BinarySearch(int[] hayStack, int needle);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialSearch
{
    public class SequentialSearchExample
    {
        public static int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;  // Target found, return its index
                }
            }
            return -1;  // Target not found in the array
        }
    }
}

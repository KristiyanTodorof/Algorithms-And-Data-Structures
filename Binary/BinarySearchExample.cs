using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearchExample
    {
        public static int Binary(int[] array, int target)
        {
            int low = 0;
            int high =  array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                    

                if (target < array[mid])
                {
                    high = mid - 1;
                }

                else
                {
                    low = mid + 1;
                }
                    
            }
            return -1;
        }
    }
}

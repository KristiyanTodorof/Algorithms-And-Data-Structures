using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepSearch
{
    public class StepSearchExample
    {
        public static int Search(int[] array, int target)
        {
            int n = array.Length;

            // Finding the optimal step size (√n)
            int step = (int)Math.Floor(Math.Sqrt(n));

            // Finding the block where the target may be present
            int prev = 0;
            while (prev < n && array[Math.Min(prev, n - 1)] < target)
            {
                prev += step;
            }

            // Perform linear search in the identified block
            // Start from the previous step
            int start = prev - step;
            for (int i = start; i < Math.Min(prev, n); i++)
            {
                if (array[i] == target)
                {
                    return i;  // Target found, return its index
                }
            }

            return -1;  // Target not found
        }
    }
}

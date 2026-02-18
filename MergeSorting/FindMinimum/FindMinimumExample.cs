using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinimum
{
    public class FindMinimumExample
    {
        public static int FindMinimumNumber(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("Array cannot be empty.");

            // Initialize min with the first element
            int min = array[0];

            // Iterate through the array
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i]; // Update min if a smaller element is found
                }
            }

            return min; // Return the smallest element
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSortExample
    {
        public static void Bubble(int[] array)
        {
            int n = array.Length;

            // Outer loop for passes
            for (int i = 0; i < n - 1; i++)
            {
                // Flag to track if any swaps were made
                bool swapped = false;

                // Inner loop for comparing adjacent elements
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap if the current element is greater than the next element
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swapped = true; // Set flag to true if a swap occurred
                    }
                }

                // If no swaps were made, the array is already sorted
                if (!swapped)
                    break;
            }
        }
    }
}

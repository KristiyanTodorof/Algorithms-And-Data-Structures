using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSortExample
    {
        public static void Insertion(int[] array)
        {
            int n = array.Length;

            // Start from the second element (index 1)
            for (int i = 1; i < n; i++)
            {
                // Store the current element
                int key = array[i];
                int j = i - 1;

                // Shift elements in the sorted portion to the right
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                // Insert the current element into its correct position
                array[j + 1] = key;
            }
        }
    }
}
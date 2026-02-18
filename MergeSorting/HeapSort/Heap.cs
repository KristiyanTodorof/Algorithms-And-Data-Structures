using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    public class Heap
    {
        public static void HeapSortt(int[] array)
        {
            int n = array.Length;

            // Build a max heap
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);

            // Extract elements from the heap one by one
            for (int i = n - 1; i > 0; i--)
            {
                // Move the current root (largest) to the end
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // Call heapify on the reduced heap
                Heapify(array, i, 0);
            }
        }

        // Heapify a subtree rooted at index i
        private static void Heapify(int[] array, int n, int i)
        {
            int largest = i; // Initialize the largest as the root
            int left = 2 * i + 1; // Left child
            int right = 2 * i + 2; // Right child

            // If the left child is larger than the root
            if (left < n && array[left] > array[largest])
                largest = left;

            // If the right child is larger than the largest so far
            if (right < n && array[right] > array[largest])
                largest = right;

            // If the largest is not the root
            if (largest != i)
            {
                // Swap the root with the largest
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                // Recursively heapify the affected subtree
                Heapify(array, n, largest);
            }
        }
    }
}

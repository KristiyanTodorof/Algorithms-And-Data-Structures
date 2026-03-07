using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiftAlgorithm
{
    public class SiftAl
    {
        public static int SiftSearch(int[] arr, int target)
        {
            int n = arr.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));

            // Find the block where the element might exist
            int prev = 0;
            while (prev < n && arr[Math.Min(prev, n - 1)] < target)
            {
                prev += step;
            }

            // Linear search in the identified block
            prev = Math.Max(0, prev - step);
            for (int i = prev; i < Math.Min(prev + step, n); i++)
            {
                if (arr[i] == target)
                {
                    return i; // Found the target
                }
            }

            return -1; // Target not found
        }

        // Sift algorithm for heap maintenance (min-heap)
        public static void SiftDown(int[] heap, int index, int heapSize)
        {
            int smallest = index;
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;

            // Compare with left child
            if (leftChild < heapSize && heap[leftChild] < heap[smallest])
            {
                smallest = leftChild;
            }

            // Compare with right child
            if (rightChild < heapSize && heap[rightChild] < heap[smallest])
            {
                smallest = rightChild;
            }

            // If smallest is not the current index, swap and continue sifting
            if (smallest != index)
            {
                // Swap
                int temp = heap[index];
                heap[index] = heap[smallest];
                heap[smallest] = temp;

                // Recursively sift down the affected subtree
                SiftDown(heap, smallest, heapSize);
            }
        }

        // Heapify method to convert array to a min-heap
        public static void Heapify(int[] arr)
        {
            int n = arr.Length;

            // Start from the last non-leaf node and sift down
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                SiftDown(arr, i, n);
            }
        }

    }
}

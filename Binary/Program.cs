using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BinarySearch.BinarySearchExample;


            int[] sortedArray = { 3, 9, 10, 27, 38, 43, 82 };
            int target = 43;

            Console.WriteLine("Sorted Array: " + string.Join(", ", sortedArray));
            Console.WriteLine("Target Element: " + target);

            int result = Binary(sortedArray, target);

            if (result != -1)
            {
                Console.WriteLine($"Element found at index: {result}");
            }

            else
            {
                Console.WriteLine("Element not found in the array.");
            }

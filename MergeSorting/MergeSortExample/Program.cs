using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MergeSort.MergeSortExample;

namespace Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 38, 27, 43, 3, 9, 82, 10 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", array));

            Merge(array, 0, array.Length - 1);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}

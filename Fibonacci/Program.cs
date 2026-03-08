using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FibonacciSearch.FibonacciSearchExample;

namespace FibonacciSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            int target = 17;

            int result = Search(sortedArray, target);

            if (result != -1)
            {
                Console.WriteLine($"Element {target} found at index {result}");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array");
            }
        }
    }
}

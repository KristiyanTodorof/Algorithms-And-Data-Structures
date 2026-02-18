using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Program
    {
        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }

        static void BuildArray(int[] arr)
        {
            for (int i = 0; i <= 99999; i++)
            {
                arr[i] = i;
            }
        }
        static void DisplayNums(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args) 
        {
            int[] nums = new int[4000];
            BuildArray(nums);
            DateTime startTimeSimple = DateTime.Now;
            TimeSpan endTimeSimple;
            DisplayNums(nums);
            endTimeSimple = DateTime.Now.Subtract(startTimeSimple);
            Console.WriteLine($"Duration: {endTimeSimple}");
        }
    }
}

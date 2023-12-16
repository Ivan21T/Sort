using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    internal class Program
    {
        public static bool BinarySearch(int[] array,int element)
        {
            bool isContain = false;
            int left = 0;
            int right=array.Length-1;
            while (left < right)
            {
                int mid = (left+right)/2;
                if (array[mid] == element)
                {
                    isContain = true;
                    break;
                }
                else if (element > array[mid])
                {
                    left = mid + 1;
                }
                else if (element < array[mid])
                {
                    right= mid - 1;
                }
            }
            return isContain;
        }
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(BinarySearch(nums,3));
        }
    }
}

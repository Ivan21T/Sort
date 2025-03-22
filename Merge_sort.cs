using CSharpTest.Net.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Merge_sort
{
    internal class Program
    { 
        public static List<int> MergeSort(List<int> items)
        {
            if (items.Count==1)
            {
                return items;
            }
            int mid = items.Count / 2;
            var left=items.Take(mid).ToList();
            var right=items.Skip(mid).ToList();

            return Merge(MergeSort(left), MergeSort(right));
        }
        public static List<int> Merge(List<int> left,List<int> right)
        {
            int length=left.Count+right.Count;
            int leftPointer = 0;
            int rightPointer = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < length; i++)
            {
                if (leftPointer<left.Count && rightPointer<right.Count)
                {
                    if (left[leftPointer] < right[rightPointer])
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if (rightPointer<right.Count)
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(",",MergeSort(nums))); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quick_sort
{
    internal class Program
    {
        public static int[] QuickSort(int[] array, int start, int finish)
        {
            int lastNumber = finish;
            int i = start;
            int j = finish;
            int middleIndex = (i + j) / 2;
            int pivot = array[middleIndex];
            while (true)
            {
                if (i==j)
                {
                    i++;
                    j--;
                    break;
                }
                while (array[i]<=pivot && i<middleIndex)
                {
                    i++;
                }
                while (array[j]>=pivot && j>middleIndex)
                {
                    j--;
                }
                if (i==middleIndex && i<j)
                {
                    int temp = array[i];
                    array[i]=pivot= array[j];
                    array[j] = temp;
                    i = 0;
                    j = lastNumber;
                }
                else if (j == middleIndex && i < j)
                {
                    int temp = array[j];
                    array[j] =pivot= array[i];
                    array[i] = temp;
                    i = 0;
                    j = lastNumber;
                }
                else if (i!=middleIndex && j!=middleIndex && i<j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (start<j)
            {
                QuickSort(array, start, j);
                
            }
            if (finish>i)
            {
                QuickSort(array, i, finish);
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("{0}",string.Join(",",QuickSort(array, 0, array.Length - 1)));
        }
}   }

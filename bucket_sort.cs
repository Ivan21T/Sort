using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucket_sorting
{
    internal class Program
    {
        public static void AddInAppropriatePlace(int number,ref List<int>[] sortedNums)
        {
            if (number < 10)
            {
                sortedNums[0].Add(number);
            }
            else if (number>= 10 && number < 100)
            {
                sortedNums[1].Add(number);
            }
            else if (number >= 100 && number < 1000)
            {
                sortedNums[2].Add(number);
            }
            else if (number >= 1000 && number < 10000)
            {
                sortedNums[3].Add(number);
            }
            else if (number >= 10000 && number<100000)
            {
                sortedNums[4].Add(number);
            }
            else if (number>=100000 && number<1000000)
            {
                sortedNums[5].Add(number);
            }
            else if (number>=1000000 && number<10000000)
            {
                sortedNums[6].Add(number);
            }
            else if (number>=10000000 && number< 100000000)
            {
                sortedNums[7].Add(number);
            }
            else if (number>= 100000000 && number< int.MaxValue)
            {
                sortedNums[8].Add(number);
            }
        }
        static void Main(string[] args)
        {
            List<int> nums=Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int>[] sortedNums=new List<int>[9];
            for (int i = 0; i < 9; i++)
            {
                sortedNums[i] = new List<int>();
            }
            for (int i = 0;i < nums.Count; i++) 
            {
                AddInAppropriatePlace(nums[i], ref sortedNums);
            }
            for(int i = 0;i<sortedNums.Length;i++)
            {
                for (int j = 0; j < sortedNums[i].Count-1; j++)
                {
                    for (int p = j+1; p < sortedNums[i].Count; p++)
                    {
                        if (sortedNums[i][j] > sortedNums[i][p])
                        {
                            int temp = sortedNums[i][j];
                            sortedNums[i][j] = sortedNums[i][p];
                            sortedNums[i][p] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < sortedNums.Length; i++)
            {
                for (int j = 0; j < sortedNums[i].Count; j++)
                {
                    Console.WriteLine($"{sortedNums[i][j]}");
                }
            }
        }
    }
}

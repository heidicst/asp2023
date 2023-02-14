using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            // bubble sort
            int[] nums = { 12,34,11,8,28,7,35};
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-i-1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}

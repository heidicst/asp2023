using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 10, 20, 30, 50, 40, 33, 88,66 };

            Console.WriteLine("Original Array:");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted Array:");
             foreach (int num in nums)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}

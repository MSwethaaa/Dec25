using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25
{
    public class BSearchClass
    {
        public int BSearch(int[] arr, int target)
        {
            int low, high, mid;
            low = 0;
            high = arr.Length - 1;
            mid = (low = high) / 2;
            while (low <= high)
            {
                if (arr[mid] == target)
                { return mid + 1; }
                else if (target < arr[mid])
                { high = mid - 1; mid = (low + high) / 2; }
                else { low = mid + 1; mid = (low + high) / 2; }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            BSearchClass bs = new BSearchClass();
            int[] nums = { 33, 11, 99, 88, 77, 12, 56, 23, 89 };
            Console.WriteLine("actual array");
            foreach (int x in nums)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            //sort array
            Array.Sort(nums);
            //display
            Console.WriteLine("after sorting array");
            foreach (int x in nums) { Console.WriteLine(x); }
            Console.WriteLine();
            //read target
            Console.WriteLine("enter target");
            int n = int.Parse(Console.ReadLine());
            //call binary method
            int result = bs.BSearch(nums, n);
            if (result != -1)
            { Console.WriteLine("the value is {0} found at poistion {1}", n, result);}
            else
            {
                Console.WriteLine("not found");
            }
        }
    }
}


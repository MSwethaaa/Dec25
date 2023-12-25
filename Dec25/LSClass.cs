using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dec25
{
    public class LSClass
    {
        int LSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)//whole given array
            {
                if (target == arr[i]) return i + 1;
            }
            return -1;
        }
            static void Main(string[] args)
            {
                LSClass ls =new LSClass();  //create an array
                int[] nums = { 90, 45, 200, 50, 2, 33, 7 };
                int n, result;
                Console.WriteLine("what to search or target");
                //read target from user or assign to n
                n = Convert.ToInt32(Console.ReadLine());
                result =ls.LSearch(nums, n);//check what valve or -1
                if (result != -1) {Console.WriteLine("the target is found "+n+" postion is " + result);
            }
            else
                Console.WriteLine("the target not found");
                Console.ReadLine();
        }
    }
}

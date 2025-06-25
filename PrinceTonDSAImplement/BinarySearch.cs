using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinceTonDSAImplement
{
    public class BinarySearch
    {
        public static int BinarySearchAlgo(int[] a, int key)
        {
            int lo = 0, hi = a.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid])
                {
                    hi = mid - 1;
                }
                else if (key > a[mid])
                {
                    lo = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }


        public void ImplementationAlgo()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            int key = 9;
            int index = BinarySearch.BinarySearchAlgo(numbers, key);

            Console.WriteLine($"Index given the array and key which is {key} is at index {index}");
        }
    }

}

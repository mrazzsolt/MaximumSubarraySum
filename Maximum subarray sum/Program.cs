using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_subarray_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Console.ReadKey();
        }
        public static int MaxSequence(int[] arr)
        {
            int n = arr.Length;
            int local_max = 0;
            int global_max = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                local_max = Math.Max(arr[i], arr[i] + local_max);
                if (local_max > global_max)
                {
                    global_max = local_max;
                }
            }
            return global_max;
        }
    }
}

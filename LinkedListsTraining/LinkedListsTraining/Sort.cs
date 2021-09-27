using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = 0; j < arr.Length - (1 + i); j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void Selection(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int jMin = i; // stores the element of the smallest number

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[jMin]) // if number in j is smaller than number in the one at jMin
                    {
                        jMin = j; // jMin sets to j because it's smaller
                    }
                }

                if (jMin != i) // if jMin isn't i
                {
                    var temp = arr[i]; // put number in i into a temp variable
                    arr[i] = arr[jMin]; // swap number in i with number in jMin
                    arr[jMin] = temp;
                }
            }
        }

        public static void Insertion(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr;

            // Divide array in half
            decimal midpoint = arr.Length / 2;
            // Set a midpoint
            var mid = Convert.ToInt32(Math.Ceiling(midpoint));

            // Cut into 2 arrays
            var bot = arr.Take(mid).ToArray();
            var top = arr.Skip(mid).ToArray(); // Take and Skip require using Linq

            // Recursively keep splitting sub arrays into more sub arrays
            var bottomOut = MergeSort(bot);
            var topOut = MergeSort(top);

            var combined = Combine(bottomOut, topOut);

            return combined;
        }

        private static int[] Combine(int[] bottom, int[] top)
        {
            var i = 0; // Bottom
            var j = 0; // Top
            var k = 0;
            var arr = new int[bottom.Length + top.Length];

            while(i < bottom.Length && j < top.Length)
            {
                if(bottom[i] < top[j]) // Checks lower number
                {
                    arr[k] = bottom[i]; // If bottom is lower, store it in array spot k
                    i++;
                }
                else
                {
                    arr[k] = top[j]; // If top is lower, store it in array spot k
                    j++;
                }
                k++;
            }

            while(i < bottom.Length)
            {
                arr[k] = bottom[i];
                i++;
                k++;
            }

            while (j < top.Length)
            {
                arr[k] = top[j];
                j++;
                k++;
            }

            return arr;
        }
    }
}

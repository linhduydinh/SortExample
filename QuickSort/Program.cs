using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing array
            int[] arr = { 9, 4, 8, 3, 1, 2, 5 };
            Console.Write("Initial Array : ");
            Console.WriteLine(String.Join(" ", arr));
            quickSort(arr, 0, arr.Length - 1);
        }

        private static void quickSort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int pos = partition(arr, left, right);
                Console.WriteLine("pos = " + pos);
                quickSort(arr, left, pos - 1);
                quickSort(arr, pos + 1, right);
            }
        }

        private static int partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int small = left - 1;

            for (int k = left; k < right; k++)
            {
                if(arr[k] <= pivot)
                {
                    small++;
                    swap(arr, k, small);
                }
            }
            swap(arr, right, small + 1);
            Console.WriteLine("Pivot = " + arr[small + 1]);
            Console.WriteLine(String.Join(" ", arr));
            return small + 1;
        }
        private static void swap(int[] arr, int k, int small)
        {
            int temp;
            temp = arr[k];
            arr[k] = arr[small];
            arr[small] = temp;
        }
    }
}

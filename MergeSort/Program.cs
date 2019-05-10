using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        //    static void Main(string[] args)
        //    {
        //        int[] arr = { 14, 33, 27, 10, 35, 19, 42, 44 };
        //        Console.Write("Initial Array : ");
        //        Console.WriteLine(String.Join(" ", arr));

        //        MergeSort(arr, 0, arr.Length - 1);
        //    }

        //    private static void MergeSort(int[] arr, int leftStart, int rightEnd)
        //    {
        //        if(leftStart < rightEnd)
        //        {
        //            int middle = (leftStart + rightEnd) / 2;
        //            MergeSort(arr, leftStart, middle);
        //            MergeSort(arr, middle + 1, rightEnd);
        //            Merge(arr, leftStart, middle, rightEnd);
        //        }

        //    }

        //    private static void Merge(int[] arr, int left, int mid, int right)
        //    {
        //        int[] temp = new int[arr.Length];
        //        int k = left;
        //        int m = mid + 1;

        //        while (left <= mid && m <= right)
        //        {
        //            if(arr[left] <= arr[mid + 1])
        //            {
        //                temp[k++] = arr[left++];
        //            }
        //            else
        //            {
        //                temp[k++] = arr[m++];
        //            }
        //        }

        //        while(left <= mid)
        //        {
        //            temp[k++] = arr[left++];
        //        }

        //        while(m <= right)
        //        {
        //            temp[k++] = arr[m++];
        //        }

        //        for (int i1 = left; i1 <= right; i1++)
        //        {
        //            arr[i1] = temp[i1];
        //        }
        //    }
        //}
        static void Main(String[] args)
        {
            //Initializing array
            int[] arr = { 9, 4, 8, 3, 1, 2, 5 };
            Console.Write("Initial Array: ");
            printArray(arr, 0, arr.Length - 1);
            Console.WriteLine();
            mergesort(arr, 0, arr.Length - 1);
        }
        //Sorting in non decreasing order
        private static void mergesort(int[] arr, int i, int j)
        {
            // TODO Auto-generated method stub

            int mid = 0;

            if (i < j)
            {
                Console.WriteLine("i " + i);
                Console.WriteLine("j " + j);
                mid = (i + j) / 2;
                Console.WriteLine("mid=" + mid);
                mergesort(arr, i, mid);
                mergesort(arr, mid + 1, j);
                merge(arr, i, mid, j);
            }
        }

        private static void merge(int[] arr, int i, int mid, int j)
        {
            Console.Write("Left: ");
            printArray(arr, i, mid);
            Console.Write(" Right: ");
            printArray(arr, mid + 1, j);
            Console.WriteLine();
            int[] temp = new int[arr.Length];
            int l = i;
            int r = j;
            int m = mid + 1;
            int k = l;

            while (l <= mid && m <= r)
            {
                if (arr[l] <= arr[m])
                {
                    temp[k++] = arr[l++];
                }
                else
                {
                    temp[k++] = arr[m++];
                }
            }

            while (l <= mid)
            {
                Console.WriteLine("l=" + l);
                temp[k++] = arr[l++];
            }
            while (m <= r)
            {
                Console.WriteLine("m="+m);
                temp[k++] = arr[m++];
            }

            for (int t = i; t <= j; t++)
            {
                arr[t] = temp[t];
            }
            Console.WriteLine(String.Join(" ", temp));
            Console.Write("After Merge: ");
            printArray(arr, i, j);
            Console.WriteLine();
        }
        private static void printArray(int[] arr, int i, int j)
        {
            Console.Write("[");

            for (int k = i; k < j; k++)
            {
                Console.Write(arr[k] + ", ");
            }

            Console.Write(arr[j] + "]");
        }
    }
    }

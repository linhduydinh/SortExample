using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 14, 33, 27, 10, 35, 19, 42, 44 };
            Console.Write("Initial Array : ");
            Console.WriteLine(String.Join(" ", arr));

            for (int i = 0; i < arr.Length; i++)
            {
                // Chọn position là phần tử đầu tiên trong mảng
                int pos = i;
                // Chọn phần tử đầu tiên có value nhỏ nhất
                int small = arr[i];

                // Lặp phần tử từ i + 1 tới hết mảng
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // Nếu phần tử đứng sau nhỏ hơn phần tử đứng trước
                    // thì gán position cho phần tử đứng sau
                    if(small > arr[j])
                    {
                        pos = j;
                    }
                }

                // Gán biến tạm cho phần tử có value nhỏ nhất
                int temp = arr[pos];
                // Swap small và arr[pos]
                arr[pos] = arr[i];
                arr[i] = temp;

                Console.Write("After path " + i + "  : ");
                Console.WriteLine(String.Join(" ", arr));
            }

            Console.Write("Final Step: ");
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}

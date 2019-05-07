using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 14, 33, 27, 10, 35, 19, 42, 44 };
			Console.Write("Initial Array : ");
			Console.WriteLine(String.Join(" ", arr));

			for (int i = 1; i < arr.Length; i++)
			{
				int j = i - 1;
                // Gán value cho biến tạm
				int temp = arr[i];

                // Chạy vòng lặp cho tới khi j = 0 và biến tạm lớn hơn arr[j]
				while (j >= 0 && temp < arr[j])
				{
                    // Swap
					arr[j + 1] = arr[j];
					j--;
				}

				arr[j + 1] = temp;

				Console.Write("After path " + i + "  : ");
				Console.WriteLine(String.Join(" ", arr));
			}

			Console.Write("Final Step: ");
			Console.WriteLine(String.Join(" ", arr));
		}
	}
}

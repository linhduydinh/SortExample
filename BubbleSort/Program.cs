using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
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
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[i] > arr[j])
					{
						var temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
				Console.Write("After path " + i + "  : ");
				Console.WriteLine(String.Join(" ", arr));
			}
			Console.Write("Final Step: ");
			Console.WriteLine(String.Join(" ", arr));
		}
	}
}

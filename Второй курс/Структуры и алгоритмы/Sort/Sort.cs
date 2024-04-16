
using System.Diagnostics;

namespace Sort
{
	public static class Sort
	{
		public static void InsertSort(int[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				int x = array[i];
				int j = i;
				while(j != 0 && x < array[j - 1])
				{
					array[j] = array[j - 1];
					j--;
				}
				array[j] = x;
			}
		}

		public static void ShakerSort(int[] array)
		{
			int left = 0;
			int right = array.Length - 1;
			int k = right;
			do
			{
				for (int i = right; i > left; i--)
				{
					if (array[i] < array[i - 1])
					{
						(array[i - 1], array[i]) = (array[i], array[i - 1]);
						k = i;
					}
				}
				left = k;
				for (int i = left; i < right; i++)
				{
					if (array[i] > array[i+1])
					{
						(array[i+1], array[i]) = (array[i], array[i+1]);
						k = i;
						
					}
				}
				right = k;
			} 
			while(left < right);
		}

		public static void ShellSort(int[] array)
		{
			int step = array.Length / 2;
			while(step > 0)
			{
				for(int i = 0; i < array.Length - step; i++)
				{
					int j = i;
					while(j >= 0 && array[j] > array[j+step])
					{
						(array[j], array[j+step]) = (array[j+step], array[j]);
						j -= step;
					}
				}
				step /= 2;
			}
		}

		public static void PrintArray(int[] array)
		{
			foreach (int i in array)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();
		}

		public static void SetTimer(int[] ints, Action<int[]> action, string nameSort)
		{
			var sw = new Stopwatch();
			sw.Start();
			action(ints);
			sw.Stop();
			Console.WriteLine($"{nameSort}: {sw.Elapsed.TotalSeconds} seconds");
		}
	}
}

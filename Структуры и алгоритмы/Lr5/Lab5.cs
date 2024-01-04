

namespace Lr5
{
	public static class Lab5
	{
		public static void Variant5(int[,] ints)
		{
			var direction = new int[ints.GetLength(0), ints.GetLength(1)];
			var path = new int[ints.GetLength(0), ints.GetLength(1)];
			FillLastString(ints, direction);
			for(int i = direction.GetLength(0)-1; i >= 0 ; i--)
			{
				for(int j = 0; j < direction.GetLength(1); j++)
				{
					if (i - 1 >= 0 && j - 1 >= 0 && ints[i - 1, j - 1] + direction[i, j] > direction[i - 1, j - 1])
					{
						direction[i - 1, j - 1] = ints[i - 1, j - 1] + direction[i, j];
						path[i - 1, j - 1] = -1;
					}
					if (i - 1 >= 0 && j + 1 < direction.GetLength(1) && ints[i - 1, j + 1] + direction[i, j] > direction[i - 1, j + 1])
					{
						direction[i - 1, j + 1] = ints[i - 1, j + 1] + direction[i, j];
						path[i - 1, j + 1] = 1;
					}
					if (i - 2 >= 0 && ints[i - 2, j] + direction[i, j] > direction[i - 2, j])
					{
						direction[i - 2, j] = ints[i - 2, j] + direction[i, j];
						path[i - 2, j] = 0;
					}
				}
			}
			var maxPathAndIndex = MaxInFirstString(direction);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"Максимальная сумма чисел: {maxPathAndIndex[0]}");
			int n1 = 0, n2 = maxPathAndIndex[1]; // Начинаем снизу с финальной колонки
			path[n1,n2] = 100;
			var N1 = direction.GetLength(0);
			var N2 = direction.GetLength(1);
			while (n1 < direction.GetLength(0) - 1)
			{
				int down = (n1 > N1 - 2) ? direction[n1 + 2, n2] : int.MinValue;
				int left_down = (n2 > 0) ? direction[n1 + 1, n2 - 1] : int.MinValue;
				int right_down = (n2 < N2 - 1) ? direction[n1 + 1, n2 + 1] : int.MinValue;

				if (down > left_down && down > right_down)
				{
					n1 += 2;
				}
				else if (left_down > down && left_down > right_down)
				{
					n1++;
					n2--;
				}
				else if (right_down > down && right_down > left_down)
				{
					n1++;
					n2++;
				}
				else
				{
					n1 += 2;
				}
				path[n1, n2] = 100;
			}
			for (int i = 0; i < direction.GetLength(0); i++)
			{
				for (int j = 0; j < direction.GetLength(1); j++)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					if (path[i, j] == 100)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write($"{ints[i, j]} ");
						Console.ForegroundColor = ConsoleColor.Red;
					}
					else 
						Console.Write($"{ints[i, j]} ");
				}
                Console.WriteLine();
            }
			Console.ForegroundColor = ConsoleColor.White;
		}

		private static int[] MaxInFirstString(int[,] direction)
		{
			var max = int.MinValue;
			var index = 0;
			for ( var i = 0; i < direction.GetLength(1); i++ )
			{
				if (max < direction[0, i])
				{
					max = direction[0, i];
					index = i;
				}
			}
			return [max, index];
		}

		private static void FillLastString(int[,] ints, int[,] direction)
		{
			for (int i = direction.GetLength(0) - 1; i >= 0; i--)
			{
				for (int j = 0; j < direction.GetLength(1); j++)
				{
					if (i == direction.GetLength(0) - 1) direction[i, j] = ints[i, j];
					else direction[i, j] = int.MinValue;
				}
			}
		}
	}
}

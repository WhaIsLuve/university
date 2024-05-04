namespace Lr5
{
	public static class Lab5
	{
		public static void Variant5(int[,] ints)
		{
			var direction = new int[ints.GetLength(0), ints.GetLength(1)];
			var path = new int[ints.GetLength(0), ints.GetLength(1)];
			FillLastRow(ints, direction);
			for (int i = direction.GetLength(0) - 1; i >= 0; i--)
			{
				for (int j = 0; j < direction.GetLength(1); j++)
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
			var maxPathAndIndex = MaxInFirstRow(direction);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"Максимальная сумма чисел: {maxPathAndIndex[0]}");
			int n1 = 0, n2 = maxPathAndIndex[1];
			while(n1 <= direction.GetLength(0) - 1)
			{
				var p = path[n1, n2];
				path[n1, n2] = 100;
				if (p == 1)
				{
					n2--;
					n1++;
				}
				else if (p == -1)
				{
					n1++;
					n2++;
				}
				else if(p == 0)
				{
					n1 += 2;
				}
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

		private static int[] MaxInFirstRow(int[,] direction)
		{
			var max = int.MinValue;
			var index = 0;
			for (var i = 0; i < direction.GetLength(1); i++)
			{
				if (max < direction[0, i])
				{
					max = direction[0, i];
					index = i;
				}
			}
			return [max, index];
		}

		private static void FillLastRow(int[,] ints, int[,] direction)
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


namespace Lr5
{
	public static class Lab5
	{
		public static void Variant5(int[,] ints)
		{
			for (int i = 0; i < ints.GetLength(1); i++)
			{
				FindMaximimPath(i, ints);
			}
        }

		private static void FindMaximimPath(int beginIndex, int[,] ints)
		{
			for (int i = ints.GetLength(1) - 1; i >= 0; i--) 
			{
				Console.WriteLine(ints[i, beginIndex]);
            }
        }
	}
}

namespace Sort
{
	public static class Sort
	{
		public static void InclusionSort(int[] array)
		{
			for(int i = 1; i < array.Length; i++)
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
	}
}

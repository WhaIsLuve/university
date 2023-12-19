namespace Lr4
{
	public static class Lab4
	{
		public static void Variant1(int n1, int n2, string prefix)
		{
			if (n1 == 0 && n2 == 0) 
			{
                Console.WriteLine(prefix);
            }
			else
			{
				if (n1 > 0)
					Variant1(n1-1, n2, prefix + "(");
				if (n2 > 0 && n1 < n2)
					Variant1(n1, n2-1, prefix+")");
			}
		}

		public static void var1(int n)
		{
			string result = "";
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					result += "(";
				}
				result += ")";
			}
            Console.WriteLine(result);
        }
	}
}

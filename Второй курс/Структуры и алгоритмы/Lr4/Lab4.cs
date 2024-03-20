
namespace Lr4
{
	public static class Lab4
	{
		public static void var1(int n)
		{
			if (n % 2 == 1)
			{
				Console.WriteLine("С нечетной длиной невозможно построить правильную скобочную последовательность");
				return;
			}
			var binArr = new bool[n];
			var bracketsList = new List<string>();
			while (!IsOnlyOne(binArr))
			{
				var bracket = GenerateBracket(binArr);
				if(IsRightBracket(bracket))
					bracketsList.Add(bracket);
				BinArrInc(binArr);
			}
			if (n > 6)
				OutputInFile(bracketsList);
			else
				OutputInConsole(bracketsList);
		}

		private static void OutputInConsole(List<string> bracketsList)
		{
			foreach (var bracket in bracketsList)
				Console.WriteLine(bracket);
			Console.WriteLine($"Кол-во скобочек: {bracketsList.Count}");
		}

		private static void OutputInFile(List<string> bracketsList)
		{
			using (StreamWriter sw = File.CreateText(@"C:\Users\Влад\Desktop\Университет\Второй курс\Структуры и алгоритмы\lr4.txt"))
			{
				foreach(var bracket in bracketsList)
					sw.WriteLine(bracket);
				sw.WriteLine($"Кол-во скобочек: {bracketsList.Count}");
			}
		}

		public static bool IsRightBracket(string bracket) 
		{
			var count = 0;
			for (var i = 0; i < bracket.Length; i++)
			{
				if (bracket[i] == '(')
					count++;
				if (bracket[i] == ')')
					count--;
				if (count < 0)
					return false;
			}
			return count == 0;
		}

		private static string GenerateBracket(bool[] binArr)
		{
			var bracket = "";
			for (int i = 0; i < binArr.Length; i++)
			{
				if (binArr[i])
					bracket += ")";
				else
					bracket += "(";
			}
			return bracket;
		}

		private static void BinArrInc(bool[] binArr)
		{
			int i = binArr.Length - 1;
			while (binArr[i])
				binArr[i--] = false;
			binArr[i] = true;
		}


		private static bool IsOnlyOne(bool[] binArr)
		{
			return binArr.All(el => el == true);
		}
	}
}

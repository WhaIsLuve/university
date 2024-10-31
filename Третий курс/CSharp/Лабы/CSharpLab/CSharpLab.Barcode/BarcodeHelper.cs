using System.Text;

namespace CSharpLab.Barcode;

/// <summary>
/// Допишите функцию <see cref="GetCode"/> класса <see cref="BarcodeHelper"/> 
/// чтобы ее использовать при генерации строки штрихкода в вашем классе
/// </summary>
public static class BarcodeHelper
{
	#region Help

	/// <summary>
	/// <para>
	/// ████████████████████████████████████████████████████████████
	/// ██ ▌█▐█▌█▌▐▐█  █▐▌▌█▐ ██  ▌ ▌▌▌█  █ █▐▐█▌▌▐▌██▐ ▐  ▌▐█ ▐▐ ██
	/// ██ ▌█▐█▌█▌▐▐█  █▐▌▌█▐ ██  ▌ ▌▌▌█  █ █▐▐█▌▌▐▌██▐ ▐  ▌▐█ ▐▐ ██
	/// ██ ▌█▐█▌█▌▐▐█  █▐▌▌█▐ ██  ▌ ▌▌▌█  █ █▐▐█▌▌▐▌██▐ ▐  ▌▐█ ▐▐ ██
	/// ██ ▌█▐█▌█▌▐▐█  █▐▌▌█▐ ██  ▌ ▌▌▌█  █ █▐▐█▌▌▐▌██▐ ▐  ▌▐█ ▐▐ ██
	/// ████████████████████████████████████████████████████████████
	///                           Example
	/// </para>
	/// </summary>
	public static string GetCode(string text)
	{
		var patterns = new StringBuilder(Frame);
		var border = new StringBuilder();
		var barcodeString = new StringBuilder();
		var result = new StringBuilder();
		var numbers = new List<int>();
		var isEven = false;
		var currentIndex = 0;
		if (text.Count(d => char.IsDigit(d)) % 2 == 0 && text[0] != '0' || CheckSequency(text))
		{
			AddPatterns(patterns, numbers, StartNumbers);
			isEven = true;
		}
		else
		{
			AddPatterns(patterns, numbers, StartText);
		}
		while(currentIndex < text.Length)
		{
			Start(text, patterns, numbers, ref isEven, ref currentIndex);
		}
		AddPatterns(patterns, numbers, GetNumberControlPattern(numbers));
		AddPatterns(patterns, numbers, Stop);
		patterns.Append(Frame);

		

		var partsZeroAndOnes = SplitIntoParts(patterns.ToString(), 2);


		for (int i = 0; i < patterns.Length / 2; i++) border.Append(Bars[0]);

		result.Append(border.ToString() + "\n");

		foreach(var part in partsZeroAndOnes)
		{
			barcodeString.Append(GetGraphicalPattern(part));
		}

		for(int i = 0; i < Height; i++)
		{
			result.Append(barcodeString.ToString() + "\n");
		}

		result.Append(border.ToString() + "\n");


		return result.ToString();
	}

	private static bool CheckSequency(string text)
	{
		int count = 0;
		for(var i = 0; i < text.Length; i++)
		{
			if (count >= 6) return true;
			if (char.IsDigit(text[i]))
			{
				count++;
			}
			else
			{
				count = 0;
			}
		}
		return false;
	}

	private static void Start(string text, StringBuilder patterns, IList<int> numbers, ref bool isEven, ref int currentIndex)
	{
		if ((isEven && !IsDigit(text, currentIndex, 2)) ||
			   (!isEven && IsDigit(text, currentIndex, 4)))
		{
			isEven = !isEven;
			AddPatterns(patterns, numbers, isEven ? SwitchToNumbers : SwitchToText);
		}
		Next(ref currentIndex, numbers, isEven, text, patterns);
	}

	private static void Next(ref int currentIndex, IList<int> codes, bool isEven, string text, StringBuilder patterns)
	{
		if (isEven)
		{
			AddPatterns(patterns, codes, Array.IndexOf(NumberSymbols, text.Substring(currentIndex, 2)));
			currentIndex += 2;
		}
		else
		{
			AddPatterns(patterns, codes, Array.IndexOf(TextSymbols, text.Substring(currentIndex, 1)));
			currentIndex++;
		}
	}

	private static void AddPatterns(StringBuilder patterns, IList<int> numbers, int number)
	{
		patterns.Append(Patterns[number]);
		numbers.Add(number);
	}

	private static bool IsDigit(string text, int startIndex, int count)
	{
		var chars = text.Skip(startIndex).Take(count);
		return chars.Count() == count && chars.All(x => char.IsDigit(x));
	}

	private static int GetNumberControlPattern(IList<int> numbers)
	{
		var sum = numbers[0];

		for (var i = 1; i < numbers.Count; i++)
		{
			sum += i * numbers[i];
		}

		sum %= 103;

		return sum;
	}

	private static char GetGraphicalPattern(string pattern) => Bars[Convert.ToInt32(pattern, 2)];

	public static IEnumerable<string> SplitIntoParts(this string text, int b)
	{
		return Enumerable.Range(0, text.Length / b)
			.Select(i => text.Substring(i * b, b));
	}

	/// <summary>   
	/// Высота штрихкода (в строках)
	/// </summary>
	private const int Height = 4;

	/// <summary>
	/// Для получения рамки штрихкода по краям
	/// </summary>
	private const string Frame = "0000";

	/// <summary>
	/// Допустимые варианты штрихов
	/// </summary>
	public static readonly char[] Bars = { '█', '▌', '▐', ' ' };

	/// <summary>
	/// Начальный номер паттерна для текстовой строки
	/// </summary>
	private const int StartText = 104;

	/// <summary>
	/// Начальный номер паттерна для числовой строки
	/// </summary>
	private const int StartNumbers = 105;

	/// <summary>
	/// Переключить в числовой режим кодирования
	/// </summary>
	private const int SwitchToNumbers = 99;

	/// <summary>
	/// Переключить в текстовый режим кодирования
	/// </summary>
	private const int SwitchToText = 100;

	/// <summary>
	/// Номер паттерна завершения
	/// </summary>
	private const int Stop = 108;

	/// <summary>
	/// Доступные паттерны
	/// </summary>
	private static readonly string[] Patterns = [
		"11011001100", "11001101100", "11001100110", "10010011000", "10010001100",
		"10001001100", "10011001000", "10011000100", "10001100100", "11001001000",
		"11001000100", "11000100100", "10110011100", "10011011100", "10011001110",
		"10111001100", "10011101100", "10011100110", "11001110010", "11001011100",
		"11001001110", "11011100100", "11001110100", "11101101110", "11101001100",
		"11100101100", "11100100110", "11101100100", "11100110100", "11100110010",
		"11011011000", "11011000110", "11000110110", "10100011000", "10001011000",
		"10001000110", "10110001000", "10001101000", "10001100010", "11010001000",
		"11000101000", "11000100010", "10110111000", "10110001110", "10001101110",
		"10111011000", "10111000110", "10001110110", "11101110110", "11010001110",
		"11000101110", "11011101000", "11011100010", "11011101110", "11101011000",
		"11101000110", "11100010110", "11101101000", "11101100010", "11100011010",
		"11101111010", "11001000010", "11110001010", "10100110000", "10100001100",
		"10010110000", "10010000110", "10000101100", "10000100110", "10110010000",
		"10110000100", "10011010000", "10011000010", "10000110100", "10000110010",
		"11000010010", "11001010000", "11110111010", "11000010100", "10001111010",
		"10100111100", "10010111100", "10010011110", "10111100100", "10011110100",
		"10011110010", "11110100100", "11110010100", "11110010010", "11011011110",
		"11011110110", "11110110110", "10101111000", "10100011110", "10001011110",
		"10111101000", "10111100010", "11110101000", "11110100010", "10111011110",
		// 100+
		"10111101110", "11101011110", "11110101110", "11010000100", "11010010000",
		"11010011100", "11000111010", "11010111000", "1100011101011"];

	/// <summary>
	/// Разрешенные символы
	/// </summary>
	private static readonly string[] TextSymbols = {
		" ","!","\"","#","$","%","&","'","(",")",
		"*","+",",","-",".","/","0","1","2","3",
		"4","5","6","7","8","9",":",";","<","=",
		">","?","@","A","B","C","D","E","F","G",
		"H","I","J","K","L","M","N","O","P","Q",
		"R","S","T","U","V","W","X","Y","Z","[",
		"\\","]","^","_","`","a","b","c","d","e",
		"f","g","h","i","j","k","l","m","n","o",
		"p","q","r","s","t","u","v","w","x","y",
		"z","{","|","|","~"
	};
	/// <summary>
	/// Разрешенные пары числовых строк
	/// </summary>
	private static readonly string[] NumberSymbols = {
		"00","01","02","03","04","05","06","07","08","09",
		"10","11","12","13","14","15","16","17","18","19",
		"20","21","22","23","24","25","26","27","28","29",
		"30","31","32","33","34","35","36","37","38","39",
		"40","41","42","43","44","45","46","47","48","49",
		"50","51","52","53","54","55","56","57","58","59",
		"60","61","62","63","64","65","66","67","68","69",
		"70","71","72","73","74","75","76","77","78","79",
		"80","81","82","83","84","85","86","87","88","89",
		"90","91","92","93","94","95","96","97","98","99"
	};

	//  █▀▀▀▀▀█ ▀█▄█▄ █▀▀▀▀▀█
	//  █ ███ █ ▄▀ ▄  █ ███ █
	//  █ ▀▀▀ █ █▀▄▄▀ █ ▀▀▀ █
	//  ▀▀▀▀▀▀▀ █▄▀▄█ ▀▀▀▀▀▀▀
	//  █ ▄ ▀▄▀▀▀ ▄█▄▀▀▀▀█▄▄▀
	//  █▄█▀█ ▀▄▀█ ▀ ▄█▀█  ▀▄
	//  ▀  ▀  ▀▀█▀▀ ███▀▄ ▄▄█
	//  █▀▀▀▀▀█ ▀▄▄▄█▀ ▄▀  █▄
	//  █ ███ █ ▀  █▄ ▀▄▄█▄▄█
	//  █ ▀▀▀ █  █▄▀ ▄█ █▀   
	//  ▀▀▀▀▀▀▀ ▀ ▀ ▀▀▀▀ ▀  ▀

	#endregion
}


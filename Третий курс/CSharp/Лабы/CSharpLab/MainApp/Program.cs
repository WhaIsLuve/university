using CSharpLab.AirTransport;

namespace CSharpLab.MainApp;

internal class Program
{

	static void Main()
	{
		//while (true)
		//{
		//	Console.Write("Введите текст: ");
		//	var text = Console.ReadLine();
		//	var barcode = new Barcode.Barcode(text!);
		//	Console.WriteLine(barcode.ToString());
		//}
		var a = new Plane(1, 32, 120, "Boing");
		var b = new Plane(2, 3, 120, "Istrebitel");
		var c = new Plane(3, 320, 1200, "QQQ");
		var d = new Plane(4, 32, 150, "SSS");
		Showcase.Showcase s = 4;
		s.Push(a);
		s[1] = b;
		s[2] = c;
		s[3] = d;
		s.OrderByName();
		//Console.WriteLine(s);
		s.Id = 1;
		//Console.WriteLine(s);
		a.Id = 2;
		Console.WriteLine(s);
	}
}
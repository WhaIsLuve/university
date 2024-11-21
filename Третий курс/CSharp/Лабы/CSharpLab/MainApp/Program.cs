using CSharpLab.AirTransport;
using CSharpLab.Showcase;

namespace CSharpLab.MainApp;

internal class Program
{

	static void Main()
	{
		var data1 = new List<IAirTransport>()
		{
			new Plane(2012, 2000, 220, "Mrtger1"),
			new Plane(2013, 1234, 222, "MyCreyth2"),
			new Plane(2054, 432, 221, "s34gt46tCar3")
		};

		var data2 = new List<Superjet>()
		{
			new (1111,3000,400, "Myrthrthrtr", 999, 2),
			new (1212,1000,200,"TherthrshtherCar",1,1)
		};

		Showcase<IAirTransport> airTransports = 8;
		airTransports.Id = 1;
		Showcase<Superjet> superjets = 3;
		superjets.Id = 3;

		foreach (var airTransport in data1)
		{
			airTransports.Push(airTransport);
		}

		foreach (var Car in data2)
		{
			airTransports.Push(Car);
		}


		airTransports.OrderByName();

		var s1 = new Superjet(1, 1, 1, "rtgrethg", 2, 2);
		var s2 = new Plane(2, 2, 2, "rtherthrthв");

		superjets[0] = s1;
		airTransports[5] = superjets[0];
		airTransports[6] = s2;

		Console.WriteLine(airTransports);
		Console.WriteLine("_______________________________________________________");

		Console.WriteLine(superjets);
		Console.WriteLine("___");
		Console.WriteLine(superjets.Id);
		Console.WriteLine("_______________________________________________________");
		Console.WriteLine(new Plane(1, 1, 1, "q4th"));

		var superjet = new Superjet(4523, 12, 12, "wrgwerg", 1, 1);
		Console.WriteLine(superjet);

	}
}
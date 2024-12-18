using CSharpLab.AirTransport;
using CSharpLab.Showcase;

namespace CSharpLab.MainApp;

internal class Program
{
	static bool IsCorrectInput(int userChoice)
	{
		if (userChoice < 1 || userChoice > 3)
		{
			Console.WriteLine("Unknown command");
			userChoice = 1;
			return false;
		}
		if (userChoice == 3)
		{
			return true;
		}
		return true;
	}

	static void Main()
	{
		int userChoice = 0;
		List<Plane> planes = [];
		List<Superjet> superjets = [];
		List<IAirTransport> airTransports = [];
		Showcase<Plane> showcasePlane = null;
		Showcase<Superjet> showcaseSuperJet = null;
		Showcase<IAirTransport> showcase = null;
		List<IShowcase<IAirTransport>> baseShowcases = [];
		List<IShowcase<Plane>> showcasesPlane = [];
		List<IShowcase<Superjet>> showcasesSuperjet = [];
		var isNewCommand = true;
		while(true)
		{
			if(isNewCommand)
			{
				Console.WriteLine("Commands:\n1. Create AirTransport\n2. Work with showcase\n3. Show all created object\n4. End");
				userChoice = int.Parse(Console.ReadLine());
			}
			switch(userChoice)
			{
				case 1:
					Console.WriteLine("Choose air transport:\n1. Plane\n2. Superjet\n3. Back");
					userChoice = int.Parse(Console.ReadLine());
					isNewCommand = IsCorrectInput(userChoice);
					Console.Write("Input id: ");
					var id = int.Parse(Console.ReadLine());
					Console.Write("\nInput capacity: ");
					var capacity = int.Parse(Console.ReadLine());
					Console.Write("\nInput max capacity: ");
					var maxCapacity = int.Parse(Console.ReadLine());
					Console.Write("\nInput name: ");
					var name = Console.ReadLine();
					Console.WriteLine();
					isNewCommand = true;
					if (userChoice == 1)
					{
						var plane = new Plane(id, capacity, maxCapacity, name);
						planes.Add(plane);
						airTransports.Add(plane);
					}
					else if(userChoice == 2)
					{
						Console.Write("Input count of engines: ");
						var countOfEngines = int.Parse(Console.ReadLine());
						Console.Write("\nInput power: ");
						var power = double.Parse(Console.ReadLine());
						var jet = new Superjet(id, capacity, maxCapacity, name, countOfEngines, power);
						superjets.Add(jet);
						airTransports.Add(jet);
						Console.WriteLine();
					}
					break;
				case 3:
					Console.WriteLine("Choose output method:\n1. All\n2.Showcase\n3.Back");
					userChoice = int.Parse(Console.ReadLine());
					isNewCommand = IsCorrectInput(userChoice);
					if(userChoice == 1)
					{
						if(airTransports.Count == 0)
						{
							Console.WriteLine("Empty");
						}
						airTransports.ForEach(p => Console.WriteLine(p.ToString()));
					}
					else if(userChoice == 2)
					{
						Console.WriteLine(showcase?.ToString());
						Console.WriteLine(showcasePlane?.ToString());
						Console.WriteLine(showcaseSuperJet?.ToString());
					}
					break;
				case 2:
					Console.WriteLine("Choose commands:\n1.Create showcase\n2.Add Element in showcase\n3.Sort\n4.Pull out element by index");
					userChoice = int.Parse(Console.ReadLine());
					switch(userChoice)
					{
						case 1:
							Console.WriteLine("Choose type showcase:\n1. showcase base transport\n2. showcase plane\n3. showcase suprejet");
							var command = int.Parse(Console.ReadLine());
							Console.WriteLine("Input size showcase");
							var size = int.Parse(Console.ReadLine());
							if(command == 1)
							{
								showcase = size;
								baseShowcases.Add(showcase);
							}
							else if(command == 2)
							{
								showcasePlane = size;
								showcasesPlane.Add(showcasePlane);
							}
							else if(command == 3)
							{
								showcaseSuperJet = size;
								showcasesSuperjet.Add(showcaseSuperJet);
							}
							break;
						case 2:
							Console.WriteLine("Choose type showcase:\n1. showcase base transport\n2. showcase plane\n3. showcase suprejet");
							command = int.Parse(Console.ReadLine());
							Console.WriteLine("Input id transport");
							var transportId = int.Parse(Console.ReadLine());
							Console.WriteLine("Input id showcase");
							var showcaswId = int.Parse(Console.ReadLine());
							var t = airTransports.Find(t => t.Id == transportId);
							if (command == 1)
							{
								showcase?.Push(t);
								showcase.Id = showcaswId;
							}
							else if (command == 2)
							{
								var p = (Plane)t;
								showcasePlane?.Push(p);
								showcasePlane.Id = showcaswId;
							}
							else if (command == 3)
							{
								var j = (Superjet)t;
								showcaseSuperJet?.Push(j);
								showcaseSuperJet.Id = showcaswId;
							}
							break;
						case 3:
							Console.WriteLine("Choose order by:\n1.Id\n2.Name");
							var orderCommand = int.Parse(Console.ReadLine());
							Console.WriteLine("Choose type showcase:\n1. showcase base transport\n2. showcase plane\n3. showcase suprejet");
							command = int.Parse(Console.ReadLine());
							if (command == 1)
							{
								if(orderCommand == 1)
								{
									showcase?.OrderById();
								}
								else if(orderCommand == 2)
								{
									showcase?.OrderByName();
								}
							}
							else if (command == 2)
							{
								if (orderCommand == 1)
								{
									showcasePlane?.OrderById();
								}
								else if (orderCommand == 2)
								{
									showcaseSuperJet?.OrderByName();
								}
							}
							else if (command == 3)
							{
								if (orderCommand == 1)
								{
									showcaseSuperJet?.OrderById();
								}
								else if (orderCommand == 2)
								{
									showcaseSuperJet?.OrderByName();
								}
							}
							break;
						case 4:
							Console.WriteLine("Choose type showcase:\n1. showcase base transport\n2. showcase plane\n3. showcase suprejet");
							command = int.Parse(Console.ReadLine());
							Console.WriteLine("Input index");
							var index = int.Parse(Console.ReadLine());
							if (command == 1)
							{
								Console.WriteLine(showcase?[index].ToString());
							}
							else if (command == 2)
							{
								Console.WriteLine(showcasePlane?[index].ToString());
							}
							else if (command == 3)
							{
								Console.WriteLine(showcaseSuperJet?[index].ToString());
							}
							break;
					}
					break;
				case 4:
					Console.WriteLine("Goodbye");
					return;
			}
		}
	}
}
using System.IO;
using System.Text.Json;
using Infrastructure.Options;

namespace UI.Helpers;

public static class ConnectionStringGetter
{
	public static readonly ConnectionStrings ConnectionStrings;

	static ConnectionStringGetter()
	{
		var settings = JsonDocument.Parse(File.ReadAllText("appsettings.json"));
		ConnectionStrings = settings.RootElement.GetProperty("ConnectionStrings").Deserialize<ConnectionStrings>() 
							?? throw new InvalidOperationException("Необходимо вставить строку подключения для работы с приложением.");
	}
}

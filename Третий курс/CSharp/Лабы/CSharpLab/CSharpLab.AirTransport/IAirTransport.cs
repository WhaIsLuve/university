using CSharpLab.Barcode;

namespace CSharpLab.AirTransport;

public interface IAirTransport
{
	/// <summary>
	/// Возвращает идентификатор.
	/// </summary>
	int Id { get; set; }

	/// <summary>
	/// Возвращает штрихкод идентификатора.
	/// </summary>
	IBarcode Barcode { get; }

	/// <summary>
	/// Возвращает имя самолета.
	/// </summary>
	string Name { get; }

	event EventHandler<TransportEventArgs> ChangeId;
}

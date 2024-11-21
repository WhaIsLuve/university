using CSharpLab.Barcode;

namespace CSharpLab.AirTransport;

public interface IAirTransport
{
	/// <summary>
	/// Возвращает идентификатор.
	/// </summary>
	int Id { get; }

	/// <summary>
	/// Возвращает штрихкод идентификатора.
	/// </summary>
	IBarcode Barcode { get; }

	/// <summary>
	/// Возвращает имя самолета.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Возвращает тип воздушного транспорта.
	/// </summary>
	abstract string Type { get; }

	/// <summary>
	/// Возвращает производные данные.
	/// </summary>
	abstract string Description { get; }
}

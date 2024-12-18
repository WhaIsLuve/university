using CSharpLab.Barcode;

namespace CSharpLab.AirTransport;

public sealed class Superjet : Plane, IAirTransport
{
	/// <summary>
	/// Возвращает мощность суперджета.
	/// </summary>
	public double Power { get; set; }

	private static IBarcode barcode => new Barcode.Barcode("1");

	/// <inheritdoc />
	IBarcode IAirTransport.Barcode => barcode;

	/// <summary>
	/// Возвращает кол-во двигателей.
	/// </summary>
	public int CountOfEngines { get; set; }

	/// <inheritdoc />
	public override string Type => "Суперджет";

	/// <inheritdoc />
	public override string Description => $"Мощность: {Power}\nКол-во двигателей: {CountOfEngines}";

	/// <summary>
	/// Создает экземпляр класса <see cref="Superjet" />.
	/// </summary>
	/// <param name="id">Идентификатор самолета.</param>
	/// <param name="capacity">Текущая вместимость самолета.</param>
	/// <param name="maxCapacity">Максимальная вместимость самолета.</param>
	/// <param name="name">Имя воздушного транспорта.</param>
	/// <param name="countOfEngines">Кол-во двигетелей.</param>
	/// <param name="power">Мощность суперджета.</param>
	public Superjet(int id, int capacity, int maxCapacity, string name, int countOfEngines, double power) : base(id, capacity, maxCapacity, name)
	{
		CountOfEngines = countOfEngines;
		Power = power;
		_barcode = new BarcodeRecord(Id.ToString());
	}
}

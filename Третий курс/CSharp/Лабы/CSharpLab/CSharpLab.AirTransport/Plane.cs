
namespace CSharpLab.AirTransport;

/// <summary>
/// Представляет самолет.
/// </summary>
public class Plane : AirTranportBase
{
	/// <summary>
	/// Возвращает текущую вместимость самолета.
	/// </summary>
	public int Capacity { get; set; }
	
	/// <summary>
	/// Возвращает максимальную вместимость самолета.
	/// </summary>
	public int MaxCapacity { get; set; }

	public override string Type => "Самолет";

	public override string Description => $"Вместимость: {Capacity}\nМаксимальная вместимость: {MaxCapacity}";

	/// <summary>
	/// Создает экземпляр класса <see cref="Plane" />.
	/// </summary>
	/// <param name="id">Идентификатор самолета.</param>
	/// <param name="capacity">Текущая вместимость самолета.</param>
	/// <param name="maxCapacity">Максимальная вместимость самолета.</param>
	/// <param name="name">Имя воздушного транспорта.</param>
	public Plane(int id, int capacity, int maxCapacity, string name) : base(id, name)
	{
		Capacity = capacity;
		MaxCapacity = maxCapacity;
	}
}
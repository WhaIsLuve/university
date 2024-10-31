namespace CSharpLab.AirTransport;

/// <summary>
/// Представляет базовый воздушный транспорт.
/// </summary>
public abstract class AirTranportBase
{
	/// <summary>
	/// Возвращает идентификатор.
	/// </summary>
	public int Id 
	{ 
		get => _id; 
		set 
		{
			if(_id != value)
			{
				_id = value;
				Barcode.Text = value.ToString();
			}
		} 
	}

	/// <summary>
	/// Возвращает штрихкод идентификатора.
	/// </summary>
	public Barcode.Barcode Barcode { get; }

	/// <summary>
	/// Возвращает имя самолета.
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// Возвращает тип воздушного транспорта.
	/// </summary>
	public abstract string Type { get; }

	/// <summary>
	/// Возвращает производные данные.
	/// </summary>
	public abstract string Description { get; }

	private int _id;

	protected AirTranportBase(int id, string name)
	{
		_id = id;
		Name = name;
		Barcode = new Barcode.Barcode(id.ToString());
	}

	public override string ToString()
	{
		return $"{Type}: {Name}\nId:{Id}\n{Description}\n{Barcode}";
	}
}

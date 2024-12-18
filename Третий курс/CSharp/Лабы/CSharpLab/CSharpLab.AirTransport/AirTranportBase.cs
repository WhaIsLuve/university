using CSharpLab.Barcode;

namespace CSharpLab.AirTransport;

/// <summary>
/// Представляет базовый воздушный транспорт.
/// </summary>
public abstract class AirTranportBase : IAirTransport
{
	protected IBarcode _barcode;

	/// <inheritdoc />
	public int Id 
	{ 
		get => _id; 
		set 
		{
			if(_id != value)
			{
				var lastId = _id;
				_id = value;
				Barcode.Text = value.ToString();
				ChangeId?.Invoke(this, new TransportEventArgs(lastId, _id));
			}
		} 
	}

	/// <inheritdoc />
	public IBarcode Barcode => _barcode;

	/// <inheritdoc />
	public string Name { get; set; }

	/// <inheritdoc />
	public abstract string Type { get; }

	/// <inheritdoc />
	public abstract string Description { get; }

	public event EventHandler<TransportEventArgs> ChangeId;

	private int _id;

	protected AirTranportBase(int id, string name)
	{
		_id = id;
		Name = name;
		_barcode = new Barcode.Barcode(id.ToString());
	}

	public override string ToString()
	{
		return $"{Type}: {Name}\nId:{Id}\n{Description}\n{Barcode}";
	}
}

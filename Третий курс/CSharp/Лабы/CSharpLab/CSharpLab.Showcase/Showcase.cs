using CSharpLab.AirTransport;
using System.Text;

namespace CSharpLab.Showcase;

public class Showcase
{
	private AirTranportBase?[] _airTranportBases;
	private int _id;

	public int Id 
	{
		get => _id; 
		set 
		{
			if (_id != value)
			{
				_id = value;
				ChangeItemsBarcode();
			}
		}
		}

	private Showcase(int capacity)
	{
		_airTranportBases = new AirTranportBase[capacity];
	}

	public static implicit operator Showcase(int a)
	{
		return new Showcase(a); 
	}

	public AirTranportBase? this[int index]
	{
		get
		{
			if(index < 0 | index >= _airTranportBases.Length)
			{
				return null;
			}
			var value = _airTranportBases[index];
			_airTranportBases[index] = null;
			return value;
		}
		set
		{
			if (index < 0 | index >= _airTranportBases.Length)
			{
				return;
			}
			_airTranportBases[index] = value;
			ChangeItemBarcode(value);
		}
	}

	public void Push(AirTranportBase airTranportBase)
	{
		for(int i = 0; i < _airTranportBases.Length; i++)
		{
			if (_airTranportBases[i] == null)
			{
				this[i] = airTranportBase;
				return;
			}
		}
		this[0] = airTranportBase; 
	}

	public AirTranportBase? Pop()
	{
		for(int i = 0; i < _airTranportBases.Length; i++)
		{
			if (_airTranportBases[i] != null)
			{
				var value = _airTranportBases[i];
				this[i] = null;
				return value;
			}
		}
		return null;
	}

	public void Remove(int index)
	{
		this[index] = null;
	}

	public void Push(AirTranportBase airTranportBase, int index)
	{
		this[index] = airTranportBase;
	}

	public void OrderByName()
	{
		Array.Sort(_airTranportBases, (a, b) =>
		{
			if(a == null) return -1;
			if(b == null) return 1;
			return a.Name.CompareTo(b.Name);
		});
		ChangeItemsBarcode();
	}

	public void OrderById()
	{
		Array.Sort(_airTranportBases, (a, b) =>
		{
			if (a == null) return -1;
			if (b == null) return 1;
			return a.Id.CompareTo(b.Id);
		});
		ChangeItemsBarcode();
	}

	public AirTranportBase? FindById(int id)
	{
		return _airTranportBases.FirstOrDefault(a => a?.Id == id);
	}

	public AirTranportBase? FindByName(string name)
	{
		return _airTranportBases.FirstOrDefault(a => a?.Name == name);
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
		foreach (var a in _airTranportBases) 
		{
			if(a != null)
				sb.AppendLine(a.ToString());
			else
				sb.AppendLine("Empty");

		}
		return sb.ToString();
	}

	private void ChangeItemBarcode(AirTranportBase airTranportBase)
	{
		if(airTranportBase == null) return;
		airTranportBase.Barcode.Text = $"{airTranportBase.Id} {Id} {Array.IndexOf(_airTranportBases, airTranportBase)}";
	}

	private void ChangeItemsBarcode()
	{
		foreach(var a in _airTranportBases)
		{
			ChangeItemBarcode(a);
		}
	}
}

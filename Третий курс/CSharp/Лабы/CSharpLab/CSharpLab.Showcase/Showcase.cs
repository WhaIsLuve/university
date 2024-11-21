using CSharpLab.AirTransport;
using System.Text;

namespace CSharpLab.Showcase;

public class Showcase<T> : IShowcase<T> where T : IAirTransport
{
	private T?[] _airTranportBases;
	private int _id;

	/// <inheritdoc />
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
		_airTranportBases = new T[capacity];
	}

	public static implicit operator Showcase<T>(int a)
	{
		return new Showcase<T>(a); 
	}

	public T? this[int index]
	{
		get
		{
			if(index < 0 | index >= _airTranportBases.Length)
			{
				return default;
			}
			var value = _airTranportBases[index];
			_airTranportBases[index] = default;
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

	/// <inheritdoc />
	public void Push(T airTranportBase)
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

	/// <inheritdoc />
	public T? Pop()
	{
		for(int i = 0; i < _airTranportBases.Length; i++)
		{
			if (_airTranportBases[i] != null)
			{
				var value = _airTranportBases[i];
				this[i] = default;
				return value;
			}
		}
		return default;
	}

	/// <inheritdoc />
	public void Remove(int index)
	{
		this[index] = default;
	}

	/// <inheritdoc />
	public void Push(T airTranportBase, int index)
	{
		this[index] = airTranportBase;
	}

	/// <inheritdoc />
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

	/// <inheritdoc />
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

	/// <inheritdoc />
	public T? FindById(int id)
	{
		return _airTranportBases.FirstOrDefault(a => a?.Id == id);
	}

	/// <inheritdoc />
	public T? FindByName(string name)
	{
		return _airTranportBases.FirstOrDefault(a => a?.Name == name);
	}

	/// <inheritdoc />
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

	private void ChangeItemBarcode(T airTranportBase)
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

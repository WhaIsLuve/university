using CSharpLab.AirTransport;
using System.Text;

namespace CSharpLab.Showcase;

public class Showcase<T> : IShowcase<T> where T : class, IAirTransport
{
	private T?[] _airTranportBases;
	private int _id;

	public delegate void ChangeShowcaseId(IShowcase<T> showcase);

	private ChangeShowcaseId _changeId;

	/// <inheritdoc />
	public int Id 
	{
		get => _id; 
		set 
		{
			if (_id != value)
			{
				_id = value;
				_changeId?.Invoke(this);
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
				return null;
			}
			var value = _airTranportBases[index];
			_airTranportBases[index] = null;
			if(value != null)
			{
				_changeId -= value.UpdateBarcode;
				value.ChangeId -= ChangeId;
			}
			return value;
		}
		set
		{
			if (index < 0 | index >= _airTranportBases.Length)
			{
				return;
			}
			_airTranportBases[index] = value;
			value?.UpdateBarcode(this);
			_changeId += value.UpdateBarcode;
			value.ChangeId += ChangeId;
		}
	}

	private void ChangeId(object? sender, TransportEventArgs e)
	{
		if (sender is T product)
		{
			product.UpdateBarcode(this);
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
				this[i] = null;
				return value;
			}
		}
		return null;
	}

	/// <inheritdoc />
	public void Remove(int index)
	{
		this[index] = null;
	}

	/// <inheritdoc />
	public void Push(T airTranportBase, int index)
	{
		this[index] = airTranportBase;
	}

	/// <inheritdoc />
	public void OrderByName() => OrderBy((a, b) => a.Name.CompareTo(b.Name));

	private void OrderBy(Func<T, T, int> func)
	{
		Array.Sort(_airTranportBases, (a, b) =>
		{
			if (a == null) return -1;
			if (b == null) return 1;
			return func(a, b);
		});
		_changeId?.Invoke(this);
	}

	private int? FindBy(Predicate<T?> predicate)
	{
		for (int i = 0; i < _airTranportBases.Length; i++)
		{
			if (_airTranportBases[i] != null && predicate(_airTranportBases[i]))
			{
				return i;
			}
		}
		return null;
	}

	public void OrderById() => OrderBy((a, b) => a.Id.CompareTo(b.Id));

	/// <inheritdoc />
	public int? FindById(int id)
	{
		
		return FindBy((t) => t?.Id == id);
	}

	/// <inheritdoc />
	public int? FindByName(string name) => FindBy(a => a?.Name == name);

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
}

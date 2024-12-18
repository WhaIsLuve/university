using System.Text;

namespace CSharpLab.Barcode;

public class Barcode : IBarcode
{
	private string _text;
	private string _barcode;

	/// <inheritdoc />
	public string Text 
	{
		get => _text;
		set
		{
			if( _text != value )
			{
				_text = value;
				_barcode = BarcodeHelper.GetCode(value);
			}
		}
	}

	/// <inheritdoc />
	public string GraphicalBarcode => _barcode;

	/// <summary>
	/// Создает экземпляр класса <see cref="Barcode" />.
	/// </summary>
	/// <param name="text">Текст.</param>
	public Barcode(string text) => Text = text;

	public override string ToString()
	{
		switch (IBarcode.BarcodeType)
		{
			case BarcodeType.Text:
				return _text;
			case BarcodeType.Barcode:
				return _barcode;
			case BarcodeType.Full:
				int index = (_barcode.Length / 6 - _text.Length) / 2;
				StringBuilder result = new();
				result.Append(_barcode + "\n");
				for(int i = 0; i < index; i++)
				{
					result.Append(" ");
				}
				result.Append(_text);
				return result.ToString();
			default:
				return string.Empty;
		}
	}
}

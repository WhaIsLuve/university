using System.Text;

namespace CSharpLab.Barcode;

public record BarcodeRecord : IBarcode
{
	private string _text = string.Empty;
	private string _barcode = string.Empty;

	public BarcodeRecord(string text)
	{
		Text = text;
	}

	/// <inheritdoc />
	public BarcodeType BarcodeType { get; set; } = BarcodeType.Full;

	/// <inheritdoc />
	public string Text
	{
		get => _text;
		set
		{
			if (_text != value)
			{
				_text = value;
				_barcode = BarcodeHelper.GetCode(value);
			}
		}
	}

	/// <inheritdoc />
	public string GraphicalBarcode => _barcode;

	public override string ToString()
	{
		switch (BarcodeType)
		{
			case BarcodeType.Text:
				return $"* {Text} *";
			case BarcodeType.Barcode:
				return _barcode;
			case BarcodeType.Full:
				int index = (_barcode.Length / 6 - _text.Length) / 2;
				StringBuilder result = new();
				result.Append(_barcode + "\n");
				for (int i = 0; i < index; i++)
				{
					result.Append(" ");
				}
				result.Append($"* {Text} *");
				return result.ToString();
			default:
				return string.Empty;
		}
	}
}

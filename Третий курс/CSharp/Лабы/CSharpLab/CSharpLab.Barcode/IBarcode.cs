namespace CSharpLab.Barcode;

public interface IBarcode
{
	/// <summary>
	/// Возвращает тип вывода штрикода.
	/// </summary>
	public static BarcodeType BarcodeType { get; } = BarcodeType.Full;

	/// <summary>
	/// Возращает исходный текст штрихкода.
	/// </summary>
	string Text { get; set; }
}

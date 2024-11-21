namespace CSharpLab.Barcode;

public interface IBarcode
{
	/// <summary>
	/// Возвращает тип вывода штрикода.
	/// </summary>
	BarcodeType BarcodeType { get; }

	/// <summary>
	/// Возращает исходный текст штрихкода.
	/// </summary>
	string Text { get; set; }

	/// <summary>
	/// Возвращает штрикод в графическом преобразовании.
	/// </summary>
	string GraphicalBarcode { get; }
}

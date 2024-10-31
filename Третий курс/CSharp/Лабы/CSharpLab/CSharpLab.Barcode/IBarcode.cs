namespace CSharpLab.Barcode;

internal interface IBarcode
{
	/// <summary>
	/// Возвращает тип вывода штрикода.
	/// </summary>
	BarcodeType BarcodeType { get; }

	/// <summary>
	/// Возращает исходный текст штрихкода.
	/// </summary>
	string Text { get; }

	/// <summary>
	/// Возвращает штрикод в графическом преобразовании.
	/// </summary>
	string GraphicalBarcode { get; }
}

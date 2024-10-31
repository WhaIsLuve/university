namespace CSharpLab.Barcode;

/// <summary>
/// Формат сборки штрих-кода, должен быть в отдельно файле
/// </summary>
public enum BarcodeType
{
	/// <summary>
	/// Текстовая информация
	/// </summary>
	Text,

	/// <summary>
	/// Штрих-код
	/// </summary>
	Barcode,

	/// <summary>
	/// Полная информация
	/// </summary>
	Full
}

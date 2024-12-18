using CSharpLab.AirTransport;

namespace CSharpLab.Showcase;

internal static class ChangeId
{
	public static void UpdateBarcode<T>(this T product, IShowcase<T> showcase)
			where T : class, IAirTransport
	{
		var val = showcase.FindById(product.Id);
		product.Barcode.Text = product.Id + " " + showcase.Id.ToString() + " " + val.ToString();
	}
}

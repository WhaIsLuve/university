namespace Core.Purchases.Repositories;

public interface IPurchaseRepository
{
	int? Add(Purchase purchase);

	Result Delete();
}

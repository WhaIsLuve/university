namespace Core.Promotions.Repositories;

public interface IPromotionRepository
{
	Result Add(Promotion promotion);

	IEnumerable<Promotion> GetPromotions();

	Result Delete(string name);
}

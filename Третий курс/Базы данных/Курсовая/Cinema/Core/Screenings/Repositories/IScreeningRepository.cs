namespace Core.Screenings.Repositories;

public interface IScreeningRepository
{
	Result Add(Screening screening);

	IEnumerable<Screening> GetScreenings();

	Result Update(Screening screening);

	Result Delete(Screening screening);
}

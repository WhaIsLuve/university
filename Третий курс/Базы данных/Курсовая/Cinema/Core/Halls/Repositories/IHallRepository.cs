namespace Core.Halls.Repositories;

public interface IHallRepository
{
	Result Add(Hall hall);

	IEnumerable<Hall> GetHalls();

	Result Delete(string hallName);

	IEnumerable<Seat> GetAllSeatsByHallName(string hallName);
}

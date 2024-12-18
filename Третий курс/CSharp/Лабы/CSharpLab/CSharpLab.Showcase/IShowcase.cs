using CSharpLab.AirTransport;

namespace CSharpLab.Showcase;

public interface IShowcase<T> where T : class, IAirTransport
{
	/// <summary>
	/// Возвращает идентификатор витрины.
	/// </summary>
	int Id { get; set; }

	T? this[int index] { get; set; }

	/// <summary>
	/// Добавляет элемент в витрину.
	/// </summary>
	/// <param name="airTransport">Элемент.</param>
	void Push(T airTransport);

	/// <summary>
	/// Добавляет элемент в витрину на указанную позицию.
	/// </summary>
	/// <param name="airTransport">Элемент.</param>
	/// <param name="index">Позиция.</param>
	void Push(T airTransport, int index);

	/// <summary>
	/// Удаляет и возвращает последний элемент из витрины.
	/// </summary>
	/// <returns>Последний элемент из витрины.</returns>
	T? Pop();

	/// <summary>
	/// Удаляет элемент из витрины по указанной позиции.
	/// </summary>
	/// <param name="index">Позиция.</param>
	void Remove(int index);

	/// <summary>
	/// Сортировка по имени.
	/// </summary>
	void OrderByName();

	/// <summary>
	/// Сортировка по идентификатору.
	/// </summary>
	void OrderById();

	/// <summary>
	/// Поиск по ИД.
	/// </summary>
	/// <param name="id">ИД</param>
	/// <returns>Элемент</returns>
	int? FindById(int id);

	/// <summary>
	/// Поиск по имени.
	/// </summary>
	/// <param name="name">Имя.</param>
	/// <returns>Элемент</returns>
	int? FindByName(string name);
}

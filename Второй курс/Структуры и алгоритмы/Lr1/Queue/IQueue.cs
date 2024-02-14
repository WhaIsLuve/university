namespace Lr1.Queue
{
	/// <summary>Интерфейс очереди.</summary>
	public interface IQueue
	{
		/// <summary>Добавляет элемент в очередь.</summary>
		/// <param name="value"></param>
		void Enqueue(int value);
		
		/// <summary>Удаляет первый элемент очереди.</summary>
		/// <returns>Первый элемент.</returns>
		int Dequeue();

		/// <summary>Пуста ли очередь.</summary>
		/// <value>Пуста ли очередь.</value>
		bool IsEmpty { get; }
		
		/// <summary>Обнуляет очередь.</summary>
		void ToNull();

		/// <summary>Выводит все элементы очереди.</summary>
		void Print();
	}
}

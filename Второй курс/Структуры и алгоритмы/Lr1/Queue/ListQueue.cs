namespace Lr1.Queue
{
	/// <summary>Очередь реализованная через список.</summary>
	public class ListQueue : IQueue
	{
		#region QueueItem
		/// <summary>Данные хранящиеся в очереди</summary>
		private class QueueItem
		{
			/// <summary>Значение очереди.</summary>
			/// <value>Значение очереди.</value>
			public int Value { get; set; }

			/// <summary>Указатель на следующий элемент.</summary>
			/// <value>Указатель на следующий элемент.</value>
			public QueueItem? Next { get; set; }
		}
		#endregion

		/// <summary>Голова очереди.</summary>
		QueueItem? head;

		/// <summary>Хвост очереди.</summary>
		QueueItem? tail;

		/// <inheritdoc/>
		public bool IsEmpty => head == null;

		/// <inheritdoc/>
		public int Dequeue()
		{
			if (IsEmpty) 
				throw new InvalidOperationException("Очередь пуста");
			var result = head.Value;
			head = head.Next;
			if (head == null)
				tail = null;
			return result;
		}

		/// <inheritdoc/>
		public void Enqueue(int value)
		{
			var item = new QueueItem() { Value = value };
			if (IsEmpty)
			{
				head = tail = item;
			}
			else
			{
				tail.Next = item;
				tail = item;
			}
		}

		/// <inheritdoc/>
		public void ToNull()
		{
			while(!IsEmpty)
			{
				Dequeue();
			}
		}

		/// <inheritdoc/>
		public void Print()
		{
			var tmp = head;

			while (tmp != null)
			{
				Console.Write($"{tmp.Value} ");
				tmp = tmp.Next;
			}
			Console.WriteLine("\n\n");
			Console.WriteLine("\n\n");
		}
	}
}

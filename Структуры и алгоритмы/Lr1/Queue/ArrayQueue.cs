namespace Lr1.Queue
{
    /// <summary>Очередь реализовання через массив.</summary>
    /// <param name="capacity">Вместимость очереди.</param>
    public class ArrayQueue(int capacity = 20) : IQueue
    {
        /// <summary>
        /// Данные хранящиеся в массиве.
        /// </summary>
        private readonly int[] data = new int[capacity];

        private int tail = 0;
        private int head = 0;

        /// <inheritdoc/>
        public bool IsEmpty => tail == head;

        /// <inheritdoc/>
        public int Dequeue()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Очередь пуста");
            return data[head++];
        }

        /// <inheritdoc/>
        public void Enqueue(int value)
        {
            if (tail >= data.Length)
                throw new IndexOutOfRangeException("Очередь переполнена");
            data[tail++] = value;
        }

        /// <inheritdoc/>
        public void ToNull()
        {
            tail = head = 0;
        }

        /// <inheritdoc/>
        public void Print() 
        {
            for(int i = 0; i < tail; i++)
                Console.Write($"{data[i]} ");
			Console.WriteLine("\n\n");
			Console.WriteLine("\n\n");
		}
    }
}

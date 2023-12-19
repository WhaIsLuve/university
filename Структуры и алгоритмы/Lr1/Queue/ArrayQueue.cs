namespace Lr1.Queue
{
    /// <summary>Очередь реализовання через массив.</summary>
    /// <param name="capacity">Вместимость очереди.</param>
    public class ArrayQueue(int capacity = 20) : IQueue
    {
        /// <summary>
        /// Данные хранящиеся в массиве.
        /// </summary>
        private readonly int[] data = new int[capacity+1];

        private int tail = capacity;
        private int head = 0;
        private int size = capacity + 1;

        /// <inheritdoc/>
        public bool IsEmpty => Next(tail) == head;

        private int Next(int n) => (n + 1) % size;

        /// <inheritdoc/>
        public int Dequeue()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Очередь пуста");
            int d = data[head];
            head = Next(head);
            return d;
        }

        /// <inheritdoc/>
        public void Enqueue(int value)
        {
            if (Next(Next(tail)) == head)
                throw new IndexOutOfRangeException("Очередь переполнена");
            tail = Next(tail);
            data[tail] = value;
        }

        /// <inheritdoc/>
        public void ToNull()
        {
            head = 0;
            tail = size - 1;

        }

        /// <inheritdoc/>
        public void Print() 
        {
            var tmp = head;
            if (!IsEmpty)
                while(tmp != tail + 1)
                {
                    Console.Write($"{data[tmp]} ");
                    tmp = Next(tmp);
                }
			Console.WriteLine("\n\n");
			Console.WriteLine("\n\n");
		}
    }
}

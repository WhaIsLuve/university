namespace Lr1.Stack
{
    /// <summary>
    /// Стек, реализованный через массив.
    /// </summary>
    public class ArrayStack(int capacity = 20) : IStack
    {
        /// <summary>
        /// Массив, хранящий данные стека.
        /// </summary>
        private readonly int[] data = new int[capacity];

        /// <summary>
        /// Шаг стека.
        /// </summary>
        private int top = -1;

        /// <inheritdoc/>
        public bool IsEmpty => top == -1;

        /// <inheritdoc/>
        public void Push(int element)
        {
            if (top >= data.Length)
            {
                throw new IndexOutOfRangeException("Стек переполнен.");
            }
            data[++top] = element;
        }
        /// <inheritdoc/>
        public int Pop()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Стек пуст.");
            return data[top--];
        }

        /// <inheritdoc/>
        public void ToNull()
        {
            top = -1;
        }

        /// <inheritdoc/>
        public void Print()
        {
            if (!IsEmpty)
            {
                for(int i = top; i >= 0; i--)
                    Console.Write($"{data[i]} ");
            }
			Console.WriteLine("\n\n");
			Console.WriteLine("\n\n");
		}
    }
}

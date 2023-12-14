using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1.Stack
{
    /// <summary>
    /// Стэк, реализованный через список.
    /// </summary>
    public class ListStack : IStack
    {
        /// <summary>
        /// Список, хранящий данные стэка.
        /// </summary>
        private readonly List<int> data = [];

        /// <inheritdoc/>
        public bool IsEmpty => data.Count == 0;

        /// <inheritdoc/>
        public void Push(int element)
        {
            data.Add(element);
        }
        /// <inheritdoc/>
        public int Pop()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Стэк пуст.");
            var result = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return result;
        }

        /// <inheritdoc/>
        public void ToNull()
        {
            data.Clear();
        }

        /// <inheritdoc/>
        public void Print()
        {
            if (!IsEmpty)
            {
                if (!IsEmpty)
                {
                    for (int i = data.Count - 1; i >= 0; i--)
                        Console.Write($"{data[i]} ");
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\n");
            }
        }
	}
}

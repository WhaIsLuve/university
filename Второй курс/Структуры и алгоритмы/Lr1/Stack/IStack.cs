namespace Lr1.Stack
{
    /// <summary>
    /// Интерфейс стека.
    /// </summary>
    public interface IStack
    {
        /// <summary>Пустой ли стек.</summary>
        /// <value>Пусто ли стек.</value>
        bool IsEmpty { get; }

        /// <summary>
        /// Добавляет элемент в стек.
        /// </summary>
        /// <param name="element">Элемент.</param>
        void Push(int element);

        /// <summary>
        /// Удаляет последний элемент в стеке.
        /// </summary>
        /// <returns>Последний элемент в стеке.</returns>
        int Pop();

        /// <summary>Обнуляет стек.</summary>
        void ToNull();
        
        /// <summary>Выводит все элементы стека.</summary>
        void Print();
    }
}

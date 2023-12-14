using Lr1.Queue;
using Lr1.Stack;

namespace Lr1
{
    public static class Lab1
	{
		public static void Variant17(IQueue queue, IStack stack)
		{
			var queueElement = new List<int>();
			var stackElement = new List<int>();
			var newStackElement = new List<int>();
			while(!queue.IsEmpty)
			{
				queueElement.Add(queue.Dequeue());
			}
			while(!stack.IsEmpty)
			{
				stackElement.Add(stack.Pop());
			}
			if (queueElement.Count == 0 || stackElement.Count == 0)
			{
                Console.WriteLine("сформировать новый стек невозможно.");
				return;
            }
				
			var minElementInQueue = queueElement.Min();
            Console.WriteLine($"Минимальный элемент: {minElementInQueue}");

            foreach (var element in stackElement) 
			{
				if (element < minElementInQueue)
				{
					newStackElement.Add(element);
				}
			}

			var newStack = new ListStack();

			foreach (var element in newStackElement)
				newStack.Push(element);
            Console.Write("Новый стек: ");
            newStack.Print();
        }
	}
}

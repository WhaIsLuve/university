using Lr1.Queue;
using Lr1.Stack;

namespace Lr1
{
    public static class Lab1
	{
		public static void Variant17(IQueue queue, IStack stack)
		{
			if (queue.IsEmpty || stack.IsEmpty)
			{
                Console.WriteLine("сформировать новый стек невозможно.");
				return;
            }
			var stackElement = new List<int>();
			var newStackElement = new List<int>();
			var minElementInQueue = int.MaxValue;
			while (!queue.IsEmpty)
			{
				var tmp = queue.Dequeue();
				if (tmp < minElementInQueue)
				{
					minElementInQueue = tmp;
				}
			}
			while(!stack.IsEmpty)
			{
				stackElement.Add(stack.Pop());
			}
				
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

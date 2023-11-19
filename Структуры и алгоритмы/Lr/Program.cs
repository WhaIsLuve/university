using Lr1;
using Lr1.Stack;
using Lr1.Queue;

namespace Lr
{
	internal class Program
	{
		static void Main()
		{
			var rnd = new Random();
			var lenQueue = rnd.Next(0, 100);
			var lenStack = rnd.Next(0, 100);
			var queue = new ListQueue();
			while (lenQueue-- > 0)
			{
				queue.Enqueue(rnd.Next(50, 100));
			}
            Console.Write("Очередь: ");
            queue.Print();
			var stack = new ListStack();
			while (lenStack-- > 0)
			{
				stack.Push(rnd.Next(0, 100));
			}
			Console.Write("Стек: ");
			stack.Print();
			Lab1.Variant17(queue, stack);
		}
	}
}

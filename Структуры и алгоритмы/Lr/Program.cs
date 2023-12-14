using Lr1;
using Lr1.Stack;
using Lr1.Queue;
using Lr2;

namespace Lr
{
	internal class Program
	{
		static void Mainx()
		{
			var q = new ArrayQueue(5);
			q.Enqueue(1); q.Enqueue(2); q.Enqueue(3); q.Enqueue(4); q.Enqueue(5);
			q.Print();
			q.Dequeue(); q.Dequeue(); q.Dequeue();
			q.Print();
			var s = new ListStack();
			s.Push(1); s.Push(2); s.Push(3); s.Push(4); s.Push(5);
			s.Print();
			s.Pop(); s.Pop(); s.Pop();
			s.Print();
			var rnd = new Random();
			var lenQueue =  rnd.Next(0, 100);
			var lenStack = rnd.Next(0, 100);
			var queue = new ArrayQueue(lenQueue);
			while (lenQueue-- > 1)
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

		static void Main()
		{
			Lab2.Variant17();
		}
	}
}

using Lr1;
using Lr1.Stack;
using Lr1.Queue;
using Lr2;
using Lr4;
using Lr5;

namespace Lr
{
	internal class Program
	{
		static void Main1()
		{
			var q = new ArrayQueue(5);
			q.Enqueue(1); q.Enqueue(2); q.Enqueue(3); q.Enqueue(4); q.Enqueue(5);
			q.Print();
			q.Dequeue(); q.Dequeue(); q.Dequeue();
			q.Print();
			q.Enqueue(6); q.Enqueue(7);q.Enqueue(8);
			q.Print();

			var s = new ArrayStack(5);
			s.Push(1); s.Push(2); s.Push(3); s.Push(4); s.Push(5);
			s.Print();
			s.Pop(); s.Pop(); s.Pop();
			s.Push(6);s.Push(7);
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

		static void Main2()
		{
			BinaryTree tree = new();
			var rnd = new Random();
			var countElementInTree = 10;//rnd.Next(5, 10);
			for (int i = 0; i < countElementInTree; i++)
				tree.Add(rnd.Next(1, 100));
            Console.WriteLine("Original tree:");
            tree.PrintTreeS();
			tree.PrintTreeR();
			tree.PrintTreeC();
			var copyTree = tree.Copy();
            Console.WriteLine("Copy tree:");
            copyTree.PrintTreeS();
			copyTree.PrintTreeR();
			copyTree.PrintTreeC();
		}

		static void Main4()
		{
            Console.WriteLine("Введите натуральное число:");
            var input = int.Parse(Console.ReadLine());
            Lab4.var1(input);
        }

		static void Main() 
		{
			int[,] ints = { { 1, -4, 5, 30 }, { 10, -7, -5, 4 }, { 0, 2, 17, 24 }, { -2, 5, 1, 3 } };
			Lab5.Variant5(ints);
		}
	}
}

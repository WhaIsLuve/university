using Lr1;
using Lr1.Stack;
using Lr1.Queue;
using Lr2;
using Lr4;
using Lr5;
using Lr6;
using Sort;
using System.Diagnostics;

namespace Lr
{
	internal class Program
	{
		static void Main1()
		{
			var q = new ListQueue();
			q.Enqueue(1); q.Enqueue(2); q.Enqueue(3); q.Enqueue(4); q.Enqueue(5);
			q.Print();
			q.Dequeue(); q.Dequeue(); q.Dequeue();
			q.Print();
			q.Enqueue(6); q.Enqueue(7);q.Enqueue(8);
			q.Print();

			var s = new ListStack();
			s.Push(1); s.Push(2); s.Push(3); s.Push(4); s.Push(5);
			s.Print();
			s.Pop(); s.Pop(); s.Pop();
			s.Push(6);s.Push(7);
			s.Print();
			var rnd = new Random();
			var lenQueue = rnd.Next(0, 100);
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
				tree.Add(rnd.Next(1, 100).ToString());
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

		static void Mai4()
		{
			Console.WriteLine("Введите натуральное число:");
			var input = int.Parse(Console.ReadLine());
			Lab4.var1(input);
		}

		static void Main5() 
		{
			var path = @"C:\Users\Влад\Desktop\Университет\Второй курс\Структуры и алгоритмы\input.txt";
			var input = File.ReadAllText(path);
			string[] lines = File.ReadAllLines(path);
			var size = lines[0].Split().Select(i => int.Parse(i)).ToArray();
			int sizeX = size[0];
			int sizeY = size[1];

			int[,] array = new int[sizeX, sizeY];

			for (int i = 1; i < lines.Length; i++)
			{
				string[] elements = lines[i].Split(' ');
				for (int j = 0; j < sizeY; j++)
				{
					array[i-1, j] = int.Parse(elements[j]);
				}
			}
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					Console.Write($"{array[i, j]} ");
				}
				Console.WriteLine();
			}
			Lab5.Variant5(array);
		}

		static void Main6()
		{
			int[] array = [4, 7, 1, 3, 0, -1];
			int[] array2 = [4, 7, 1, 3, 0, -1];
			int[] array3 = [4, 7, 1, 3, 0, -1];
			Console.WriteLine("Insert Sort:");
			Sort.Sort.PrintArray(array);
			Sort.Sort.InsertSort(array);
			Sort.Sort.PrintArray(array);
			Console.WriteLine("Shaker Sort:");
			Sort.Sort.PrintArray(array2);
			Sort.Sort.ShakerSort(array2);
			Sort.Sort.PrintArray(array2);
			Console.WriteLine("Shell sort:");
			Sort.Sort.PrintArray(array3);
			Sort.Sort.ShellSort(array3);
			Sort.Sort.PrintArray(array3);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Введите длину массива");

			int length = int.Parse(Console.ReadLine());
			var rand = new Random();
			int[] ints = new int[length];
			for (int i = 0; i < length; i++)
			{
				ints[i] = rand.Next(-1999, 2000);

			}
			Sort.Sort.SetTimer([..ints], Sort.Sort.ShellSort, "Shell Sort");
			Sort.Sort.SetTimer([..ints], Sort.Sort.InsertSort, "Insert Sort");
			Sort.Sort.SetTimer(ints, Sort.Sort.ShakerSort, "Shaker Sort");
			Console.WriteLine();

			Sort.Sort.SetTimer(ints, Sort.Sort.ShellSort, "Sorted Shell Sort");
			Sort.Sort.SetTimer(ints, Sort.Sort.InsertSort, "Sorted Insert Sort");
			Sort.Sort.SetTimer(ints, Sort.Sort.ShakerSort, "Sorted Shaker Sort");
			Console.WriteLine();
			
			Sort.Sort.SetTimer([.. ints.Reverse().ToArray()], Sort.Sort.ShellSort, "Reverse Shell Sort");
			Sort.Sort.SetTimer([.. ints.Reverse().ToArray()], Sort.Sort.InsertSort, "Reverse Insert Sort");
			Sort.Sort.SetTimer([.. ints.Reverse().ToArray()], Sort.Sort.ShakerSort, "Reverse Shaker Sort");
		}

		public static void Main()
		{
			BinaryTree binaryTree = new();
			binaryTree.Add("b");
			binaryTree.Add("a");
			binaryTree.Add("c");
			binaryTree.Add("bb");
			binaryTree.Add("bb");
			binaryTree.PrintTreeC();
		}
	}
}

using System.Drawing;

namespace Lr1.Stack
{
	/// <summary>
	/// Стэк, реализованный через список.
	/// </summary>
	public class ListStack : IStack
	{
		private class Node
		{
			public int Value;
			public Node? Next;
		}

		private Node? Head;
		public int Size;

		/// <inheritdoc/>
		public bool IsEmpty => Size == 0 && Head is null;

		/// <inheritdoc/>
		public void Push(int element)
		{
			Node tmp = new();
			tmp.Next = Head;
			Head = tmp;
			Head.Value = element;
			Size++;
		}
		/// <inheritdoc/>
		public int Pop()
		{
			if (IsEmpty)
				throw new IndexOutOfRangeException("Стэк пуст.");
			var result = Head.Value;
			Head = Head.Next;
			Size--;
			return result;
		}

		/// <inheritdoc/>
		public void ToNull()
		{
			Head = null;
		}

		/// <inheritdoc/>
		public void Print()
		{
			if (!IsEmpty)
			{
				Print(Head);
				Console.WriteLine("\n\n");
				Console.WriteLine("\n\n");
			}
		}

		void Print(Node node)
		{
			if (node is null) return;
			Console.Write($"{node.Value} ");
			Print(node.Next);
		}
	}
}

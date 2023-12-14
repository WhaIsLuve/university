using System.Threading.Channels;

namespace Lr2
{
	public class BinaryTree
	{
		private class NodeTree(int data)
		{
			public int value = data;
			public NodeTree? left;
			public NodeTree? right;
		}

		private NodeTree head;

		public void Add(int data) => head = Add(head, data);

		private NodeTree Add(NodeTree? tree, int data)
		{
			var tmp = tree;
			if(tree == null)
			{
				return new NodeTree(data);
			}
			else
			{
				var rand = new Random();
				if(rand.Next() % 2 == 0)
					tmp.left = Add(tree.left, data);
				else
					tmp.right = Add(tree.right, data);
			}
			return tmp;
		}

		/// <summary>Прямой вывод дерева.</summary>
		public void PrintTreeS()
		{
			PrintTreeS(head);
			Console.WriteLine("\n");
		}

		private void PrintTreeS(NodeTree? tree)
		{
			if (tree == null)
				return;
            Console.Write($"{tree.value} ");
			PrintTreeS(tree.left);
			PrintTreeS(tree.right);
        }
		public void PrintTreeR()
		{
			PrintTreeR(head);
			Console.WriteLine("\n");
		}

		private void PrintTreeR(NodeTree? tree)
		{
			if (tree == null)
				return;
			PrintTreeS(tree.left);
			PrintTreeS(tree.right);
			Console.Write($"{tree.value} ");
		}

		public void PrintTreeC()
		{
			PrintTreeC(head);
			Console.WriteLine("\n");
		}

		private void PrintTreeC(NodeTree? tree)
		{
			if (tree == null)
				return;
			PrintTreeS(tree.left);
			Console.Write($"{tree.value} ");
			PrintTreeS(tree.right);
		}
	}
}
namespace Lr2
{
	public class BinaryTree
	{
		public class NodeTree(int data)
		{
			public int value = data;
			public NodeTree? left;
			public NodeTree? right;
		}

		public NodeTree? head;

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
			PrintTreeR(tree.left);
			PrintTreeR(tree.right);
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
			PrintTreeC(tree.left);
			Console.Write($"{tree.value} ");
			PrintTreeC(tree.right);
		}

		public BinaryTree Copy()
		{
			var copy = Copy(head);
			var result = new BinaryTree();
			result.head = copy;
			return result;
		}

		private NodeTree? Copy(NodeTree? node)
		{
			if (node == null)
				return null;
			NodeTree result = new(node.value);
			result.left = Copy(node.left);
			result.right = Copy(node.right);

			return result;
		}
	}
}
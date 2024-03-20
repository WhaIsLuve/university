using System.Text;

namespace Lr6
{
	public class HuffmanTree
	{
		private class Node
		{
			public readonly int frequency;
			public readonly byte symbol;
			public readonly Node left;
			public readonly Node right;

			public Node(int freq, byte s)
			{
				symbol = s;
				frequency = freq;
			}

			public Node(int freq, Node l, Node r)
			{
				frequency = freq;
				left = l;
				right = r;
			}
		}

		public static void CompressFile(string dataFileName, string achiveFileName)
		{
			byte[] bytes = File.ReadAllBytes(dataFileName);
			byte[] archBytes = CompressBytes(bytes);
			File.WriteAllBytes(achiveFileName, archBytes);
		}

		public static void DecompressFile(string archFileName, string fileName)
		{
			byte[] bytes = File.ReadAllBytes(archFileName);
			byte[] data = DecompressByte(bytes);
			File.WriteAllBytes(fileName, data);
		}

		private static byte[] DecompressByte(byte[] bytes)
		{
			ParseHeader(bytes, out int dataLength, out int startIndex, out int[] frequency);
			Node root = CreateHuffmanTree(frequency);
			byte[] data = Decompress(bytes, startIndex, dataLength, root);
			return data;
		}

		private static byte[] Decompress(byte[] arch, int startIndex, int dataLength, Node root)
		{
			int size = 0;
			Node curr = root;
			byte[] data = new byte[dataLength];
			for(int j = startIndex; j < arch.Length; j++)
			{
				for(int bit = 1; bit <= 128; bit <<= 1)
				{
					if ((arch[j] & bit) == 0)
					{
						curr = root.left;
					}
					else curr = root.right;
					if (curr.left == null)
					{
						if(size < dataLength)
							data[size++] = curr.symbol;
						curr = root;
					}
				}
			}
			return data;
		}

		private static void ParseHeader(byte[] bytes, out int dataLength, out int startIndex, out int[] frequency)
		{
			dataLength = bytes[0] | (bytes[1] << 8) | (bytes[2] << 16) | (bytes[3] << 24);
			frequency = new int[256];
			int count = bytes[4];
			if (count == 0) count = 256;
			for(int i = 0; i < count; i++)
			{
				byte symbol = bytes[5 + i * 2];
				frequency[symbol] = bytes[5 + i * 2 + 1];
			}
			startIndex = 4 + 1 + 2 * count;
		}

		private static byte[] CompressBytes(byte[] bytes)
		{
			int[] frequency = CalculateFrequency(bytes);
			byte[] header = CreateHeader(bytes.Length, frequency);
			Node root = CreateHuffmanTree(frequency);
			string[] codes = CreateHuffmanCode(root);
			byte[] bits = Compress(bytes, codes);
			return [.. header, .. bits];
		}

		private static byte[] CreateHeader(int length, int[] frequency)
		{
			List<byte> header = [];
			header.Add((byte)(length & 255));
			header.Add((byte)((length >> 8) & 255));
			header.Add((byte)((length >> 16) & 255));
			header.Add((byte)((length >> 24) & 255));
			for (int i = 0; i < 256; i++)
			{
				header.Add((byte)frequency[i]);
			}
			return header.ToArray();
		}

		private static byte[] Compress(byte[] bytes, string[] codes)
		{
			List<byte> bits = [];
			byte sum = 0;
			byte bit = 1;
			foreach (byte b in bytes) 
			{
				foreach(char ch in codes[b])
				{
					if(ch == '1')
					{
						sum |= bit;
						if(bit < 128)
						{
							bit <<= 1;
						}
						else
						{
							bits.Add(sum);
							sum = 0;
							bit = 1;
						}
					}
				}
			}
			if(bit > 1)
			{
				bits.Add(sum);
			}
			return bits.ToArray();
		}

		private static string[] CreateHuffmanCode(Node root)
		{
			string[] codes = new string[256];
			Next(root, codes, "");
			return codes;
		}

		private static void Next(Node node, string[] codes, string code)
		{
			if(node.left is null)
			{
				codes[node.symbol] = code;
			}
			else
			{
				Next(node.left, codes, code+"0");
				Next(node.right, codes, code+"1");
			}
		}

		private static Node CreateHuffmanTree(int[] frequency)
		{
			PriorityQueue<Node, int> priorityQueue = new();
			for (int i = 0; i < frequency.Length; i++)
			{
				if (frequency[i] > 0)
					priorityQueue.Enqueue(new Node(frequency[i], (byte)i), frequency[i]);
			}
			while (priorityQueue.Count > 1)
			{
				Node left = priorityQueue.Dequeue();
				Node right = priorityQueue.Dequeue();
				int freq = left.frequency + right.frequency;
				priorityQueue.Enqueue(new Node(freq, left, right), freq);
			}

			return priorityQueue.Dequeue();
		}

		private static int[] CalculateFrequency(byte[] bytes)
		{
			int[] frequency = new int[256];
			foreach (byte b in bytes) frequency[b]++;
			return frequency;
		}
	}
}

using System.Drawing;

namespace Lr6
{
	public class HuffmanTree
	{
		private class Node
		{
			public readonly int freq;
			public readonly byte symbol;
			public readonly Node? left;
			public readonly Node? right;

			public Node(byte symbol, int freq)
			{
				this.symbol = symbol;
				this.freq = freq;
			}
			public Node(Node left, Node right)
			{
				this.freq= left.freq + right.freq;
				this.left = left;
				this.right = right;
			}

		}
		public static void CompressFile(string dataFile, string archFile)
		{
			int[] freqs = new int[256];

			using(FileStream fs = new(dataFile, FileMode.Open))
			{
				var symbol = fs.ReadByte();
				while(symbol != -1)
				{
					
					freqs[symbol]++;
					symbol = fs.ReadByte();
				}
			}
			NormilizeFreqs(freqs);
			ComressBytes(freqs, dataFile, archFile);
		}

		private static void NormilizeFreqs(int[] freqs)
		{
			int max = freqs.Max();
			if (max <= 255) return;
			for (int i = 0; i < 256; i++)
			{
				if (freqs[i] > 0)
				{
					freqs[i] = 1 + (freqs[i] * 255) / (max + 1);
				}
			}
		}

		private static void ComressBytes(int[] freqs, string dataFile, string archFile)
		{
			CreateHeader(freqs, archFile, out int count);
			Node root = CreateHuffmanTree(freqs);
			string[] codes = CreateHuffmanCode(root);
			Compress(dataFile, codes, archFile, count);
		}

		private static void Compress(string dataFile, string[] codes, string archFile, int startIndex)
		{
			byte sum = 0;
			var d = File.ReadAllBytes(dataFile);
			var g = File.ReadAllBytes(archFile);
			startIndex *= 2;
			byte bit = 1;
			using (FileStream fsData = new(dataFile, FileMode.Open, FileAccess.ReadWrite))
			{
				var symbol = fsData.ReadByte();
				using(FileStream fcArch = new(archFile, FileMode.OpenOrCreate, FileAccess.Write))
				{
					fcArch.Position = startIndex+1;

					while (symbol != -1)
					{
						foreach (var code in codes[symbol])
						{
							if (code == '1')
							{
								sum |= bit;
							}
							if (bit == 128)
							{
								fcArch.WriteByte(sum);
								bit = 1;
								sum = 0;
							}
							else
							{
								bit <<= 1;
							}
						}
						symbol = fsData.ReadByte();
					}
				if(bit > 1) fcArch.WriteByte(sum);
				}
			}
			var y = File.ReadAllBytes(archFile);
		}

		private static string[] CreateHuffmanCode(Node root)
		{
			string[] codes = new string[256];
			Next(root, "");
			return codes;
			void Next(Node node, string code)
			{
				if(node.left == null || node.right == null)
				{
					codes[node.symbol] = code;
				}
				else
				{
					Next(node.left, code + "0");
					Next(node.right, code + "1");
				}
			}
		}

		private static Node CreateHuffmanTree(int[] freqs)
		{
			PriorityQueue<Node, int> priorityQueue = new();
			for (int i = 0; i < freqs.Length; i++)
			{
				if (freqs[i] > 0)
					priorityQueue.Enqueue(new((byte)i, freqs[i]), freqs[i]);
			}
			while(priorityQueue.Count > 1)
			{
				Node left = priorityQueue.Dequeue();
				Node right = priorityQueue.Dequeue();
				Node parrent = new(left, right);
				priorityQueue.Enqueue(parrent, parrent.freq);
			}
			return priorityQueue.Dequeue();
		}

		private static void CreateHeader(int[] freqs, string archFile, out int count)
		{
			count = 0;
			using(FileStream fs = new FileStream(archFile, FileMode.OpenOrCreate, FileAccess.Write))
			{
				for (int i = 0; i < freqs.Length; i++) 
				{
						if (freqs[i] > 0)
						{
							fs.WriteByte((byte)i);
							fs.WriteByte((byte)freqs[i]);
							count++;
						}
					}
				}
		}

		public static void DecompressFile(string archFile, string dataFile)
		{
			var arch = File.ReadAllBytes(archFile);
			int[] freqs = new int[256];
			ulong size = 0;

			using (FileStream fs = new(archFile, FileMode.Open, FileAccess.Read))
			{
				var symbol = fs.ReadByte();
				while (symbol != -1)
				{
					freqs[symbol] = fs.ReadByte();
					size += (ulong)freqs[symbol];
					symbol = fs.ReadByte();
				}
			}

			byte[] data = DecomressBytes(arch, size);

			File.WriteAllBytes(dataFile, data);
		}

		private static byte[] DecomressBytes(byte[] arch, ulong size)
		{
			ParseHeader(arch,
				out int startIndex, 
				out int[] freqs);
			Node root = CreateHuffmanTree(freqs);
			byte[] data = Decomress(arch, startIndex, size, root);
			return data;
		}

		private static byte[] Decomress(byte[] arch, int startIndex, ulong dataLength, Node root)
		{
			ulong size = 0;
			Node current = root;
			byte[] data = new byte[dataLength];
			for (int i = startIndex; i < arch.Length; i++)
			{
				for(int bit = 1; bit <= 128; bit <<= 1)
				{
					if ((arch[i] & bit) == 0)
						current = current.left;
					else
						current = current.right;
					if(current.left == null)
					{
						if(size < dataLength) 
							data[size++] = current.symbol;
						current = root;
					}
				}
			}
			return data;
		}

		private static void ParseHeader(byte[] arch, out int startIndex, out int[] freqs)
		{
			freqs = new int[256];
			int count = arch[4];
			if (count == 0) count = 256;
			for(int i = 0; i < count; i++)
			{
				byte symbol = arch[5 + i * 2];
				freqs[symbol] = arch[5 + i * 2 + 1];
			}
			startIndex = 5 + 2 * count;
		}
	}
}

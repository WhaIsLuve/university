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
			int fileSize = 0;

			using(FileStream fs = new(dataFile, FileMode.Open))
			{
				var symbol = fs.ReadByte();
				while(symbol != -1)
				{
					
					freqs[symbol]++;
					symbol = fs.ReadByte();
					fileSize++;
				}
			}
			NormilizeFreqs(freqs);
			ComressBytes(freqs, dataFile, archFile, fileSize);
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

		private static void ComressBytes(int[] freqs, string dataFile, string archFile, int fileSize)
		{
			CreateHeader(freqs, archFile, out int count, fileSize);
			Node root = CreateHuffmanTree(freqs);
			string[] codes = CreateHuffmanCode(root);
			Compress(dataFile, codes, archFile, count);
		}

		private static void Compress(string dataFile, string[] codes, string archFile, int startIndex)
		{
			byte sum = 0;
			byte bit = 1;
			using (FileStream fsData = new(dataFile, FileMode.Open, FileAccess.ReadWrite))
			{
				var symbol = fsData.ReadByte();
				using(FileStream fcArch = new(archFile, FileMode.OpenOrCreate, FileAccess.Write))
				{
					fcArch.Position = startIndex;

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

		private static void CreateHeader(int[] freqs, string archFile, out int count, int fileSize)
		{
			count = 0;
			for (int i = 0; i < freqs.Length; i++)
			{
				if (freqs[i] > 0)
				{
					count++;
				}
			}
			using (FileStream fs = new FileStream(archFile, FileMode.OpenOrCreate, FileAccess.Write))
			{
				fs.WriteByte((byte)(fileSize & 255));
				fs.WriteByte((byte)((fileSize >> 8) & 255));
				fs.WriteByte((byte)((fileSize >> 16) & 255));
				fs.WriteByte((byte)((fileSize >> 24) & 255));
				fs.WriteByte((byte)count);
				count = count * 2 + 5;
				for (int i = 0; i < freqs.Length; i++)
				{
					if (freqs[i] > 0)
					{
						fs.WriteByte((byte)i);
						fs.WriteByte((byte)freqs[i]);
					}
				}
			}
		}

		public static void DecompressFile(string archFile, string dataFile)
		{
			int[] freqs = new int[256];
			int startIndex = 0;
			int countSymbols;
			int size = 0;

			using (FileStream fs = new(archFile, FileMode.Open, FileAccess.Read))
			{
				size = fs.ReadByte() | (fs.ReadByte() << 8) | (fs.ReadByte() << 16) | (fs.ReadByte() << 24);
				countSymbols = fs.ReadByte();
				var symbol = fs.ReadByte();
				while (startIndex != (countSymbols*2))
				{
					freqs[symbol] = fs.ReadByte();
					symbol = fs.ReadByte();
					startIndex += 2;
				}
			}
			startIndex += 5;
			DecomressBytes(freqs, size, startIndex, archFile, dataFile);
		}

		private static void DecomressBytes(int[] freqs, int size, int startIndex, string archFile, string dataFile)
		{
			Node root = CreateHuffmanTree(freqs);
			Decomress(archFile, startIndex, size, root, dataFile);
		}

		private static void Decomress(string archFile, int startIndex, int dataLength, Node root, string dataFile)
		{
			int size = 0;
			Node current = root;
			using(FileStream fsArch = new(archFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
			{
				fsArch.Position = startIndex;
				var code = fsArch.ReadByte();
				using (FileStream fsData = new(dataFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
				{
					while (code != -1) 
					{
						for (int bit = 1; bit <= 128; bit <<= 1)
						{
								if ((code & bit) == 0)
									current = current.left;
								else
									current = current.right;
								if (current.left == null)
								{
									if (size < dataLength)
									{
										fsData.WriteByte(current.symbol);
										size++;
									}
									current = root;
								}
							}
						code = fsArch.ReadByte();
					}
				}
			}
		}
	}
}

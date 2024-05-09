
using System.Text;

namespace HashLr
{
	public class Hash
	{
		private List<double>[] hashTable = new List<double>[5];
		private int countElements = 0;

		public Hash()
		{
			for (int i = 0; i < hashTable.Length; i++) 
			{
				hashTable[i] = new List<double>();
			}
		}

		public void AddA(double value)
		{
			if(hashTable.Length == countElements)
			{
				var tmp = new List<double>[countElements*2];
				for(int i = 0; i < tmp.Length; i++)
				{
					tmp[i] = new();
				}
				foreach(var item in hashTable)
					foreach(var val in item)
						tmp[getHashCodeA(val, tmp)].Add(val);
				hashTable = tmp;
			}
			hashTable[getHashCodeA(value, hashTable)].Add(value);
			countElements++;
		}

		private int getHashCodeA(double value, List<double>[] doubles)
		{
			return (int)((value % (doubles.Length)));
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach(var item in hashTable)
			{
				foreach(var val in item)
					stringBuilder.Append($"{val} ");
				stringBuilder.AppendLine();
			}
			return stringBuilder.ToString();
		}
	}
}

using Lr2;

namespace FrequencyDict
{
	public partial class Form1 : Form
	{
		private string fileName;

		public Form1()
		{
			InitializeComponent();
		}

		private void openFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				fileName = openFileDialog1.FileName;
				filePath.Text = fileName;
			}
		}

		private void printFrequencyByAlphabet_Click(object sender, EventArgs e)
		{
			if (fileName == string.Empty || fileName is null)
			{
				MessageBox.Show("Нужно выбрать файл");
				return;
			}
			BinaryTree binaryTree = new BinaryTree();
			binaryTree.ReadFile(fileName, PrintMode.PrintFrequencyByAlphabet);
			result.Text = File.ReadAllText(binaryTree.resultPathFile);
		}

		private void findWord_Click(object sender, EventArgs e)
		{
			if (fileName == string.Empty || fileName is null)
			{
				MessageBox.Show("Нужно выбрать файл!");
				return;
			}
			if (findfWordText.Text is null || findfWordText.Text == string.Empty)
			{
				MessageBox.Show("Нужно написать слово!");
				return;
			}
			BinaryTree binaryTree = new BinaryTree();
			binaryTree.ReadFile(fileName, PrintMode.FindWord, findfWordText.Text);
			result.Text = File.ReadAllText(binaryTree.resultPathFile);
		}

		private void printFrequencyByLength_Click(object sender, EventArgs e)
		{
			if (fileName == string.Empty || fileName is null)
			{
				MessageBox.Show("Нужно выбрать файл!");
				return;
			}
			if (length.Text is null || length.Text == string.Empty)
			{
				MessageBox.Show("Нужно написать длину!");
				return;
			}
			var isDigit = int.TryParse(length.Text, out int len);
			if (!isDigit)
			{
				MessageBox.Show("Нужно написать число!");
				return;
			}
			BinaryTree binaryTree = new BinaryTree();
			binaryTree.ReadFile(fileName, PrintMode.PrintFrequencyByLength, null, len);
			result.Text = File.ReadAllText(binaryTree.resultPathFile);
		}

		private void printFrequencySorted_Click(object sender, EventArgs e)
		{
			if (fileName == string.Empty || fileName is null)
			{
				MessageBox.Show("Нужно выбрать файл");
				return;
			}
			BinaryTree binaryTree = new BinaryTree();
			binaryTree.ReadFile(fileName, PrintMode.PrintFrequencySorted);
			result.Text = File.ReadAllText(binaryTree.resultPathFile);
		}
	}
}

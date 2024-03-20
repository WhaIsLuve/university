using Lr6;

namespace archiver
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void openDialog_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				inputFile.Text = openFileDialog1.FileName;
			}
		}

		private void Acrchive_Click(object sender, EventArgs e)
		{
			if (inputFile.Text.Length > 0 && saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				HuffmanTree.CompressFile(inputFile.Text, saveFileDialog1.FileName);
			}
		}

		private void decode_Click(object sender, EventArgs e)
		{
			if(saveFileDialog2.ShowDialog() == DialogResult.OK)
			{
				HuffmanTree.DecompressFile(inputFile.Text, saveFileDialog2.FileName);
			}
		}
	}
}

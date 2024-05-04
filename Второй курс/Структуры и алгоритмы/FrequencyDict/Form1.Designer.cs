namespace FrequencyDict
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			result = new TextBox();
			openFile = new Button();
			openFileDialog1 = new OpenFileDialog();
			filePath = new TextBox();
			printFrequencyByAlphabet = new Button();
			label1 = new Label();
			printFrequencySorted = new Button();
			findWord = new Button();
			printFrequencyByLength = new Button();
			findfWordText = new TextBox();
			label2 = new Label();
			label3 = new Label();
			length = new TextBox();
			SuspendLayout();
			// 
			// result
			// 
			result.Location = new Point(777, 29);
			result.Multiline = true;
			result.Name = "result";
			result.ReadOnly = true;
			result.ScrollBars = ScrollBars.Both;
			result.Size = new Size(581, 639);
			result.TabIndex = 0;
			// 
			// openFile
			// 
			openFile.Location = new Point(27, 27);
			openFile.Name = "openFile";
			openFile.Size = new Size(124, 29);
			openFile.TabIndex = 1;
			openFile.Text = "Открыть файл";
			openFile.UseVisualStyleBackColor = true;
			openFile.Click += openFile_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// filePath
			// 
			filePath.Location = new Point(167, 29);
			filePath.Name = "filePath";
			filePath.Size = new Size(363, 27);
			filePath.TabIndex = 2;
			// 
			// printFrequencyByAlphabet
			// 
			printFrequencyByAlphabet.Location = new Point(27, 126);
			printFrequencyByAlphabet.Name = "printFrequencyByAlphabet";
			printFrequencyByAlphabet.Size = new Size(361, 29);
			printFrequencyByAlphabet.TabIndex = 3;
			printFrequencyByAlphabet.Text = "Частотный словарь слов в алфавитном порядке";
			printFrequencyByAlphabet.UseVisualStyleBackColor = true;
			printFrequencyByAlphabet.Click += printFrequencyByAlphabet_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(128, 87);
			label1.Name = "label1";
			label1.Size = new Size(155, 20);
			label1.TabIndex = 4;
			label1.Text = "Выберите обработку";
			// 
			// printFrequencySorted
			// 
			printFrequencySorted.Location = new Point(27, 174);
			printFrequencySorted.Name = "printFrequencySorted";
			printFrequencySorted.Size = new Size(361, 55);
			printFrequencySorted.TabIndex = 5;
			printFrequencySorted.Text = "Частотный словарь слов, отсортированный в порядке частоты их употребления";
			printFrequencySorted.UseVisualStyleBackColor = true;
			printFrequencySorted.Click += printFrequencySorted_Click;
			// 
			// findWord
			// 
			findWord.Location = new Point(27, 248);
			findWord.Name = "findWord";
			findWord.Size = new Size(361, 29);
			findWord.TabIndex = 6;
			findWord.Text = "Поиск заданного слова";
			findWord.UseVisualStyleBackColor = true;
			findWord.Click += findWord_Click;
			// 
			// printFrequencyByLength
			// 
			printFrequencyByLength.Location = new Point(27, 304);
			printFrequencyByLength.Name = "printFrequencyByLength";
			printFrequencyByLength.Size = new Size(361, 29);
			printFrequencyByLength.TabIndex = 7;
			printFrequencyByLength.Text = "Поиск слов по заданной длине";
			printFrequencyByLength.UseVisualStyleBackColor = true;
			printFrequencyByLength.Click += printFrequencyByLength_Click;
			// 
			// findfWordText
			// 
			findfWordText.Location = new Point(424, 250);
			findfWordText.Name = "findfWordText";
			findfWordText.Size = new Size(247, 27);
			findfWordText.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(470, 227);
			label2.Name = "label2";
			label2.Size = new Size(147, 20);
			label2.TabIndex = 9;
			label2.Text = "Какое слово найти?";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(470, 283);
			label3.Name = "label3";
			label3.Size = new Size(157, 20);
			label3.TabIndex = 11;
			label3.Text = "Какая длина у слова?";
			// 
			// length
			// 
			length.Location = new Point(424, 306);
			length.Name = "length";
			length.Size = new Size(247, 27);
			length.TabIndex = 10;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1409, 698);
			Controls.Add(label3);
			Controls.Add(length);
			Controls.Add(label2);
			Controls.Add(findfWordText);
			Controls.Add(printFrequencyByLength);
			Controls.Add(findWord);
			Controls.Add(printFrequencySorted);
			Controls.Add(label1);
			Controls.Add(printFrequencyByAlphabet);
			Controls.Add(filePath);
			Controls.Add(openFile);
			Controls.Add(result);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox result;
		private Button openFile;
		private OpenFileDialog openFileDialog1;
		private TextBox filePath;
		private Button printFrequencyByAlphabet;
		private Label label1;
		private Button printFrequencySorted;
		private Button findWord;
		private Button printFrequencyByLength;
		private TextBox findfWordText;
		private Label label2;
		private Label label3;
		private TextBox length;
	}
}

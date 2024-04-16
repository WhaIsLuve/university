namespace archiver
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
			openDialog = new Button();
			openFileDialog1 = new OpenFileDialog();
			inputFile = new TextBox();
			Acrchive = new Button();
			saveFileDialog1 = new SaveFileDialog();
			decode = new Button();
			saveFileDialog2 = new SaveFileDialog();
			SuspendLayout();
			// 
			// openDialog
			// 
			openDialog.Location = new Point(694, 409);
			openDialog.Name = "openDialog";
			openDialog.Size = new Size(94, 29);
			openDialog.TabIndex = 0;
			openDialog.Text = "Открыть";
			openDialog.UseVisualStyleBackColor = true;
			openDialog.Click += openDialog_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.Filter = "Txt Files|*.txt|Vlad files|*.vlad|BMPFiles|*.bmp";
			// 
			// inputFile
			// 
			inputFile.Location = new Point(27, 21);
			inputFile.Name = "inputFile";
			inputFile.Size = new Size(506, 27);
			inputFile.TabIndex = 1;
			// 
			// Acrchive
			// 
			Acrchive.Location = new Point(570, 21);
			Acrchive.Name = "Acrchive";
			Acrchive.Size = new Size(119, 29);
			Acrchive.TabIndex = 2;
			Acrchive.Text = "Архивировать";
			Acrchive.UseVisualStyleBackColor = true;
			Acrchive.Click += Acrchive_Click;
			// 
			// saveFileDialog1
			// 
			saveFileDialog1.DefaultExt = "vlad";
			saveFileDialog1.InitialDirectory = "C:\\Users\\Влад\\Desktop";
			// 
			// decode
			// 
			decode.Location = new Point(570, 71);
			decode.Name = "decode";
			decode.Size = new Size(119, 29);
			decode.TabIndex = 3;
			decode.Text = "Декодировать";
			decode.UseVisualStyleBackColor = true;
			decode.Click += decode_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(decode);
			Controls.Add(Acrchive);
			Controls.Add(inputFile);
			Controls.Add(openDialog);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button openDialog;
		private OpenFileDialog openFileDialog1;
		private TextBox inputFile;
		private Button Acrchive;
		private SaveFileDialog saveFileDialog1;
		private Button decode;
		private SaveFileDialog saveFileDialog2;
	}
}

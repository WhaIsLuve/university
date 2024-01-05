#pragma once

namespace lr2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// —водка дл€ MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// ќсвободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^ textBox1;
	protected:
	private: System::Windows::Forms::Button^ genarate;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ result;

	private:
		/// <summary>
		/// ќб€зательна€ переменна€ конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// “ребуемый метод дл€ поддержки конструктора Ч не измен€йте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->genarate = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->result = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(270, 162);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(506, 22);
			this->textBox1->TabIndex = 0;
			// 
			// genarate
			// 
			this->genarate->Location = System::Drawing::Point(507, 255);
			this->genarate->Name = L"genarate";
			this->genarate->Size = System::Drawing::Size(75, 23);
			this->genarate->TabIndex = 1;
			this->genarate->Text = L"Find";
			this->genarate->UseVisualStyleBackColor = true;
			this->genarate->Click += gcnew System::EventHandler(this, &MyForm::genarate_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(447, 123);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(207, 16);
			this->label1->TabIndex = 2;
			this->label1->Text = L"¬ведите слова через зап€тую";
			// 
			// result
			// 
			this->result->AutoSize = true;
			this->result->Location = System::Drawing::Point(357, 343);
			this->result->Name = L"result";
			this->result->Size = System::Drawing::Size(0, 16);
			this->result->TabIndex = 3;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1086, 517);
			this->Controls->Add(this->result);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->genarate);
			this->Controls->Add(this->textBox1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void genarate_Click(System::Object^ sender, System::EventArgs^ e) {
		auto array = this->textBox1->Text->Split(',');
		this->result->Text = "";
		for (int i = 0; i < array->Length; i++)
		{
			if (array[i]->EndsWith("w")) {
				this->result->Text += array[i];
				if (i != array->Length - 1) {
					this->result->Text += "\n";
				}
			}
		}
	}
	};
}

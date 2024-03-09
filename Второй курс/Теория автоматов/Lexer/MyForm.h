#pragma once
#include "States.cpp"

namespace Lexer {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для MyForm
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
		/// Освободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^ input;
	protected:
	private: System::Windows::Forms::TextBox^ result;
	private: System::Windows::Forms::Button^ startProcessing;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;

	private:
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->input = (gcnew System::Windows::Forms::TextBox());
			this->result = (gcnew System::Windows::Forms::TextBox());
			this->startProcessing = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// input
			// 
			this->input->Location = System::Drawing::Point(12, 31);
			this->input->Multiline = true;
			this->input->Name = L"input";
			this->input->Size = System::Drawing::Size(535, 511);
			this->input->TabIndex = 0;
			// 
			// result
			// 
			this->result->Location = System::Drawing::Point(697, 31);
			this->result->Multiline = true;
			this->result->Name = L"result";
			this->result->ReadOnly = true;
			this->result->Size = System::Drawing::Size(553, 511);
			this->result->TabIndex = 1;
			// 
			// startProcessing
			// 
			this->startProcessing->Location = System::Drawing::Point(45, 560);
			this->startProcessing->Name = L"startProcessing";
			this->startProcessing->Size = System::Drawing::Size(112, 61);
			this->startProcessing->TabIndex = 2;
			this->startProcessing->Text = L"Начать";
			this->startProcessing->UseVisualStyleBackColor = true;
			this->startProcessing->Click += gcnew System::EventHandler(this, &MyForm::startProcessing_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(83, 9);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(89, 16);
			this->label1->TabIndex = 3;
			this->label1->Text = L"Введите код";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(917, 9);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(77, 16);
			this->label2->TabIndex = 4;
			this->label2->Text = L"Результат";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::HotTrack;
			this->ClientSize = System::Drawing::Size(1262, 656);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->startProcessing);
			this->Controls->Add(this->result);
			this->Controls->Add(this->input);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: States currentState = States::S1;
	private: System::Void startProcessing_Click(System::Object^ sender, System::EventArgs^ e) {
		this->result->Text = "";
		for (int i = 0; i < this->input->Text->Length; i++) {
			switch (currentState) {
			case States::S0:
				if (this->input->Text == "/") {
					currentState = States::S1;
				}
				else if (this->input->Text == " ") {
					currentState = States::S5;
				}
				else if (this->input->Text == "\t") {
					currentState = States::S6;
				}
				else if (this->input->Text == "\r") {
					currentState = States::S7;
				}
				else {
					this->result->Text += this->input->Text[i];
				}
				break;
			case States::S1:
				if (this->input->Text == "/") {
					currentState = States::S2;
				}
				else if (this->input->Text == "*") {
					currentState = States::S3;
				}
				break;
			case States::S2:
				if (this->input->Text == "\n") {
					this->result->Text += "\r\n";
					currentState = States::S0;
				}
				break;
			case States::S3:
				break;
			case States::S4:
				break;
			case States::S5:
				break;
			case States::S6:
				break;
			case States::S7:
				break;
			}
		}
	}
	};
	};

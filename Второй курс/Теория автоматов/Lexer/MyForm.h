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
	/// ������ ��� MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: �������� ��� ������������
			//
		}

	protected:
		/// <summary>
		/// ���������� ��� ������������ �������.
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
		/// ������������ ���������� ������������.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// ��������� ����� ��� ��������� ������������ � �� ��������� 
		/// ���������� ����� ������ � ������� ��������� ����.
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
			this->input->Location = System::Drawing::Point(9, 25);
			this->input->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->input->Multiline = true;
			this->input->Name = L"input";
			this->input->Size = System::Drawing::Size(402, 416);
			this->input->TabIndex = 0;
			// 
			// result
			// 
			this->result->Location = System::Drawing::Point(523, 25);
			this->result->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->result->Multiline = true;
			this->result->Name = L"result";
			this->result->ReadOnly = true;
			this->result->Size = System::Drawing::Size(416, 416);
			this->result->TabIndex = 1;
			// 
			// startProcessing
			// 
			this->startProcessing->Location = System::Drawing::Point(34, 455);
			this->startProcessing->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->startProcessing->Name = L"startProcessing";
			this->startProcessing->Size = System::Drawing::Size(84, 50);
			this->startProcessing->TabIndex = 2;
			this->startProcessing->Text = L"start";
			this->startProcessing->UseVisualStyleBackColor = true;
			this->startProcessing->Click += gcnew System::EventHandler(this, &MyForm::startProcessing_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(62, 7);
			this->label1->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(30, 13);
			this->label1->TabIndex = 3;
			this->label1->Text = L"input";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(688, 7);
			this->label2->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(32, 13);
			this->label2->TabIndex = 4;
			this->label2->Text = L"result";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::HotTrack;
			this->ClientSize = System::Drawing::Size(946, 533);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->startProcessing);
			this->Controls->Add(this->result);
			this->Controls->Add(this->input);
			this->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: States currentState = States::S0;
	private: System::Void startProcessing_Click(System::Object^ sender, System::EventArgs^ e) {
		this->result->Text = "";
		String^ str = "";
		currentState = States::S0;
		for (int i = 0; i < this->input->Text->Length; i++) {
			switch (currentState) {
			case States::S0:
				if (this->input->Text[i] == '/') {
					currentState = States::S1;
				}
				else if (this->input->Text[i] == ' ') {
					currentState = States::S5;
				}
				else if (this->input->Text[i] ==  '\t') {
					currentState = States::S6;
				}
				else if (this->input->Text[i] == '\n') {
					str += this->input->Text[i];
					currentState = States::S7;
				}
				else {
					str += this->input->Text[i];
				}
				break;
			case States::S1:
				if (this->input->Text[i] == '/') {
					currentState = States::S2;
				}
				else if (this->input->Text[i] == '*') {
					currentState = States::S3;
				}
				else {
					str +=  "/" + this->input->Text[i];
					currentState = States::S0;
				}
				break;
			case States::S2:
				if (this->input->Text[i] == '\n') {
					str += "\r\n";
					currentState = States::S0;
				}
				break;
			case States::S3:
				if (this->input->Text[i] == '*') {
					currentState = States::S4;
				}
				break;
			case States::S4:
				if (this->input->Text[i] == '/') {
					currentState = States::S0;
				}
				else {
					currentState = States::S3;
				}
				break;
			case States::S5:
				if (this->input->Text[i] == '/') {
					currentState = States::S1;
				}
				else if (this->input->Text[i] != ' ') {
					currentState = States::S0;
					str += " ";
					str += this->input->Text[i];
				}
				break;
			case States::S6:
				if (this->input->Text[i] == '/') {
					currentState = States::S1;
				}
				else if (this->input->Text[i] != '\t') {
					currentState = States::S0;
					str += this->input->Text[i];
				}
				break;
			case States::S7:
				if (this->input->Text[i] == '\n' || this->input->Text[i] == '\r') {
					currentState = States::S7;
				}
				else if (this->input->Text[i] == '/')
					currentState = States::S1;
				else if (this->input->Text[i] == '\t') {
					currentState = States::S6;
				}
				else if (this->input->Text[i] == ' ') {
					currentState = States::S5;
				}
				else {
					str += this->input->Text[i];
					currentState = States::S0;
				}
				break;
			}
		}
		int numberString = 1;
		for (int i = 0; i < str->Length; i++) {
			if (i == 0) {
				this->result->Text += numberString.ToString() + " " + str[i];
				numberString++;
			}
			else if (str[i] == '\n') {
				this->result->Text += str[i] + numberString.ToString() + " ";
				numberString++;
			}
			else {
				this->result->Text += str[i];
			}
		}
	}
	};
	};

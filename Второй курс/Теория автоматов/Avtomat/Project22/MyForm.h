#pragma once
#include <set>

namespace Project22 {

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
	private: System::Windows::Forms::Button^ button1;
	protected:
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
		   enum class State { S0, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16, S17, S18, S19, S20, S21, S22, S23, S24, S25, S26, S27, S28, S29, S30, S31, S32, S33, S34, S35, S36, S37};
	private: State currentState = State::S0;


	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::DataGridView^ dataGridView1;
	private: System::Windows::Forms::DataGridView^ dataGridView2;


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
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->dataGridView2 = (gcnew System::Windows::Forms::DataGridView());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->BeginInit();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(357, 165);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(98, 32);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Обработать";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(12, 45);
			this->textBox1->Multiline = true;
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(339, 412);
			this->textBox1->TabIndex = 1;
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(480, 45);
			this->textBox2->Multiline = true;
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(348, 412);
			this->textBox2->TabIndex = 2;
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(357, 216);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(98, 28);
			this->button2->TabIndex = 3;
			this->button2->Text = L"Очистить";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(13, 26);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(79, 13);
			this->label1->TabIndex = 4;
			this->label1->Text = L"Исходный код";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(489, 29);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(103, 13);
			this->label2->TabIndex = 5;
			this->label2->Text = L"Обработанный код";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(939, 26);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(92, 13);
			this->label3->TabIndex = 8;
			this->label3->Text = L"Ключевые слова";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(1172, 29);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(121, 13);
			this->label4->TabIndex = 9;
			this->label4->Text = L"Операторы сравнения";
			// 
			// dataGridView1
			// 
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Location = System::Drawing::Point(942, 45);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->Size = System::Drawing::Size(199, 152);
			this->dataGridView1->TabIndex = 10;
			// 
			// dataGridView2
			// 
			this->dataGridView2->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView2->Location = System::Drawing::Point(1175, 45);
			this->dataGridView2->Name = L"dataGridView2";
			this->dataGridView2->Size = System::Drawing::Size(198, 152);
			this->dataGridView2->TabIndex = 11;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1395, 603);
			this->Controls->Add(this->dataGridView2);
			this->Controls->Add(this->dataGridView1);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion


	private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {
		textBox1->Clear();
		textBox2->Clear();
	}
	void Processing(){
		this->textBox2->Text = "";
		String^ str = "";
		currentState = State::S0;
		for (int i = 0; i < this->textBox1->Text->Length; i++) {
			wchar_t X = this->textBox1->Text[i];
			switch (currentState) {
			case State::S0:
				if (X == '/') {
					currentState = State::S1;
				}
				else if (X == ' ') {
					currentState = State::S5;
				}
				else if (X == '\t') {
					currentState = State::S6;
				}
				else if (X == '\n') {
					str += X;
					currentState = State::S7;
				}
				else {
					str += X;
				}
				break;
			case State::S1:
				if (X == '/') {
					currentState = State::S2;
				}
				else if (X == '*') {
					currentState = State::S3;
				}
				else {
					str += "/" + X;
					currentState = State::S0;
				}
				break;
			case State::S2:
				if (X == '\n') {
					str += "\r";
					currentState = State::S0;
				}
				break;

			case State::S3:
				if (X == '*') {
					currentState = State::S4;
				}

				break;
			case State::S4:
				if (X == '/') {
					currentState = State::S2;
				}
				else {
					currentState = State::S3;
				}
				break;
			case State::S5:
				if (X == '/') {
					currentState = State::S1;
				}
				else if (X != ' ') {
					currentState = State::S0;
					str += " ";
					str += X;
				}
				break;
			case State::S6:
				if (X == '/') {
					currentState = State::S1;
				}
				else if (X != '\t') {
					currentState = State::S0;
					str += X;
				};
				break;
			case State::S7:
				if (X == '\n' || X == '\r') {
					currentState = State::S7;
				}
				else if (X == '/')
					currentState = State::S1;
				else if (X == '\t') {
					currentState = State::S6;
				}
				else if (X == ' ') {
					currentState = State::S5;
				}
				else {
					str += X;
					currentState = State::S0;
				}
				break;
			}
		}
		int numberString = 1;
		for (int i = 0; i < str->Length; i++) {
			if (i == 0) {
				this->textBox2->Text += numberString.ToString() + ") " + str[i];
				numberString++;
			}
			else if (str[i] == '\n') {
				this->textBox2->Text += str[i] + numberString.ToString() + ") ";
				numberString++;
			}
			else {
				this->textBox2->Text += str[i];
			}
		}
	}
	void Recognition() {
		this->dataGridView1->Rows->Clear();
		this->dataGridView2->Rows->Clear();
		String^ displayedWords = "";
		String^ displayedRelations = "";
		DataGridViewColumn^ relationColumn = dataGridView2->Columns["RelationColumn"];
		State currentState = State::S0;
		String^ str = "";

		if (this->dataGridView1->Columns->Count == 0) {
			this->dataGridView1->Columns->Add("NumColumn", "Num");
			this->dataGridView1->Columns->Add("WordColumn", "Word");
			this->dataGridView1->Columns->Add("PsevdoColumn", "Psevdo");
		}
		if (this->dataGridView2->Columns->Count == 0) {
			this->dataGridView2->Columns->Add("NumColumn", "Num");
			this->dataGridView2->Columns->Add("RelationColumn", "Relation");
			this->dataGridView2->Columns->Add("PsevdoColumn", "Psevdo");
		}
		int rowIndex1 = 0; 
		int rowIndex2 = 0;
		for (int i = 0; i < this->textBox2->Text->Length; i++) {
			wchar_t X = this->textBox2->Text[i];
			switch (currentState) {
			case State::S0:
				if (X == 'i') {
					currentState = State::S1;
					str += "i";
				}
				else if (X == 's') {
					currentState = State::S3;
					str += "s";
				}
				else if (X == 'w') {
					currentState = State::S8;
					str += "w";
				}
				else if (X == 'f') {
					currentState = State::S12;
					str += "f";
				}
				else if (X == 'e') {
					currentState = State::S14;
					str += "e";
				}
				else if (X == 'b') {
					currentState = State::S17;
					str += "b";
				}
				else if (X == 'c') {
					currentState = State::S21;
					str += "c";
				}
				else if (X == '<' && this->textBox2->Text[i + 1] != ' ') {
					currentState = State::S31;
					str += "<";
				}
				else if (X == '<' && this->textBox2->Text[i + 1] == ' ') {
					currentState = State::S32;
					str += "<";
				}
				else if (X == '>' && this->textBox2->Text[i + 1] != ' ') {
					currentState = State::S31;
					str += ">";
				}
				else if (X == '>' && this->textBox2->Text[i + 1] == ' ') {
					currentState = State::S32;
					str += ">";
				}
				else if (X == '!') {
					currentState = State::S29;
					str += "!";
				}
				else if (X == '=') {
					currentState = State::S28;
					str += "=";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;

			case State::S1:
				if (X == 'f') {
					currentState = State::S27;
					str += "f";
				}
				else if (X == 'n') {
					currentState = State::S2;
					str += "n";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S2:
				if (X == 't') {
					currentState = State::S27;
					str += "t";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S3:
				if (X == 'w'){ 
					currentState = State::S4; 
					str += "w";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S4:
				if (X == 'i') {
					currentState = State::S5;
					str += "i";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S5:
				if (X == 't') {
					currentState = State::S6;
					str += "t";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S6:
				if (X == 'c') {
					currentState = State::S7;
					str += "c";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S7:
				if (X == 'h') {
					currentState = State::S27;
					str += "h";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S8:
				if (X == 'h') {
					currentState = State::S9;
					str += "h";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S9:
				if (X == 'i') {
					currentState = State::S10;
					str += "i";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S10:
				if (X == 'l') {
					currentState = State::S11;
					str += "l";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S11:
				if (X == 'e') {
					currentState = State::S27;
					str += "e";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S12:
				if (X == 'o') {
					currentState = State::S13;
					str += "o";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S13:
				if (X == 'r') {
					currentState = State::S27;
					str += "r";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S14:
				if (X == 'l') {
					currentState = State::S15;
					str += "l";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S15:
				if (X == 's') {
					currentState = State::S16;
					str += "s";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S16:
				if (X == 'e') {
					currentState = State::S27;
					str += "e";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S17:
				if (X == 'r	') {
					currentState = State::S18;
					str += "r";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S18:	
				if (X == 'e') {
					currentState = State::S19;
					str += "e";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S19:
				if (X == 'a') {
					currentState = State::S20;
					str += "a";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S20:
				if (X == 'k') {
					currentState = State::S27;
					str += "k";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S21:
				if (X == 'i') {
					currentState = State::S22;
					str += "i";
				}
				else if (X == 'o') {
					currentState = State::S23;
					str += "o";
				}
				else if (X == 'a') {
					currentState = State::S25;
					str += "a";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S22:
				if (X == 'n') {
					currentState = State::S27;
					str += "n";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S23:
				if (X == 'u') {
					currentState = State::S24;
					str += "u";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S24:
				if (X == 't') {
					currentState = State::S27;
					str += "t";
				}
				else {
					currentState = State::S0;
					str = "";
				}	
				break;
			case State::S25:
				if (X == 's') {
					currentState = State::S26;
					str += "s";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S26:
				if (X == 'e') {
					currentState = State::S27;
					str += "e";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S28:
				if (X == '=') {
					currentState = State::S32;
					str += "=";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S29:
				if (X == '=') {
					currentState = State::S32;
					str += "=";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S30:
				if (X == '=') {
					currentState = State::S32;
					str += "=";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			case State::S31:
				if (X == '=') {
					currentState = State::S32;
					str += "=";
				}
				else {
					currentState = State::S0;
					str = "";
				}
				break;
			}
			if (currentState == State::S32 && displayedRelations->IndexOf(str) == -1) {
				rowIndex2 = dataGridView2->Rows->Add();
				if (rowIndex2 >= 0 && rowIndex2 < dataGridView2->Rows->Count) {
					this->dataGridView2->Rows[rowIndex2]->Cells["NumColumn"]->Value = rowIndex2 + 1;
					dataGridView2->Rows[rowIndex2]->Cells["RelationColumn"]->Value = str;
					dataGridView2->Rows[rowIndex2]->Cells["PsevdoColumn"]->Value = str;
					displayedRelations += str + " ";
				}
			}

			if (currentState == State::S27 || currentState == State::S32) {
				if (currentState == State::S27 && displayedWords->IndexOf(str) == -1) {
					rowIndex1 = this->dataGridView1->Rows->Add(); 
					if (rowIndex1 >= 0 && rowIndex1 < this->dataGridView1->Rows->Count) {
						this->dataGridView1->Rows[rowIndex1]->Cells["NumColumn"]->Value = rowIndex1 + 1;
						this->dataGridView1->Rows[rowIndex1]->Cells["WordColumn"]->Value = str;
						this->dataGridView1->Rows[rowIndex1]->Cells["PsevdoColumn"]->Value = str;
						displayedWords += str + " ";
					}
				}
				str = "";
				currentState = State::S0;
			}
	}
}

	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		Processing();
		Recognition();
	}


};
	}

/*
#include <iostream>

	int main() {
		int choice;

		// Используем оператор switch для выполнения выбранного действия
		switch (choice) {
		case 1:
			std::cout << "Привет мир!\n";
			break;
		case 2:
			std::cout << "Прощай, мир!\n";
			break;
		case 3:
			std::cout << "Пока, мир!\n";
			break;
		default:
			std::cout << "Неправильный выбор!\n";
		}

		// Используем цикл for для вывода чисел от 1 до 10
		std::cout << "Числа от 1 до 10:\n";
		for (int i = 1; i <= 10; ++i) {
			std::cout << i << " ";
		}
		std::cout << std::endl;

		return 0;
	}*/
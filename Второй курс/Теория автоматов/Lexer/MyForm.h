#pragma once
#include "LexerStates.cpp"
#include "KeyWordStates.cpp"
#include <set>

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
	private: System::Windows::Forms::DataGridView^ keyWordsTable;

	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Id;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ KeyWord;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Pseudocode;
	private: System::Windows::Forms::Label^ label3;

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
			this->keyWordsTable = (gcnew System::Windows::Forms::DataGridView());
			this->Id = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->KeyWord = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Pseudocode = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->label3 = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->keyWordsTable))->BeginInit();
			this->SuspendLayout();
			// 
			// input
			// 
			this->input->Location = System::Drawing::Point(12, 31);
			this->input->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->input->Multiline = true;
			this->input->Name = L"input";
			this->input->Size = System::Drawing::Size(535, 511);
			this->input->TabIndex = 0;
			// 
			// result
			// 
			this->result->Location = System::Drawing::Point(697, 31);
			this->result->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->result->Multiline = true;
			this->result->Name = L"result";
			this->result->ReadOnly = true;
			this->result->Size = System::Drawing::Size(553, 511);
			this->result->TabIndex = 1;
			// 
			// startProcessing
			// 
			this->startProcessing->Location = System::Drawing::Point(45, 560);
			this->startProcessing->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->startProcessing->Name = L"startProcessing";
			this->startProcessing->Size = System::Drawing::Size(112, 62);
			this->startProcessing->TabIndex = 2;
			this->startProcessing->Text = L"start";
			this->startProcessing->UseVisualStyleBackColor = true;
			this->startProcessing->Click += gcnew System::EventHandler(this, &MyForm::startProcessing_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(83, 9);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(35, 16);
			this->label1->TabIndex = 3;
			this->label1->Text = L"input";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(917, 9);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(39, 16);
			this->label2->TabIndex = 4;
			this->label2->Text = L"result";
			// 
			// keyWordsTable
			// 
			this->keyWordsTable->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->keyWordsTable->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(3) {
				this->Id, this->KeyWord,
					this->Pseudocode
			});
			this->keyWordsTable->Location = System::Drawing::Point(1279, 31);
			this->keyWordsTable->Name = L"keyWordsTable";
			this->keyWordsTable->RowHeadersWidth = 51;
			this->keyWordsTable->RowTemplate->Height = 24;
			this->keyWordsTable->Size = System::Drawing::Size(549, 175);
			this->keyWordsTable->TabIndex = 5;
			// 
			// Id
			// 
			this->Id->HeaderText = L"Id";
			this->Id->MinimumWidth = 6;
			this->Id->Name = L"Id";
			this->Id->Width = 125;
			// 
			// KeyWord
			// 
			this->KeyWord->HeaderText = L"KeyWord";
			this->KeyWord->MinimumWidth = 6;
			this->KeyWord->Name = L"KeyWord";
			this->KeyWord->Width = 125;
			// 
			// Pseudocode
			// 
			this->Pseudocode->HeaderText = L"Pseudocode";
			this->Pseudocode->MinimumWidth = 6;
			this->Pseudocode->Name = L"Pseudocode";
			this->Pseudocode->Width = 125;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(1386, 9);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(63, 16);
			this->label3->TabIndex = 6;
			this->label3->Text = L"KeyWord";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::HotTrack;
			this->ClientSize = System::Drawing::Size(1895, 656);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->keyWordsTable);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->startProcessing);
			this->Controls->Add(this->result);
			this->Controls->Add(this->input);
			this->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->keyWordsTable))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: LexerStates currentLexerState = LexerStates::S0;
	private: KeyWordStates currentsKeyWordState = KeyWordStates::S1;
	private: System::Void startProcessing_Click(System::Object^ sender, System::EventArgs^ e) {
		LexerAnalyze();
		ReadingKeyWords();
	}

	private: void ReadingKeyWords() {
		keyWordsTable->Rows->Clear();
		keyWordsTable->RowCount = 60;
		currentsKeyWordState = KeyWordStates::S1;
		String^ str = this->result->Text;
		String^ keyWord = "";
		int keyWordIndex = 0;
		for(int i = 0; i < str->Length; i++) {
			switch (currentsKeyWordState)
			{
			case KeyWordStates::S1:
				if (str[i] == 'i') {
					currentsKeyWordState = KeyWordStates::S2;
					keyWord += str[i];
				}
				if (str[i] == 'f') {
					currentsKeyWordState = KeyWordStates::S5;
					keyWord += str[i];
				}
				if (str[i] == 's') {
					currentsKeyWordState = KeyWordStates::S7;
					keyWord += str[i];
				}
				if (str[i] == 'e') {
					currentsKeyWordState = KeyWordStates::S12;
					keyWord += str[i];
				}
				break;
			case KeyWordStates::S2:
				if (str[i] == 'f') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S3;
				}
				if (str[i] == 'n') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S4;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S4:
				if (str[i] == 't') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S3;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S5:
				if (str[i] == 'o') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S6;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S6:
				if (str[i] == 'r') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S3;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S7:
				if (str[i] == 't') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S8;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S8:
				if (str[i] == 'r') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S9;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S9:
				if (str[i] == 'i') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S10;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S10:
				if (str[i] == 'n') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S11;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S11:
				if (str[i] == 'g') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S3;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S12:
				if (str[i] == 'l') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S13;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S13:
				if (str[i] == 's') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S14;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			case KeyWordStates::S14:
				if (str[i] == 'e') {
					keyWord += str[i];
					currentsKeyWordState = KeyWordStates::S3;
				}
				else{ currentsKeyWordState = KeyWordStates::S1; keyWord = "";}
				break;
			default:
				break;
			}
			if (currentsKeyWordState == KeyWordStates::S3) {
				if(i + 1 != str->Length) {
					if (isNextSplit(str[i + 1]) && isContainInTable(keyWord) && isWordNext(str[i+1])) {
						keyWordsTable->Rows[keyWordIndex]->Cells[0]->Value = keyWordIndex + 1;
						keyWordsTable->Rows[keyWordIndex]->Cells[1]->Value = keyWord;
						keyWordsTable->Rows[keyWordIndex]->Cells[2]->Value = keyWord;
						keyWordIndex++;
					}
				}
				else {
					if (isContainInTable(keyWord)) {
						keyWordsTable->Rows[keyWordIndex]->Cells[0]->Value = keyWordIndex + 1;
						keyWordsTable->Rows[keyWordIndex]->Cells[1]->Value = keyWord;
						keyWordsTable->Rows[keyWordIndex]->Cells[2]->Value = keyWord;
						keyWordIndex++;
					}
				}
				keyWord = "";
				currentsKeyWordState = KeyWordStates::S1;
			}
		}
	}
	private: bool isWordNext(char ch) {
		std::set<char> st = { ' ', '(', ')', '[', ']', '{', '}', ':', '\r', '\n', '\t' };
		bool bl = st.count(ch);
		return !bl;
	}
	private: bool isNextSplit(char ch) {
		std::set<char> st = { ' ', '(', ')', '[', ']', '{', '}', ':', '\r', '\n', '\t'};
		bool bl = st.count(ch);
		return bl;
   }
	private: bool isContainInTable(String^ keyWord) {
		for (int i = 0; i < keyWordsTable->Rows->Count; i++) {
			if (keyWordsTable->Rows[i]->Cells[1]->Value == nullptr) return true;
			if (keyWordsTable->Rows[i]->Cells[1]->Value->ToString() == keyWord) return false;
		}
		return true;
	}
	private: void LexerAnalyze() {
		this->result->Text = "";
		String^ str = "";
		currentLexerState = LexerStates::S0;
		for (int i = 0; i < this->input->Text->Length; i++) {
			switch (currentLexerState) {
			case LexerStates::S0:
				if (this->input->Text[i] == '/') {
					currentLexerState = LexerStates::S1;
				}
				else if (this->input->Text[i] == ' ') {
					currentLexerState = LexerStates::S5;
				}
				else if (this->input->Text[i] == '\t') {
					currentLexerState = LexerStates::S6;
				}
				else if (this->input->Text[i] == '\n') {
					str += this->input->Text[i];
					currentLexerState = LexerStates::S7;
				}
				else {
					str += this->input->Text[i];
				}
				break;
			case LexerStates::S1:
				if (this->input->Text[i] == '/') {
					currentLexerState = LexerStates::S2;
				}
				else if (this->input->Text[i] == '*') {
					currentLexerState = LexerStates::S3;
				}
				else {
					str += "/" + this->input->Text[i];
					currentLexerState = LexerStates::S0;
				}
				break;
			case LexerStates::S2:
				if (this->input->Text[i] == '\n') {
					str += "\r\n";
					currentLexerState = LexerStates::S0;
				}
				break;
			case LexerStates::S3:
				if (this->input->Text[i] == '*') {
					currentLexerState = LexerStates::S4;
				}
				break;
			case LexerStates::S4:
				if (this->input->Text[i] == '/') {
					currentLexerState = LexerStates::S0;
				}
				else {
					currentLexerState = LexerStates::S3;
				}
				break;
			case LexerStates::S5:
				if (this->input->Text[i] == '/') {
					currentLexerState = LexerStates::S1;
				}
				else if (this->input->Text[i] != ' ') {
					currentLexerState = LexerStates::S0;
					str += " ";
					str += this->input->Text[i];
				}
				break;
			case LexerStates::S6:
				if (this->input->Text[i] == '/') {
					currentLexerState = LexerStates::S1;
				}
				else if (this->input->Text[i] != '\t') {
					currentLexerState = LexerStates::S0;
					str += this->input->Text[i];
				}
				break;
			case LexerStates::S7:
				if (this->input->Text[i] == '\n' || this->input->Text[i] == '\r') {
					currentLexerState = LexerStates::S7;
				}
				else if (this->input->Text[i] == '/')
					currentLexerState = LexerStates::S1;
				else if (this->input->Text[i] == '\t') {
					currentLexerState = LexerStates::S6;
				}
				else if (this->input->Text[i] == ' ') {
					currentLexerState = LexerStates::S5;
				}
				else {
					str += this->input->Text[i];
					currentLexerState = LexerStates::S0;
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

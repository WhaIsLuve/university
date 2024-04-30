#pragma once
#include "LexerStates.cpp"
#include "KeyWordAndRelationsSignsStates.cpp"
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
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::DataGridView^ relationsSignsTable;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ dataGridViewTextBoxColumn1;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ RelationsSigns;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ dataGridViewTextBoxColumn3;

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
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->relationsSignsTable = (gcnew System::Windows::Forms::DataGridView());
			this->dataGridViewTextBoxColumn1 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->RelationsSigns = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->dataGridViewTextBoxColumn3 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->keyWordsTable))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->relationsSignsTable))->BeginInit();
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
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(1386, 220);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(98, 16);
			this->label4->TabIndex = 8;
			this->label4->Text = L"RelationsSigns";
			// 
			// relationsSignsTable
			// 
			this->relationsSignsTable->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->relationsSignsTable->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(3) {
				this->dataGridViewTextBoxColumn1,
					this->RelationsSigns, this->dataGridViewTextBoxColumn3
			});
			this->relationsSignsTable->Location = System::Drawing::Point(1279, 242);
			this->relationsSignsTable->Name = L"relationsSignsTable";
			this->relationsSignsTable->RowHeadersWidth = 51;
			this->relationsSignsTable->RowTemplate->Height = 24;
			this->relationsSignsTable->Size = System::Drawing::Size(549, 175);
			this->relationsSignsTable->TabIndex = 7;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this->dataGridViewTextBoxColumn1->HeaderText = L"Id";
			this->dataGridViewTextBoxColumn1->MinimumWidth = 6;
			this->dataGridViewTextBoxColumn1->Name = L"dataGridViewTextBoxColumn1";
			this->dataGridViewTextBoxColumn1->Width = 125;
			// 
			// RelationsSigns
			// 
			this->RelationsSigns->HeaderText = L"RelationsSigns";
			this->RelationsSigns->MinimumWidth = 6;
			this->RelationsSigns->Name = L"RelationsSigns";
			this->RelationsSigns->Width = 125;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this->dataGridViewTextBoxColumn3->HeaderText = L"Pseudocode";
			this->dataGridViewTextBoxColumn3->MinimumWidth = 6;
			this->dataGridViewTextBoxColumn3->Name = L"dataGridViewTextBoxColumn3";
			this->dataGridViewTextBoxColumn3->Width = 125;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::HotTrack;
			this->ClientSize = System::Drawing::Size(1895, 656);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->relationsSignsTable);
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
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->relationsSignsTable))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: LexerStates currentLexerState = LexerStates::S0;
	private: KeyWordAndRelationsSignsStates currentsKeyWordState = KeyWordAndRelationsSignsStates::S1;
	private: System::Void startProcessing_Click(System::Object^ sender, System::EventArgs^ e) {
		LexerAnalyze();
		ReadingKeyWords();
	}

	private: void ReadingKeyWords() {
		keyWordsTable->Rows->Clear();
		keyWordsTable->RowCount = 60;
		relationsSignsTable->Rows->Clear();
		relationsSignsTable->RowCount = 15;
		currentsKeyWordState = KeyWordAndRelationsSignsStates::S1;
		String^ str = this->result->Text;
		String^ word = "";
		int keyWordIndex = 0;
		int relationsSignsIndex = 0;
		for(int i = 0; i < str->Length; i++) {
			switch (currentsKeyWordState)
			{
			case KeyWordAndRelationsSignsStates::S1:
				if (str[i] == 'i' && isNewWord(str, i)) {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S2;
					word += str[i];
				}
				else if (str[i] == 'f' && isNewWord(str, i)) {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S5;
					word += str[i];
				}
				else if (str[i] == 's' && isNewWord(str, i)) {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S7;
					word += str[i];
				}
				else if (str[i] == 'e' && isNewWord(str, i)) {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S12;
					word += str[i];
				}
				else if (str[i] == 'r' && isNewWord(str, i)) {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S19;
					word += str[i];
				}
				else if (str[i] == 'w' && isNewWord(str, i)) {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S24;
					word += str[i];
				}
				else if (str[i] == 'c' && isNewWord(str, i)) {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S31;
					word += str[i];
				}
				else if (str[i] == '=') {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S34;
					word += str[i];
				}
				else if (str[i] == '>') {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S36;
					word += str[i];
				}
				else if (str[i] == '<') {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S37;
					word += str[i];
				}
				else if (str[i] == '!') {
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S38;
					word += str[i];
				}
				break;
			case KeyWordAndRelationsSignsStates::S2:
				if (str[i] == 'f') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S3;
				}
				else if (str[i] == 'n') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S4;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S4:
				if (str[i] == 't') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S3;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S5:
				if (str[i] == 'o') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S6;
				}
				else if (str[i] == 'l') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S28;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S6:
				if (str[i] == 'r') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S3;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S7:
				if (str[i] == 't') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S8;
				}
				else if (str[i] == 'w') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S15;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S8:
				if (str[i] == 'r') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S9;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S9:
				if (str[i] == 'i') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S10;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S10:
				if (str[i] == 'n') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S11;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S11:
				if (str[i] == 'g') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S3;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S12:
				if (str[i] == 'l') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S13;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S13:
				if (str[i] == 's') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S14;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S14:
				if (str[i] == 'e') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S3;
				}
				else{ currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = "";}
				break;
			case KeyWordAndRelationsSignsStates::S15:
				if (str[i] == 'i') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S16;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S16:
				if (str[i] == 't') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S17;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S17:
				if (str[i] == 'c') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S18;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S18:
				if (str[i] == 'h') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S3;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S19:
				if (str[i] == 'e') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S20;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S20:
				if (str[i] == 't') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S21;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S21:
				if (str[i] == 'u') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S22;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S22:
				if (str[i] == 'r') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S23;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S23:
				if (str[i] == 'n') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S3;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S24:
				if (str[i] == 'h') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S25;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S25:
				if (str[i] == 'i') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S26;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S26:
				if (str[i] == 'l') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S27;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S27:
				if (str[i] == 'e') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S3;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S28:
				if (str[i] == 'o') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S29;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S29:
				if (str[i] == 'a') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S30;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S30:
				if (str[i] == 't') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S3;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S31:
				if (str[i] == 'h') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S32;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S32:
				if (str[i] == 'a') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S33;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S33:
				if (str[i] == 'r') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S3;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S34:
				if (str[i] == '=') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S35;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S1; word = ""; }
				break;
			case KeyWordAndRelationsSignsStates::S36:
				if (str[i] == '=') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S35;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S35; }
				break;
			case KeyWordAndRelationsSignsStates::S37:
				if (str[i] == '=') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S35;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S35; }
				break;
			case KeyWordAndRelationsSignsStates::S38:
				if (str[i] == '=') {
					word += str[i];
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S35;
				}
				else if (str[i] == '>' || str[i] == '<') {
					word = "";
					currentsKeyWordState = KeyWordAndRelationsSignsStates::S1;
				}
				else { currentsKeyWordState = KeyWordAndRelationsSignsStates::S35; }
				break;
			default:
				break;
			}
			if (currentsKeyWordState == KeyWordAndRelationsSignsStates::S3) {
				if(i + 1 != str->Length) {
					if (isNextSplit(str[i + 1]) && isContainInTable(word) && !isWordNext(str[i+1])) {
						WriteInTable(keyWordsTable, word, keyWordIndex);
						keyWordIndex++;
					}
				}
				else {
					if (isContainInTable(word)) {
						WriteInTable(keyWordsTable, word,  keyWordIndex);
						keyWordIndex++;
					}
				}
				word = "";
				currentsKeyWordState = KeyWordAndRelationsSignsStates::S1;
			}
			else if (currentsKeyWordState == KeyWordAndRelationsSignsStates::S35) {
				if (isContainInTable(word)) {
					WriteInTable(relationsSignsTable, word, relationsSignsIndex);
					relationsSignsIndex++;
				}
				word = "";
				currentsKeyWordState = KeyWordAndRelationsSignsStates::S1;
			}
		}
	}
	private: void WriteInTable(DataGridView^ keyWordsTable, String^ keyWord, int keyWordIndex) {
		keyWordsTable->Rows[keyWordIndex]->Cells[0]->Value = keyWordIndex + 1;
		keyWordsTable->Rows[keyWordIndex]->Cells[1]->Value = keyWord;
		keyWordsTable->Rows[keyWordIndex]->Cells[2]->Value = keyWord->ToUpper();
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

	private: bool isNewWord(String^ str, int i) {
		if (i == 2) return true;
		return isNextSplit(str[i - 1]);
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

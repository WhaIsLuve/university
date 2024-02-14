#pragma once
#include "State.cpp"

namespace Regex {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для MainWindow
	/// </summary>
	public ref class MainWindow : public System::Windows::Forms::Form
	{
	public:
		MainWindow(void)
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
		~MainWindow()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::PictureBox^ imgAuto;
	private: System::Windows::Forms::TextBox^ input;
	private: System::Windows::Forms::Button^ step;
	private: System::Windows::Forms::Button^ autoStep;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::DataGridView^ correctInputs;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Sequence;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::DataGridView^ unCorrectInputs;

	private: System::Windows::Forms::DataGridViewTextBoxColumn^ dataGridViewTextBoxColumn1;
	private: System::Windows::Forms::TextBox^ stateCurrentWord;
	private: System::Windows::Forms::Label^ label5;
	private: System::Windows::Forms::Button^ reset;




	protected:

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->imgAuto = (gcnew System::Windows::Forms::PictureBox());
			this->input = (gcnew System::Windows::Forms::TextBox());
			this->step = (gcnew System::Windows::Forms::Button());
			this->autoStep = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->correctInputs = (gcnew System::Windows::Forms::DataGridView());
			this->Sequence = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->unCorrectInputs = (gcnew System::Windows::Forms::DataGridView());
			this->dataGridViewTextBoxColumn1 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->stateCurrentWord = (gcnew System::Windows::Forms::TextBox());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->reset = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->imgAuto))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->correctInputs))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->unCorrectInputs))->BeginInit();
			this->SuspendLayout();
			// 
			// imgAuto
			// 
			this->imgAuto->Location = System::Drawing::Point(926, 2);
			this->imgAuto->Name = L"imgAuto";
			this->imgAuto->Size = System::Drawing::Size(360, 236);
			this->imgAuto->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->imgAuto->TabIndex = 0;
			this->imgAuto->TabStop = false;
			// 
			// input
			// 
			this->input->Location = System::Drawing::Point(379, 503);
			this->input->Name = L"input";
			this->input->Size = System::Drawing::Size(471, 22);
			this->input->TabIndex = 1;
			// 
			// step
			// 
			this->step->Location = System::Drawing::Point(379, 545);
			this->step->Name = L"step";
			this->step->Size = System::Drawing::Size(106, 42);
			this->step->TabIndex = 2;
			this->step->Text = L"Пошаговый";
			this->step->UseVisualStyleBackColor = true;
			this->step->Click += gcnew System::EventHandler(this, &MainWindow::step_Click);
			// 
			// autoStep
			// 
			this->autoStep->Location = System::Drawing::Point(703, 545);
			this->autoStep->Name = L"autoStep";
			this->autoStep->Size = System::Drawing::Size(147, 42);
			this->autoStep->TabIndex = 3;
			this->autoStep->Text = L"Автоматический";
			this->autoStep->UseVisualStyleBackColor = true;
			this->autoStep->Click += gcnew System::EventHandler(this, &MainWindow::autoStep_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(536, 558);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(120, 16);
			this->label1->TabIndex = 4;
			this->label1->Text = L"Выберете режим ";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(398, 459);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(437, 16);
			this->label2->TabIndex = 5;
			this->label2->Text = L"Введите последовательность, каждое новое слово через пробел";
			// 
			// correctInputs
			// 
			this->correctInputs->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->correctInputs->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(1) { this->Sequence });
			this->correctInputs->Location = System::Drawing::Point(2, 38);
			this->correctInputs->Name = L"correctInputs";
			this->correctInputs->RowHeadersWidth = 51;
			this->correctInputs->RowTemplate->Height = 24;
			this->correctInputs->Size = System::Drawing::Size(233, 402);
			this->correctInputs->TabIndex = 6;
			// 
			// Sequence
			// 
			this->Sequence->HeaderText = L"Последовательность";
			this->Sequence->MinimumWidth = 6;
			this->Sequence->Name = L"Sequence";
			this->Sequence->Width = 150;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(-1, 19);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(228, 16);
			this->label3->TabIndex = 7;
			this->label3->Text = L"Правильная последовательность";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(249, 19);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(244, 16);
			this->label4->TabIndex = 9;
			this->label4->Text = L"Неправильная последовательность";
			// 
			// unCorrectInputs
			// 
			this->unCorrectInputs->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->unCorrectInputs->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(1) { this->dataGridViewTextBoxColumn1 });
			this->unCorrectInputs->Location = System::Drawing::Point(252, 38);
			this->unCorrectInputs->Name = L"unCorrectInputs";
			this->unCorrectInputs->RowHeadersWidth = 51;
			this->unCorrectInputs->RowTemplate->Height = 24;
			this->unCorrectInputs->Size = System::Drawing::Size(233, 402);
			this->unCorrectInputs->TabIndex = 8;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this->dataGridViewTextBoxColumn1->HeaderText = L"Последовательность";
			this->dataGridViewTextBoxColumn1->MinimumWidth = 6;
			this->dataGridViewTextBoxColumn1->Name = L"dataGridViewTextBoxColumn1";
			this->dataGridViewTextBoxColumn1->Width = 150;
			// 
			// stateCurrentWord
			// 
			this->stateCurrentWord->Location = System::Drawing::Point(502, 62);
			this->stateCurrentWord->Name = L"stateCurrentWord";
			this->stateCurrentWord->ReadOnly = true;
			this->stateCurrentWord->Size = System::Drawing::Size(318, 22);
			this->stateCurrentWord->TabIndex = 10;
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(499, 38);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(199, 16);
			this->label5->TabIndex = 11;
			this->label5->Text = L"Состояние последнего слова";
			// 
			// reset
			// 
			this->reset->Location = System::Drawing::Point(1179, 562);
			this->reset->Name = L"reset";
			this->reset->Size = System::Drawing::Size(97, 49);
			this->reset->TabIndex = 12;
			this->reset->Text = L"Сброс";
			this->reset->UseVisualStyleBackColor = true;
			this->reset->Click += gcnew System::EventHandler(this, &MainWindow::reset_Click);
			// 
			// MainWindow
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::ActiveBorder;
			this->ClientSize = System::Drawing::Size(1288, 623);
			this->Controls->Add(this->reset);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->stateCurrentWord);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->unCorrectInputs);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->correctInputs);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->autoStep);
			this->Controls->Add(this->step);
			this->Controls->Add(this->input);
			this->Controls->Add(this->imgAuto);
			this->Name = L"MainWindow";
			this->Text = L"MainWindow";
			this->Load += gcnew System::EventHandler(this, &MainWindow::MainWindow_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->imgAuto))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->correctInputs))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->unCorrectInputs))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: Image^ autoPath = Image::FromFile("C:\\Users\\Влад\\Desktop\\Университет\\Второй курс\\Теория автоматов\\Regex\\automat.png");

	private: array<String^>^ X;
	private: int indexX = 0;
	private: int length = 0;
	private: State currentState = State::S1;
	private: int indexCorrectDataGrid = 0;
	private: int indexUncorrectDataGrid = 0;


	private: System::Void MainWindow_Load(System::Object^ sender, System::EventArgs^ e) {
		initPictures();
		initDataGrids();
	}

	private: void initPictures() {
		this->imgAuto->Image = autoPath;
	}
	private: void initDataGrids() {
		this->correctInputs->RowCount = 13;
		this->unCorrectInputs->RowCount = 13;
		this->indexCorrectDataGrid = 0;
		this->indexUncorrectDataGrid = 0;
	}
	private: System::Void step_Click(System::Object^ sender, System::EventArgs^ e) {
		if (this->input->Text->Length > 0 && (this->indexX == 0 || this->length != this->input->Text->Split()->Length)) {
			this->X = this->input->Text->Split();
			this->length = X->Length;
		}
		if (this->indexX == this->length) {
			MessageBox::Show("Слова закончились");
		}
		else {
			CheckWord(X[indexX++]);
		}
	}

	private: void CheckWord(String^ word) {
		String^ outputState;
		for (int i = 0; i < word->Length; i++)
		{
			switch (currentState) {
				case State::S0:
					if (word[i] == '1') {
						outputState += "S0 ";
						currentState = State::S0;
					}
					else if (word[i] == '0') {
						outputState += "S1 ";
						currentState = State::S1;
					}
					else {
						MessageBox::Show("Неизвестный символ, слово введено не верно!");
						return;
					}
					break;
				case State::S1:
					if (word[i] == '1') {
						outputState += "S1 ";
						currentState = State::S1;
					}
					else if (word[i] == '0') {
						outputState += "S0 ";
						currentState = State::S0;
					}
					else {
						MessageBox::Show("Неизвестный символ, слово введено не верно!");
						return;
					}
					break;
				default:
					break;
			}
		}
		if (currentState == State::S0) {
			this->correctInputs->Rows[indexCorrectDataGrid++]->Cells[0]->Value = word;
		}
		else {
			this->unCorrectInputs->Rows[indexUncorrectDataGrid++]->Cells[0]->Value = word;
		}
		this->stateCurrentWord->Text = outputState;
		currentState = State::S0;
	}
	private: System::Void reset_Click(System::Object^ sender, System::EventArgs^ e) {
		this->input->Text = "";
		this->indexX = 0;
		this->stateCurrentWord->Text = "";
		this->correctInputs->ColumnCount = 0;
		this->correctInputs->ColumnCount = 1;
		this->unCorrectInputs->ColumnCount = 0;
		this->unCorrectInputs->ColumnCount = 1;
		initDataGrids();
	}
	private: System::Void autoStep_Click(System::Object^ sender, System::EventArgs^ e) {
		for (int i = 0; i < this->input->Text->Split()->Length; i++)
		{
			step_Click(sender, e);
		}
		this->stateCurrentWord->Text = "";
	}
};
}

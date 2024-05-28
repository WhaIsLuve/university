#pragma once
#include "AirTransport.h"
#include "TransportManager.h"

namespace cursOOP {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// —водка дл€ CreateTransport
	/// </summary>
	public ref class CreateTransport : public System::Windows::Forms::Form
	{
	public:
		CreateTransport(void)
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
		~CreateTransport()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ComboBox^ comboBox1;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::TextBox^ enginePower;
	private: System::Windows::Forms::Label^ labelEnginePower;
	private: System::Windows::Forms::Label^ labelCargoCapacity;
	private: System::Windows::Forms::TextBox^ cargoCapacity;
	private: System::Windows::Forms::Button^ create;





	protected:

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
			this->comboBox1 = (gcnew System::Windows::Forms::ComboBox());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->enginePower = (gcnew System::Windows::Forms::TextBox());
			this->labelEnginePower = (gcnew System::Windows::Forms::Label());
			this->labelCargoCapacity = (gcnew System::Windows::Forms::Label());
			this->cargoCapacity = (gcnew System::Windows::Forms::TextBox());
			this->create = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// comboBox1
			// 
			this->comboBox1->FormattingEnabled = true;
			this->comboBox1->Items->AddRange(gcnew cli::array< System::Object^  >(2) { L"AirTransport", L"EngineAirTransport" });
			this->comboBox1->Location = System::Drawing::Point(30, 26);
			this->comboBox1->Name = L"comboBox1";
			this->comboBox1->Size = System::Drawing::Size(121, 24);
			this->comboBox1->TabIndex = 0;
			this->comboBox1->SelectedIndexChanged += gcnew System::EventHandler(this, &CreateTransport::comboBox1_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(30, 88);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(121, 22);
			this->textBox1->TabIndex = 1;
			this->textBox1->Visible = false;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(30, 66);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(58, 16);
			this->label1->TabIndex = 2;
			this->label1->Text = L"capacity";
			this->label1->Visible = false;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(33, 121);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(45, 16);
			this->label2->TabIndex = 4;
			this->label2->Text = L"weight";
			this->label2->Visible = false;
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(30, 151);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(121, 22);
			this->textBox2->TabIndex = 5;
			this->textBox2->Visible = false;
			// 
			// enginePower
			// 
			this->enginePower->Location = System::Drawing::Point(33, 271);
			this->enginePower->Name = L"enginePower";
			this->enginePower->Size = System::Drawing::Size(121, 22);
			this->enginePower->TabIndex = 9;
			this->enginePower->Visible = false;
			// 
			// labelEnginePower
			// 
			this->labelEnginePower->AutoSize = true;
			this->labelEnginePower->Location = System::Drawing::Point(36, 241);
			this->labelEnginePower->Name = L"labelEnginePower";
			this->labelEnginePower->Size = System::Drawing::Size(88, 16);
			this->labelEnginePower->TabIndex = 8;
			this->labelEnginePower->Text = L"engine power";
			this->labelEnginePower->Visible = false;
			// 
			// labelCargoCapacity
			// 
			this->labelCargoCapacity->AutoSize = true;
			this->labelCargoCapacity->Location = System::Drawing::Point(33, 186);
			this->labelCargoCapacity->Name = L"labelCargoCapacity";
			this->labelCargoCapacity->Size = System::Drawing::Size(96, 16);
			this->labelCargoCapacity->TabIndex = 7;
			this->labelCargoCapacity->Text = L"cargo capacity";
			this->labelCargoCapacity->Visible = false;
			// 
			// cargoCapacity
			// 
			this->cargoCapacity->Location = System::Drawing::Point(33, 208);
			this->cargoCapacity->Name = L"cargoCapacity";
			this->cargoCapacity->Size = System::Drawing::Size(121, 22);
			this->cargoCapacity->TabIndex = 6;
			this->cargoCapacity->Visible = false;
			// 
			// create
			// 
			this->create->Location = System::Drawing::Point(628, 478);
			this->create->Name = L"create";
			this->create->Size = System::Drawing::Size(124, 55);
			this->create->TabIndex = 10;
			this->create->Text = L"Create";
			this->create->UseVisualStyleBackColor = true;
			this->create->Click += gcnew System::EventHandler(this, &CreateTransport::create_Click);
			// 
			// CreateTransport
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(764, 545);
			this->Controls->Add(this->create);
			this->Controls->Add(this->enginePower);
			this->Controls->Add(this->labelEnginePower);
			this->Controls->Add(this->labelCargoCapacity);
			this->Controls->Add(this->cargoCapacity);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->comboBox1);
			this->Name = L"CreateTransport";
			this->Text = L"CreateTransport";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void comboBox1_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e) {
		switch (this->comboBox1->SelectedIndex)
		{
			case 0:
				this->textBox1->Visible = true;
				this->label1->Visible = true;
				this->label2->Visible = true;
				this->textBox2->Visible = true;
				this->labelCargoCapacity->Visible = false;
				this->labelEnginePower->Visible = false;
				this->cargoCapacity->Visible = false;
				this->enginePower->Visible = false;
				break;
			case 1:
				this->textBox1->Visible = true;
				this->label1->Visible = true;
				this->label2->Visible = true;
				this->textBox2->Visible = true;
				this->labelCargoCapacity->Visible = true;
				this->labelEnginePower->Visible = true;
				this->cargoCapacity->Visible = true;
				this->enginePower->Visible = true;
				break;
			default:
				break;
		}
	}
	private: System::Void create_Click(System::Object^ sender, System::EventArgs^ e) {
		TransportManager manager;
		switch (this->comboBox1->SelectedIndex)
		{
		case 0: 
			createAirTransport(manager);
			break;
		case 1:
			
			break;
		default:
			break;
		}
	}
	private: void createAirTransport(TransportManager& manager) {
		int capacity = Convert::ToInt32(this->textBox1->Text);
		double weight = Convert::ToDouble(this->textBox2->Text);
		manager.CreateAirTransport(capacity, weight);
	}
};
}

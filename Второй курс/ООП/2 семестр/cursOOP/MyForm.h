#pragma once
#include "AirTransport.h"
#include "EngineAirTransport.h"
#include "CreateTransport.h"

namespace cursOOP {

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
	private: System::Windows::Forms::Button^ create;
	private: System::Windows::Forms::Button^ loadStack;
	protected:

	protected:

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
			this->create = (gcnew System::Windows::Forms::Button());
			this->loadStack = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// create
			// 
			this->create->Location = System::Drawing::Point(449, 429);
			this->create->Name = L"create";
			this->create->Size = System::Drawing::Size(137, 53);
			this->create->TabIndex = 0;
			this->create->Text = L"Create";
			this->create->UseVisualStyleBackColor = true;
			this->create->Click += gcnew System::EventHandler(this, &MyForm::create_Click);
			// 
			// loadStack
			// 
			this->loadStack->Location = System::Drawing::Point(628, 429);
			this->loadStack->Name = L"loadStack";
			this->loadStack->Size = System::Drawing::Size(137, 53);
			this->loadStack->TabIndex = 1;
			this->loadStack->Text = L"Load";
			this->loadStack->UseVisualStyleBackColor = true;
			this->loadStack->Click += gcnew System::EventHandler(this, &MyForm::loadStack_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1167, 595);
			this->Controls->Add(this->loadStack);
			this->Controls->Add(this->create);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void create_Click(System::Object^ sender, System::EventArgs^ e) {
		CreateTransport^ ct = gcnew CreateTransport();
		ct->Activate();
		ct->Show();
	}

	   private: void load(IAirTransport& a) {
		   a.SaveInFile();
	}
	private: System::Void loadStack_Click(System::Object^ sender, System::EventArgs^ e) {
		AirTransport a;
		a.LoadFromFile();
	}
	};
}

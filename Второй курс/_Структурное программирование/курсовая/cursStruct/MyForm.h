#pragma once
#include <ctime>
#include <cstdlib>
namespace cursStruct {

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
    private: System::Windows::Forms::PictureBox^ pictureBox1;
    protected:
    private: System::Windows::Forms::Panel^ panel1;
    private: System::Windows::Forms::Button^ startProcess;


    private: System::Windows::Forms::Button^ SaveButton;
    private: System::Windows::Forms::SaveFileDialog^ saveFileDialog1;
    private: System::Windows::Forms::Button^ RandomColorButton;
    private: System::Windows::Forms::Label^ label1;
    private: System::Windows::Forms::NumericUpDown^ numericUpDown1;
    private: System::Windows::Forms::Button^ colorButton;
    private: System::Windows::Forms::ColorDialog^ colorDialog1;
    private: System::Windows::Forms::Button^ backgroundColorButton;

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
            this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
            this->panel1 = (gcnew System::Windows::Forms::Panel());
            this->backgroundColorButton = (gcnew System::Windows::Forms::Button());
            this->colorButton = (gcnew System::Windows::Forms::Button());
            this->label1 = (gcnew System::Windows::Forms::Label());
            this->numericUpDown1 = (gcnew System::Windows::Forms::NumericUpDown());
            this->RandomColorButton = (gcnew System::Windows::Forms::Button());
            this->SaveButton = (gcnew System::Windows::Forms::Button());
            this->startProcess = (gcnew System::Windows::Forms::Button());
            this->saveFileDialog1 = (gcnew System::Windows::Forms::SaveFileDialog());
            this->colorDialog1 = (gcnew System::Windows::Forms::ColorDialog());
            (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
            this->panel1->SuspendLayout();
            (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numericUpDown1))->BeginInit();
            this->SuspendLayout();
            // 
            // pictureBox1
            // 
            this->pictureBox1->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom)
                | System::Windows::Forms::AnchorStyles::Left)
                | System::Windows::Forms::AnchorStyles::Right));
            this->pictureBox1->Location = System::Drawing::Point(0, 60);
            this->pictureBox1->Margin = System::Windows::Forms::Padding(4);
            this->pictureBox1->Name = L"pictureBox1";
            this->pictureBox1->Size = System::Drawing::Size(1193, 489);
            this->pictureBox1->TabIndex = 0;
            this->pictureBox1->TabStop = false;
            // 
            // panel1
            // 
            this->panel1->Anchor = System::Windows::Forms::AnchorStyles::Top;
            this->panel1->Controls->Add(this->backgroundColorButton);
            this->panel1->Controls->Add(this->colorButton);
            this->panel1->Controls->Add(this->label1);
            this->panel1->Controls->Add(this->numericUpDown1);
            this->panel1->Controls->Add(this->RandomColorButton);
            this->panel1->Controls->Add(this->SaveButton);
            this->panel1->Controls->Add(this->startProcess);
            this->panel1->Location = System::Drawing::Point(0, 0);
            this->panel1->Margin = System::Windows::Forms::Padding(4);
            this->panel1->Name = L"panel1";
            this->panel1->Size = System::Drawing::Size(1193, 53);
            this->panel1->TabIndex = 1;
            // 
            // backgroundColorButton
            // 
            this->backgroundColorButton->Location = System::Drawing::Point(371, 6);
            this->backgroundColorButton->Margin = System::Windows::Forms::Padding(4);
            this->backgroundColorButton->Name = L"backgroundColorButton";
            this->backgroundColorButton->Size = System::Drawing::Size(168, 43);
            this->backgroundColorButton->TabIndex = 6;
            this->backgroundColorButton->Text = L"Изменить задний фон";
            this->backgroundColorButton->UseVisualStyleBackColor = true;
            this->backgroundColorButton->Click += gcnew System::EventHandler(this, &MyForm::backgroundColorButton_Click);
            // 
            // colorButton
            // 
            this->colorButton->Location = System::Drawing::Point(547, 6);
            this->colorButton->Margin = System::Windows::Forms::Padding(4);
            this->colorButton->Name = L"colorButton";
            this->colorButton->Size = System::Drawing::Size(153, 43);
            this->colorButton->TabIndex = 5;
            this->colorButton->Text = L"Изменить цвет орнамента";
            this->colorButton->UseVisualStyleBackColor = true;
            this->colorButton->Click += gcnew System::EventHandler(this, &MyForm::colorButton_Click);
            // 
            // label1
            // 
            this->label1->AutoSize = true;
            this->label1->Location = System::Drawing::Point(200, 0);
            this->label1->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
            this->label1->Name = L"label1";
            this->label1->Size = System::Drawing::Size(134, 16);
            this->label1->TabIndex = 4;
            this->label1->Text = L"Изменить масштаб:";
            // 
            // numericUpDown1
            // 
            this->numericUpDown1->Location = System::Drawing::Point(199, 17);
            this->numericUpDown1->Margin = System::Windows::Forms::Padding(4);
            this->numericUpDown1->Maximum = System::Decimal(gcnew cli::array< System::Int32 >(4) { 300, 0, 0, 0 });
            this->numericUpDown1->Minimum = System::Decimal(gcnew cli::array< System::Int32 >(4) { 50, 0, 0, 0 });
            this->numericUpDown1->Name = L"numericUpDown1";
            this->numericUpDown1->Size = System::Drawing::Size(160, 22);
            this->numericUpDown1->TabIndex = 3;
            this->numericUpDown1->Value = System::Decimal(gcnew cli::array< System::Int32 >(4) { 100, 0, 0, 0 });
            this->numericUpDown1->ValueChanged += gcnew System::EventHandler(this, &MyForm::numericUpDown1_ValueChanged);
            // 
            // RandomColorButton
            // 
            this->RandomColorButton->Location = System::Drawing::Point(708, 6);
            this->RandomColorButton->Margin = System::Windows::Forms::Padding(4);
            this->RandomColorButton->Name = L"RandomColorButton";
            this->RandomColorButton->Size = System::Drawing::Size(193, 43);
            this->RandomColorButton->TabIndex = 2;
            this->RandomColorButton->Text = L"Рандомный цвет орнамента";
            this->RandomColorButton->UseVisualStyleBackColor = true;
            this->RandomColorButton->Click += gcnew System::EventHandler(this, &MyForm::RandomColorButton_Click);
            // 
            // SaveButton
            // 
            this->SaveButton->Location = System::Drawing::Point(959, 6);
            this->SaveButton->Margin = System::Windows::Forms::Padding(4);
            this->SaveButton->Name = L"SaveButton";
            this->SaveButton->Size = System::Drawing::Size(185, 38);
            this->SaveButton->TabIndex = 1;
            this->SaveButton->Text = L"Сохранить";
            this->SaveButton->UseVisualStyleBackColor = true;
            this->SaveButton->Click += gcnew System::EventHandler(this, &MyForm::SaveButton_Click);
            // 
            // startProcess
            // 
            this->startProcess->Location = System::Drawing::Point(4, 4);
            this->startProcess->Margin = System::Windows::Forms::Padding(4);
            this->startProcess->Name = L"startProcess";
            this->startProcess->Size = System::Drawing::Size(187, 41);
            this->startProcess->TabIndex = 0;
            this->startProcess->Text = L"Построить орнамент";
            this->startProcess->UseVisualStyleBackColor = true;
            this->startProcess->Click += gcnew System::EventHandler(this, &MyForm::startProcess_Click_1);
            // 
            // MyForm
            // 
            this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
            this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
            this->ClientSize = System::Drawing::Size(1193, 549);
            this->Controls->Add(this->panel1);
            this->Controls->Add(this->pictureBox1);
            this->Margin = System::Windows::Forms::Padding(4);
            this->Name = L"MyForm";
            this->Text = L"MyForm";
            (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
            this->panel1->ResumeLayout(false);
            this->panel1->PerformLayout();
            (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numericUpDown1))->EndInit();
            this->ResumeLayout(false);

        }
#pragma endregion
    private:
        int hexagonSize;
        int hexagonColor;
        Color GetRandomColor() {
            srand(time(NULL));
            int r = rand() % 256;
            int g = rand() % 256;
            int b = rand() % 256;
            return Color::FromArgb(r, g, b);
        }
    private: System::Void numericUpDown1_ValueChanged(System::Object^ sender, System::EventArgs^ e) {
        pictureBox1->Refresh();
    }
    private: System::Void startProcess_Click_1(System::Object^ sender, System::EventArgs^ e) {
        // Очищаем box
        pictureBox1->Refresh();
        OrnamentDraw((int)numericUpDown1->Value, Color::Black);
    }
    private: System::Void SaveButton_Click(System::Object^ sender, System::EventArgs^ e) {
        // Определяем область, которую хотим сохранить (в данном случае - область pictureBox)
        Rectangle rect = pictureBox1->Bounds;
        // Создаем Bitmap с размерами области
        Bitmap^ bitmap = gcnew Bitmap(rect.Width, rect.Height);
        // Создаем Graphics для Bitmap
        Graphics^ graphics = Graphics::FromImage(bitmap);
        // Копируем область pictureBox на Graphics
        Point location = pictureBox1->PointToScreen(Point(0, 0));
        graphics->CopyFromScreen(location, Point(0, 0), rect.Size);
        // Освобождаем ресурсы Graphics
        delete graphics;
        // Открываем диалоговое окно для выбора места сохранения файла
        SaveFileDialog^ saveFileDialog = gcnew SaveFileDialog();
        saveFileDialog->Filter = "PNG Image (*.png)|*.png|JPEG Image(*.jpg)|*.jpg|Bitmap Image(*.bmp)|*.bmp";
        saveFileDialog->Title = "Save Image";
        if (saveFileDialog->ShowDialog() == System::Windows::Forms::DialogResult::OK) {
            // Если пользователь выбрал место сохранения файла
            if (saveFileDialog->FileName != "") {
                // Сохраняем Bitmap в выбранном месте
                bitmap->Save(saveFileDialog->FileName, Imaging::ImageFormat::Png);
            }
        }
        // Освобождаем ресурсы Bitmap
        delete bitmap;

    }
    private: System::Void RandomColorButton_Click(System::Object^ sender, System::EventArgs^ e) {
        // Очищаем box
        pictureBox1->Refresh();
        OrnamentDraw((int)numericUpDown1->Value, GetRandomColor());
    }
           void OrnamentDraw(int size, Color color) {
               Graphics^ graphics = pictureBox1->CreateGraphics();
               Pen^ pen = gcnew Pen(color);
               //размеры picture box
               int width = pictureBox1->Width;
               int height = pictureBox1->Height;
               // Размер каждого шестиугольника
               int totalHexagons = width / (size / 2);
               // Общая ширина всех шестиугольников и промежутков между ними
               int startX = 0; // Начальная позиция по X
               int startY = 0;
               int numHexagonsY = height / (size / 2);
               int rowY = startY;
               int    rowX = startX;
               for (int ii = 0; ii < numHexagonsY; ii++) {
                   // координаты y для текущего ряда
                   rowY += size / 2 - size / 14;
                   // условие чередования местоположения
                   if (ii % 2 != 0) {
                       rowX += (size / 2 + size / 4);
                   }
                   BigHexagonDraw(totalHexagons, size, rowX, rowY, graphics, pen, color);
                   //при чередовании возвращение в предыдущее
                   if (ii % 2 != 0) {
                       rowX = startX;
                   }
               }
           }
           void BigHexagonDraw(int totalHexagons, int size, int rowX, int rowY, Graphics^ graphics, Pen^ pen, Color color) {
               int i = 0;
               while (i < totalHexagons || size * i + size <= pictureBox1->Width) {
                   int x = rowX + (size / 2) * i; // Позиция X текущего шестиугольника
                   // Рассчитываем координаты точек для текущего big шестиугольника
                   array<Point>^ bighexagonPoints = gcnew array<Point>(6);
                   for (int j = 0; j < 6; j++) {
                       double angle = Math::PI / 3 * j;
                       int pointX = x + (int)(size / 2 * Math::Cos(angle));
                       int pointY = rowY + (int)(size / 2 * Math::Sin(angle));
                       bighexagonPoints[j] = Point(pointX, pointY);
                   }
                   // Рисуем текущий big шестиугольник
                   if (i % 3 == 0) {
                       Pen^ thickPen = gcnew Pen(color, 3);
                       graphics->DrawPolygon(thickPen, bighexagonPoints);
                   }
                   else {
                       graphics->DrawPolygon(pen, bighexagonPoints);
                   }
                   SmallHexagonDraw(size, x, rowY, graphics, pen);
                   i++;
               }
           }
           void SmallHexagonDraw(int size, int x, int rowY, Graphics^ graphics, Pen^ pen) {
               // Рассчитываем размеры и координаты для внутреннего малого шестиугольника
               int smallSize = (int)(size * 0.8);
               int smallX = x;
               int smallY = rowY;

               // Рассчитываем координаты точек для текущего малого шестиугольника
               array<Point>^ smallHexagonPoints = gcnew array<Point>(6);
               for (int jj = 0; jj < 6; jj++) {
                   double angle = 2 * Math::PI / 6 * jj;
                   int pointX = smallX + (int)(smallSize / 2 * Math::Cos(angle));
                   int pointY = smallY + (int)(smallSize / 2 * Math::Sin(angle));
                   smallHexagonPoints[jj] = Point(pointX, pointY);
               }
               // Рисуем текущий малый шестиугольник
               graphics->DrawPolygon(pen, smallHexagonPoints);
           }
    private: System::Void colorButton_Click(System::Object^ sender, System::EventArgs^ e) {
        ColorDialog^ colorDialog1 = gcnew ColorDialog();
        if (colorDialog1->ShowDialog() == System::Windows::Forms::DialogResult::OK) {
            Color selectedcolor = colorDialog1->Color;
            OrnamentDraw((int)numericUpDown1->Value, selectedcolor);
        }
    }
    private: System::Void backgroundColorButton_Click(System::Object^ sender, System::EventArgs^ e) {
        ColorDialog^ colorDialog2 = gcnew ColorDialog();
        if (colorDialog2->ShowDialog() == System::Windows::Forms::DialogResult::OK) {
            Color selectedcolor = colorDialog2->Color;
            pictureBox1->BackColor = selectedcolor;
        }
    }
};
}
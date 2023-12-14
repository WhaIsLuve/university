#include "MainWindow.h"

using namespace System;
using namespace System::Windows::Forms;

[STAThreadAttribute]
int main(array<String^>^ args) 
{
	Application::SetCompatibleTextRenderingDefault(false);
	Application::EnableVisualStyles();
	CoffeeMachine::MainWindow mainWindow;
	Application::Run(% mainWindow);
}
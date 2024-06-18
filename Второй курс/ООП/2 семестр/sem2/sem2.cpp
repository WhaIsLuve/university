#include <iostream>
#include <Windows.h>
#include "AirTransport.h"
#include "EngineAirTransport.h"
#include "WingyTransport.h"
#include "Rotorcraft.h"
#include "BallonTransport.h"
#include "Stack.h"
#include "List.h"
#include "GlideTransport.h"
#include <string>
using namespace std;
void showCommands() { 
	cout << "----------------" << endl;
	cout << "Список действий." << endl;
	cout << "----------------" << endl;
	cout << "1.Загрузить файл." << endl;
	cout << "2.Список транспорта." << endl;
	cout << "3.Создать транспорт." << endl;
	cout << "4.Осортировать транспорта." << endl;
	cout << "5.Найти транспорт." << endl;
	cout << "6.Сохранить в файл" << endl;
	cout << "7.Закончить работу." << endl << endl;
}
void showEntity() {
	cout << "-------------------------" << endl;
	cout << "Виды транспорта." << endl;
	cout << "-------------------------" << endl;
	cout << "1. Крылатый транспорт." << endl;
	cout << "2. Винтокрылый транспорт." << endl;
	cout << "3. Шариковый транспорт." << endl;
	cout << "4. Парирующий транспорт." << endl << endl;
}
int main()
{
	setlocale(LC_ALL, "rus");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	string nameFile;
	ifstream f;
	ofstream F;
	int action = 0; 
	Stack<WingyTransport> wingyTransportStack;
	Stack<Rotorcraft> rotorcraftStack;
	Stack<BallonTransport> balloonTransportStack;
	Stack<GlideTransport> glideTransportStack;
	List<IAirTransport> list;
	while (true) {
		showCommands();
		cout << "Выберите действие: ";
		cin >> action;
		if (action == 7) {
			cout << "---------------------------Завершение работы---------------------------" << endl;
			break;
		}
		switch (action)
		{
			case 1: // load
			#pragma region LoadFromFile
				cout << "Введите путь до файла и его имя: ";
				cin >> nameFile;
				f.open(nameFile);
				while (!f.eof()) {
					string nameClass;
					int capacity;
					double weight;
					bool isLanding;
					bool isFlying;
					f >> nameClass;
					f >> weight;
					f >> capacity;
					f >> isLanding;
					f >> isFlying;
					if (isFlying && isLanding) {
						cout << "---------------------------Транспорт не может одновременно быть в воздухе и на земле---------------------------";
						break;
					}
					if (nameClass == "WingyTransport") {
						int countEngines;
						double cargoCapcity;
						double enginePower;
						f >> countEngines;
						f >> cargoCapcity;
						f >> enginePower;
						try {
							WingyTransport transport(countEngines, cargoCapcity, enginePower, capacity, weight);
							if (isLanding) transport.Land();
							else transport.Fly();
							wingyTransportStack.Push(transport);
							list.PushFront(transport);
						}
						catch (exception ex) {
							cout << "---------------------------" << ex.what() << "---------------------------" << endl;
						}
					}
					else if (nameClass == "BallonTransport") {
						int powerFire;
						int timeInAirSec;
						f >> powerFire;
						f >> timeInAirSec;
						try {
							BallonTransport transport(powerFire, timeInAirSec, capacity, weight);
							if (isLanding) transport.Land();
							else transport.Fly();
							balloonTransportStack.Push(transport);
							list.PushFront(transport);
						}
						catch (exception ex) {
							cout << "---------------------------" << ex.what() << "---------------------------" << endl;
						}
					}
					else if (nameClass == "Rotorcraft") {
						int countRotor;
						double cargoCapcity;
						double enginePower;
						f >> countRotor;
						f >> cargoCapcity;
						f >> enginePower;
						try {
							Rotorcraft transport(countRotor, cargoCapcity, enginePower, capacity, weight);
							if (isLanding) transport.Land();
							else transport.Fly();
							rotorcraftStack.Push(transport);
							list.PushFront(transport);
						}
						catch (exception ex) {
							cout << "---------------------------" << ex.what() << "---------------------------" << endl;
						}
					}
					else if (nameClass == "GlideTransport") {
						int lengthWing;
						int timeInAirSec;
						f >> lengthWing;
						f >> timeInAirSec;
						try {
							GlideTransport transport(lengthWing, timeInAirSec, capacity, weight);
							if (isLanding) transport.Land();
							else transport.Fly();
							glideTransportStack.Push(transport);
							list.PushFront(transport);
						}
						catch (exception ex) {
							cout << "---------------------------" << ex.what() << "---------------------------" << endl;
						}
					}
				}
				f.close();
				break;
			#pragma endregion
			case 2: // to list
			#pragma region ToList
				cout << "---------------------------Весь крылатый транспорт---------------------------" << endl;
				wingyTransportStack.Show();
				cout << "---------------------------Весь винтокрылый транспорт---------------------------" << endl;
				rotorcraftStack.Show();
				cout << "---------------------------Весь шариковый транспорт---------------------------" << endl;
				balloonTransportStack.Show();
				cout << "---------------------------Весь парирующий транспорт---------------------------" << endl;
				glideTransportStack.Show();
				break;
			#pragma endregion
			case 3: // create
			#pragma region CreateEntity
				showEntity();
				cout << "Выберите вид транспорта: ";
				cin >> action;
				int capacity;
				double weight;
				if (action <= 2) {
					cout << "Введите вместимость по людям: ";
					cin >> capacity;
					cout << "Введите вес транспорта по тоннам: ";
					cin >> weight;
				}
				if (action == 1) {
					int countEngines;
					double cargoCapacity;
					double enginePower;
					bool isFlying;
					cout << "Введите кол-во двигателей: ";
					cin >> countEngines;
					cout << "Введите вместимость по грузу в тонах: ";
					cin >> cargoCapacity;
					cout << "Введите мощность двигателя: ";
					cin >> enginePower;
					try {
						WingyTransport transport(countEngines, cargoCapacity, enginePower, capacity, weight);
						cout << "Транспорт в полете?" << endl;
						cout << "Введите 1, если да. Введите 0, если нет" << endl;
						cin >> isFlying;
						if (isFlying) transport.Fly();
						else transport.Land();
						wingyTransportStack.Push(transport);
						list.PushFront(transport);
					}
					catch (exception ex) {
						cout << "---------------------------" << ex.what() << "---------------------------" << endl;
					}
				}
				else if (action == 2) {
					int countRotor;
					double cargoCapacity;
					double enginePower;
					bool isFlying;
					cout << "Введите кол-во винтов: ";
					cin >> countRotor;
					cout << "Введите вместимость по грузу в тонах: ";
					cin >> cargoCapacity;
					cout << "Введите мощность двигателя: ";
					cin >> enginePower;
					try {
						Rotorcraft transport(countRotor, cargoCapacity, enginePower, capacity, weight);
						cout << "Транспорт в полете?" << endl;
						cout << "Введите 1, если да. Введите 0, если нет" << endl;
						cin >> isFlying;
						if (isFlying) transport.Fly();
						else transport.Land();
						rotorcraftStack.Push(transport);
						list.PushFront(transport);
					}
					catch (exception ex) {
						cout << "---------------------------" << ex.what() << "---------------------------" << endl;
					}
				}
				else if (action == 3) {
					int powerFire;
					int timeInAirSec;
					bool isFlying;
					cout << "Введите мощность огня: ";
					cin >> powerFire;
					cout << "Введите время в воздухе в секундах: ";
					cin >> timeInAirSec;
					try {
						BallonTransport transport(powerFire, timeInAirSec, capacity, weight);
						cout << "Транспорт в полете?" << endl;
						cout << "Введите 1, если да. Введите 0, если нет" << endl;
						cin >> isFlying;
						if (isFlying) transport.Fly();
						else transport.Land();
						balloonTransportStack.Push(transport);
						list.PushFront(transport);
					}
					catch (exception ex) {
						cout << "---------------------------" << ex.what() << "---------------------------" << endl;
					}
				}
				else if (action == 4) {
					int lengthWing;
					int timeInAirSec;
					bool isFlying;
					cout << "Введите длину крыла: ";
					cin >> lengthWing;
					cout << "Введите время в воздухе в секундах: ";
					cin >> timeInAirSec;
					try {
						GlideTransport transport(lengthWing, timeInAirSec, capacity, weight);
						cout << "Транспорт в полете?" << endl;
						cout << "Введите 1, если да. Введите 0, если нет" << endl;
						cin >> isFlying;
						if (isFlying) transport.Fly();
						else transport.Land();
						glideTransportStack.Push(transport);
						list.PushFront(transport);
					}
					catch (exception ex) {
						cout << "---------------------------" << ex.what() << "---------------------------" << endl;
					}
				}
				else {
					cout << "---------------------------Неизвестный вид транспорта---------------------------" << endl;
				}
				break;
			#pragma endregion
			case 4: // sort
			#pragma region Sort
				cout << "По какому признаку вы бы хотели отсортировать транспорт?" << endl;
				cout << "1.Вместимость по людям" << endl;
				cout << "2.Вес" << endl;
				cout << "3.Вес и вместимость." << endl;
				cout << "Введите номер признака для сортировки: ";
				cin >> action;
				if (action == 1) {
					wingyTransportStack.SortByCapacity();
					rotorcraftStack.SortByCapacity();
					balloonTransportStack.SortByCapacity();
					glideTransportStack.SortByCapacity();
				}
				else if (action == 2) {
					wingyTransportStack.SortByWeight();
					rotorcraftStack.SortByWeight();
					balloonTransportStack.SortByWeight();
					glideTransportStack.SortByWeight();
				}
				else if (action == 3) {
					wingyTransportStack.Sort();
					rotorcraftStack.Sort();
					balloonTransportStack.Sort();
					glideTransportStack.Sort();
				}
				else {
					cout << "---------------------------Неизвестный признак---------------------------" << endl;
					break;
				}
				cout << "---------------------------Сортировка завершена---------------------------" << endl;
				break;
			#pragma endregion
			case 5: // search
			#pragma region Search
				cout << "Выберите по какому признаку будете искать объект:" << endl;
				cout << "1. Вес" << endl;
				cout << "2. Вместимость" << endl;
				cout << "Введите номер признака для поиска: ";
				cin >> action;
				if (action == 1) {
					double weight;
					cout << "Введите вес: ";
					cin >> weight;
					wingyTransportStack.SearchByWeight(weight);
					rotorcraftStack.SearchByWeight(weight);
					balloonTransportStack.SearchByWeight(weight);
					glideTransportStack.SearchByWeight(weight);
					cout << endl << endl;
				}
				else if (action == 2) {
					int capacity;
					cout << "Введите вместимость: ";
					cin >> capacity;
					wingyTransportStack.SearchByCapicity(capacity);
					rotorcraftStack.SearchByCapicity(capacity);
					balloonTransportStack.SearchByCapicity(capacity);
					glideTransportStack.SearchByCapicity(capacity);
					cout << endl << endl;
				}
				else {
					cout << "---------------------------Неизвестный признак---------------------------" << endl;
				}
				break;
			#pragma endregion
			case 6: // save
			#pragma region Save
				cout << "Выберите способ сохранения:" << endl;
				cout << "1. Сохранить транспорты в 1 файл" << endl;
				cout << "2. Распределить транспорт по видам по файлам" << endl;
				cin >> action;
				if (action == 1) {
					if (list.Size() == 0) {
						cout << "---------------------------Нет транспорта, который можно сохранить---------------------------" << endl;
						break;
					}
					cout << "Введите путь до файла и его имя: ";
					cin >> nameFile;
					F.open(nameFile);
					list.SaveAllElements(F);
					F.close();
				}
				else if (action == 2) { 
					if (list.Size() == 0) {
						cout << "---------------------------Нет транспорта, который можно сохранить---------------------------" << endl;
						break;
					}
					if (!wingyTransportStack.IsEmpty()) {
						cout << "Введите путь до файла и его имя, куда будет сохранятся трапнспорт крылатого вида: ";
						cin >> nameFile;
						F.open(nameFile);
						wingyTransportStack.SaveInFile(F);
						F.close();
					}
					if (!rotorcraftStack.IsEmpty()) {
						cout << "Введите путь до файла и его имя, куда будет сохранятся трапнспорт винтокрылого вида: ";
						cin >> nameFile;
						F.open(nameFile);
						rotorcraftStack.SaveInFile(F);
						F.close();
					}
					if (!balloonTransportStack.IsEmpty()) {
						cout << "Введите путь до файла и его имя, куда будет сохранятся трапнспорт шарикового вида: ";
						cin >> nameFile;
						F.open(nameFile);
						balloonTransportStack.SaveInFile(F);
						F.close();
					}
					if (!glideTransportStack.IsEmpty()) {
						cout << "Введите путь до файла и его имя, куда будет сохранятся трапнспорт парирующего вида: ";
						cin >> nameFile;
						F.open(nameFile);
						glideTransportStack.SaveInFile(F);
						F.close();
					}
				}
				else {
					cout << "---------------------------Неизвестный способ---------------------------" << endl;
				}
				break;
			#pragma endregion
			default:
				cout << "---------------------------Неизвестная команда, введите еще раз---------------------------" << endl;
				break;
		}
	}
}
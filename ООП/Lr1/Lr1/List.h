#pragma once
#include "airTransport.h"
class List // Линейный односвязный список
{
	private:
		#pragma region Node
		struct Node // Узел, в которм хранятся данные и указатель на следующий элемент, если он есть
		{
			airTransport data;
			Node* next;
		};
	#pragma endregion
		int size; // размер списка
		Node *head; // первый элемент
	public:
		List(); // констурктор по-умолчанию
		~List(); // деструктор 
		void add(const airTransport& transport); // добавление элемента
		void pop_front(); // удаление первого элемента
		int length(); // длина списка
		void clear(); // очистка списка
		void show(); // вывод содержимого
		void sort_by_engine_power(); // сортировка по Engine_power
		airTransport& operator[](const int index); // перегрузка оператора 
};


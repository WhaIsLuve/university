#pragma once
#include "airTransport.h"


template <class T>
class List // Ћинейный односв€зный список
{
	private:
		#pragma region Node
		template <class T>
		struct Node // ”зел, в котором хран€тс€ данные и указатель на следующий элемент, если он есть
		{
			T data;
			Node* next;
		};
	#pragma endregion
		int size; // размер списка
		Node<T>* head; // первый элемент
	public:
		List(); // констурктор по-умолчанию
		~List(); // деструктор 
		void add(const T& value); // добавление элемента
		void pop_front(); // удаление первого элемента
		int length(); // длина списка
		void clear(); // очистка списка
		void show(); // вывод содержимого
		void sort_by_engine_power(); // сортировка по Engine_power
		int search(T value); // поиск элемента, если элемент есть вовзвращает индекс, если нет, то -1
		T& operator[](const int index); // перегрузка оператора 
};


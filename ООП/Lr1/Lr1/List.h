#pragma once
#include "airTransport.h"


template <class T>
class List // �������� ����������� ������
{
	private:
		#pragma region Node
		template <class T>
		struct Node // ����, � ������� �������� ������ � ��������� �� ��������� �������, ���� �� ����
		{
			T data;
			Node* next;
		};
	#pragma endregion
		int size; // ������ ������
		Node<T>* head; // ������ �������
	public:
		List(); // ����������� ��-���������
		~List(); // ���������� 
		void add(const T& value); // ���������� ��������
		void pop_front(); // �������� ������� ��������
		int length(); // ����� ������
		void clear(); // ������� ������
		void show(); // ����� �����������
		void sort_by_engine_power(); // ���������� �� Engine_power
		int search(T value); // ����� ��������, ���� ������� ���� ����������� ������, ���� ���, �� -1
		T& operator[](const int index); // ���������� ��������� 
};


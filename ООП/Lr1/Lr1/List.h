#pragma once
#include "airTransport.h"
class List // �������� ����������� ������
{
	private:
		#pragma region Node
		struct Node // ����, � ������ �������� ������ � ��������� �� ��������� �������, ���� �� ����
		{
			airTransport data;
			Node* next;
		};
	#pragma endregion
		int size; // ������ ������
		Node *head; // ������ �������
	public:
		List(); // ����������� ��-���������
		~List(); // ���������� 
		void add(const airTransport& transport); // ���������� ��������
		void pop_front(); // �������� ������� ��������
		int length(); // ����� ������
		void clear(); // ������� ������
		void show(); // ����� �����������
		void sort_by_engine_power(); // ���������� �� Engine_power
		airTransport& operator[](const int index); // ���������� ��������� 
};


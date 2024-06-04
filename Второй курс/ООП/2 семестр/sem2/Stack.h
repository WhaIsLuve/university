#pragma once
#include "AirTransport.h"
#include<fstream>
#include <stdexcept>
#include <iostream>

using namespace std;

template<class T>
class Stack
{
	private:
		class Node {
			public:
				T element;
				Node *next;	
		};
		int size = 0;
		Node *head;
	public:
		~Stack();
		void Push(T& airTransport);
		T& Pop();
		bool IsEmpty();
		void ToNull();
		void Show();
		void SaveInFile(std::ofstream& f);
		void SortByCapacity();
		void Sort();
		void SortByWeight();
		void SearchByCapicity(int capcity);
		void SearchByWeight(double weight);
		T& operator[](int index);
};

template<class T>
Stack<T>::~Stack()
{
	ToNull();
}

template<class T>
void Stack<T>::Push(T& airTransport)
{
	Node* tmp = new Node;
	tmp->next = head;
	head = tmp;
	head->element = airTransport;
	size++;
}

template<class T>
T& Stack<T>::Pop()
{
	if (IsEmpty()) throw out_of_range("Стек пуст!");
	Node* tmp = head;
	T air = tmp->element;
	head = head->next;
	delete(tmp);
	size--;
	return air;
}

template<class T>
bool Stack<T>::IsEmpty()
{
	return size == 0 && head == nullptr;
}

template<class T>
void Stack<T>::ToNull()
{
	while (!IsEmpty()) {
		Pop();
	}
}

template<class T>
void Stack<T>::Show()
{
	Node* tmp = head;
	if (tmp == nullptr) cout << "Empty" << endl;
	while (tmp != nullptr) {
		tmp->element.Show();
		cout << endl;
		tmp = tmp->next;
	}
}

template<class T>
void Stack<T>::SaveInFile(ofstream& f)
{
	for (int i = 0; i < size; i++) {
		this->operator[](i).SaveInFile(f);
	}
}

template<class T>
void Stack<T>::SortByCapacity()
{
	for (int i = 0; i < size - 1; i++) {
		for (int j = i + 1; j < size; j++) {
			if (this->operator[](i).GetCapacity() > this->operator[](j).GetCapacity()) {
				swap(this->operator[](i), this->operator[](j));
			}
		}
	}
}

template<class T>
void Stack<T>::Sort()
{
	for (int i = 0; i < size - 1; i++) {
		for (int j = i + 1; j < size; j++) {
			if (this->operator[](i) > this->operator[](j)) {
				swap(this->operator[](i), this->operator[](j));
			}
		}
	}
}

template<class T>
void Stack<T>::SortByWeight()
{
	for (int i = 0; i < size - 1; i++) {
		for (int j = i + 1; j < size; j++) {
			if (this->operator[](i).GetWeight() > this->operator[](j).GetWeight()) {
				swap(this->operator[](i), this->operator[](j));
			}
		}
	}
}

template<class T>
void Stack<T>::SearchByCapicity(int capacity)
{
	for (int i = 0; i < size; i++) {
		if (capacity == this->operator[](i).GetCapacity()) {
			this->operator[](i).Show();
		}
	}
}

template<class T>
void Stack<T>::SearchByWeight(double weight) {
	for (int i = 0; i < size; i++) {
		if (weight == this->operator[](i).GetWeight()) {
			this->operator[](i).Show();
		}
	}
}

template<class T>
T& Stack<T>::operator[](int index)
{
	Node* tmp = head;
	for (int i = 0; i < index; i++) {
		tmp = tmp->next;
	}
	return tmp->element;
}


#include "List.h"
#include <iostream>

using namespace std;

template <typename T>
List<T>::List() 
{
	size = 0;
	head = nullptr;
}

template <typename T>
List<T>::~List()
{
	clear();
}

template <typename T>
void List<T>::add(const T& value)
{
  size++;
  if (head == nullptr) 
  {
    head = new Node<T>;
    head->data = value;
    head->next = nullptr;
  }
  else {
    Node<T> *current = this->head;
    while (current->next != nullptr)
    {
      current = current->next;
    }
    current->next = new Node<T>;
    current->next->data = value;
    current->next->next = nullptr;
  }
}

template <typename T>
void List<T>::pop_front()
{
	if (head == nullptr) {
		// обработка ошибки или возврат из метода
		return;
	}
	Node<T>* temp = head;
	head = head->next;
	delete temp;
	size--;
}

template <typename T>
int List<T>::length()
{
	return size;
}

template <typename T>
void List<T>::clear()
{
	while (size) 
	{
		pop_front();
	}
}

template <typename T>
void List<T>::show()
{
	for (int i = 0; i < this->size; i++) {
		cout << this->operator[](i) << endl << endl;
	}
}

template <typename T>
void List<T>::sort_by_engine_power()
{
	for (int i = 0; i < this->length(); i++) 
	{
		bool flag = true;
		for (int j = 0; j < this->length() - (i + 1); j++) {
			if (this->operator[](j) > this->operator[](j + 1)) {
				flag = false;
				std::swap(this->operator[](j), this->operator[](j + 1));
			}
		}
		if (flag) {
			break;
		}
	}
}

template <typename T>
int List<T>::search(T value)
{
	for (int i = 0; i < this->length(); i++)
	{
		if (this->operator[](i) == value)
			return i;
	}
	return -1;
}

template <typename T>
T& List<T>::operator[](const int index)
{
	int counter = 0;
	Node<T>* current = this->head;
	while (current->next != nullptr) 
	{
		if (counter == index)
			return current->data;
		current = current->next;
		counter++;
	}
}

#include "List.h"
#include <iostream>

using namespace std;


List::List() 
{
	size = 0;
	head = nullptr;
}

List::~List()
{
	clear();
}

void List::add(const airTransport& transport)
{
  size++;
  if (head == nullptr) 
  {
    head = new Node;
    head->data = transport;
    head->next = nullptr;
  }
  else {
    Node *current = this->head;
    while (current->next != nullptr)
    {
      current = current->next;
    }
    current->next = new Node;
    current->next->data = transport;
    current->next->next = nullptr;
  }
}


void List::pop_front()
{
	if (head == nullptr) {
		// обработка ошибки или возврат из метода
		return;
	}
	Node* temp = head;
	head = head->next;
	delete temp;
	size--;
}

int List::length()
{
	return size;
}

void List::clear()
{
	while (size) 
	{
		pop_front();
	}
}

void List::show()
{
	for (int i = 0; i < this->size; i++) {
		cout << this->operator[](i) << endl << endl;
	}
}

void List::sort_by_engine_power()
{
	for (int i = 0; i < this->length(); i++) 
	{
		bool flag = true;
		for (int j = 0; j < this->length() - (i + 1); j++) {
			if (this->operator[](j).get_engine_power() > this->operator[](j + 1).get_engine_power()) {
				flag = false;
				std::swap(this->operator[](j), this->operator[](j + 1));
			}
		}
		if (flag) {
			break;
		}
	}
}

airTransport& List::operator[](const int index)
{
	int counter = 0;
	Node* current = this->head;
	while (current->next != nullptr) 
	{
		if (counter == index)
			return current->data;
		current = current->next;
		counter++;
	}
}

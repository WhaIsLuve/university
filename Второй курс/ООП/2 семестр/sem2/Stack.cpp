#include "Stack.h"
#include <stdexcept>

using namespace std;

Stack::~Stack()
{
	ToNull();
}

void Stack::Push(AirTransport& airTransport)
{
	Node* tmp = new Node;
	tmp->next = head;
	head = tmp;
	head->element = airTransport;
	size++;
}

AirTransport& Stack::Pop()
{
	if (IsEmpty()) throw out_of_range("Стек пуст!");
	Node* tmp = head;
	AirTransport air = tmp->element;
	head = head->next;
	delete(tmp);
	size--;
	return air;
}

bool Stack::IsEmpty()
{
	return size == 0 && head == nullptr;
}

void Stack::ToNull()
{
	while (!IsEmpty()) {
		Pop();
	}
}

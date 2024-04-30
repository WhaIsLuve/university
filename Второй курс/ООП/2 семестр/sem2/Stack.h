#pragma once
#include "AirTransport.h"
class Stack
{
	private:
		class Node {
			public:
				AirTransport element;
				Node *next;	
		};
		int size = 0;
		Node *head;
	public:
		~Stack();
		void Push(AirTransport& airTransport);
		AirTransport& Pop();
		bool IsEmpty();
		void ToNull();
};


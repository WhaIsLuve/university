#include "MyStack.h"

MyStack::~MyStack() {
    ToNull();
}

void MyStack::Push(IAirTransport& airTransport) {
    Node* newNode = new Node{ airTransport, head };
    head = newNode;
    ++size;
}

IAirTransport& MyStack::Pop() {
    if (IsEmpty()) {
        throw std::out_of_range("Stack is empty");
    }
    Node* oldHead = head;
    IAirTransport& element = head->element;
    head = head->next;
    delete oldHead;
    --size;
    return element;
}

bool MyStack::IsEmpty() {
    return head == nullptr;
}

void MyStack::ToNull() {
    while (!IsEmpty()) {
        Pop();
    }
}

void MyStack::SaveInFile()
{
    std::ofstream out;
    out.open(path);
    out.close();
    while (!IsEmpty()) {
        IAirTransport& a = Pop();
        a.SaveInFile(path);
    }
}

MyStack MyStack::LoadFromFile()
{
    MyStack stack;
    const char* path = "C:\\Users\\Влад\\Desktop\\Университет\\Второй курс\\ООП\\2 семестр\\cursOOP\\db\\MyStack.txt";
    AirTransport a;
    a.LoadFromFile(path);
    stack.Push(a);
    return stack;
}

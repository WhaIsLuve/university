#pragma once
#include "AirTransport.h"
#include <fstream>
#include <stdexcept>


class MyStack
{
private:
    class Node {
    public:
        IAirTransport& element;
        Node* next;
    };
    int size = 0;
    Node* head = nullptr; // Инициализация указателя
    const char* path = "C:\\Users\\Влад\\Desktop\\Университет\\Второй курс\\ООП\\2 семестр\\cursOOP\\db\\MyStack.json";
public:
    ~MyStack();
    void Push(IAirTransport& airTransport);
    IAirTransport& Pop();
    bool IsEmpty();
    void ToNull();
    void SaveInFile();
    static MyStack LoadFromFile();
};
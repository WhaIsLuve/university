#pragma once
#include<forward_list>
using namespace std;
class ListVoid
{
protected:
	forward_list<void*> list;
	int size;
	ListVoid() {
		list.clear();
	}
	void _push_front(void* const& pointer) {
		list.push_front(pointer);
		size++;
	}
	void _pop_front() {
		list.pop_front();
		size--;
	} 
	void* _front() {
		return list.front();
	}
	void _clear() {
		list.clear();
		size = 0;
	}
	bool _empty() {
		return list.empty();
	}
	void _resize(int n) {
		list.resize(n);
		size = n;
	}
	void _resize(int n, void* const& value) {
		list.resize(n, value);
		size = n;
	}
	int _size() {
		return size;
	}
};
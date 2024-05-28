#pragma once
#include "ListVoid.h"
#include "AirTransport.h"
template<class T>
class List : private ListVoid
{
public:
	void PushFront(const T& value) {
		_push_front((void* const&)value);
	}

	void PopFront() {
		_pop_front();
	}
	void Clear() {
		_clear();
	}
	bool Empty() {
		return _empty();
	}
	void Resize(int n) {
		_resize(n);
	}

	void Resize(int n, const T& value) {
		_resize(n, (void* const&)value);
	}

	int Size() {
		return _size();
	}
};


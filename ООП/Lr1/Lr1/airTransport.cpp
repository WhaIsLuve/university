#define _CRT_SECURE_NO_WARNINGS
#include "airTransport.h"
#include <iostream>
using namespace std;

int airTransport::Count = 0;

int airTransport::get_count() {
	return airTransport::Count;
}

airTransport::airTransport() {
	if (airTransport::Count > airTransport::max_count_airTransport) {
		cout << "Лимит по созданию объектов данного класса" << endl;
		return;
	}
	Engine_power = 10;
	Color_transport = color::Red;
	const char* m = "plane";
	Model = new char[strlen(m) + 1];
	strcpy(Model, m);
	Capacity = 10;
	airTransport::Count++;
}

airTransport::airTransport(int power, color colorTransport, const char* m, int capactity_transport) {
	if (airTransport::Count > airTransport::max_count_airTransport) {
		cout << "Лимит по созданию объектов данного класса" << endl;
		return;
	}
	Engine_power = power;
	Color_transport = colorTransport;
	Model = new char[strlen(m) + 1];
	strcpy(Model, m);
	Capacity = capactity_transport;
}

airTransport::~airTransport() {
	Count--;
	cout << this->Model << " уничтожен" << endl;
	delete[] Model;
}

int airTransport::get_engine_power() {
	return Engine_power;
}

void airTransport::set_engine_power(int power) {
	Engine_power = power;
}

int airTransport::get_capacity() {
	return Capacity;
}

void airTransport::set_capacity(int capacityTranport) {
	Capacity = capacityTranport;
}

char* airTransport::get_model() {
	return Model;
}

void airTransport::set_model(const char* m) {
	strcpy(Model, m);
}

color airTransport::get_color_transport() {
	return Color_transport;
}

void airTransport::set_color_transport(color colorTranport) {
	Color_transport = colorTranport;
}


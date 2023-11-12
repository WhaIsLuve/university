#define _CRT_SECURE_NO_WARNINGS
#include "airTransport.h"
#include <iostream>
using namespace std;

int airTransport::Count = 0;

int airTransport::get_count() 
{
	return airTransport::Count;
}

airTransport::airTransport() 
{
	if (airTransport::Count > airTransport::max_count_airTransport) {
		throw exception("Лимит по созданию объектов данного класса");
	}
	Engine_power = 10;
	Color_transport = color::Red;
	const char* m = "plane";
	Model = new char[strlen(m) + 1];
	strcpy(Model, m);
	Capacity = 10;
	airTransport::Count++;
}

airTransport::airTransport(int power, color colorTransport, const char* m, int capactity_transport) 
{
	if (airTransport::Count > airTransport::max_count_airTransport) {
		throw exception("Лимит по созданию объектов данного класса");
	}
	Engine_power = power;
	Color_transport = colorTransport;
	Model = new char[strlen(m) + 1];
	strcpy(Model, m);
	Capacity = capactity_transport;
}

airTransport::~airTransport() 
{
	Count--;
	cout << this->Model << " уничтожен" << endl;
	delete this->Model;
}

airTransport::airTransport(const airTransport& transport)
{
	Engine_power = transport.Engine_power;
	Color_transport = transport.Color_transport;
	Model = transport.Model;
	Capacity = transport.Capacity;
}

int airTransport::get_engine_power() 
{
	return Engine_power;
}

void airTransport::set_engine_power(int power) 
{
	Engine_power = power;
}

int airTransport::get_capacity() 
{
	return Capacity;
}

void airTransport::set_capacity(int capacityTranport) 
{
	Capacity = capacityTranport;
}

char* airTransport::get_model() 
{
	return Model;
}

void airTransport::set_model(const char* m) 
{
	strcpy(Model, m);
}

color airTransport::get_color_transport() 
{
	return Color_transport;
}

void airTransport::set_color_transport(color colorTranport) 
{
	Color_transport = colorTranport;
}

ostream& operator<<(ostream& out, const airTransport& transport) 
{
	out << "Engine power: " << transport.Engine_power << endl;
	out << "Color: " << static_cast<int>(transport.Color_transport) << endl;
	out << "Model: " << transport.Model << endl;
	out << "Capacity: " << transport.Capacity << endl;
	return out;
}

airTransport& airTransport::operator=(const airTransport& transport)
{
	if (&transport != this)
	{
		this->Engine_power = transport.Engine_power;
		this->Capacity = transport.Capacity;
		this->Color_transport = transport.Color_transport;
		this->Model = transport.Model;
	}
	return *this;
}
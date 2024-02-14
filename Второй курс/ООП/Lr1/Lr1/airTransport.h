#include "color.cpp"
#include <iostream>
#pragma once
class airTransport
{
	private:
		int Engine_power; // мощность транспорта
		color Color_transport; // цвет транспорта
		char* Model; // модель транспорта
		static int Count; // кол-во созданных объектов 
		int Capacity; // вместимость транспорта
	public:
		static const int max_count_airTransport = 10; // максимальное кол-во созданных объектов класса airTransport
		airTransport(); // конструктор по-умолчанию
		airTransport(int power, color colorTranport, const char* m, int capactity_transport); // конструктор класса
		airTransport(const airTransport& transport); // копирующий контсруктор
		~airTransport(); // деструктор классаефк

		int get_engine_power(); // получить значение engine_power
		void set_engine_power(int power); // задать значение engine_power

		color get_color_transport(); // получить значение color_transport
		void set_color_transport(color colorTransport); // задать значение color_transport

		char* get_model(); // получить значение model
		void set_model(const char* m); // задать значение model

		int get_capacity(); // получить значение capacity
		void set_capacity(int capacityTranport); // задать значение capacity

		
		int get_count(); // получить сколько создано объектов класса

		friend std::ostream& operator<<(std::ostream& out, const airTransport& transport);
		airTransport& operator=(const airTransport& transport);
		bool operator==(const airTransport& transport);
		bool operator>(const airTransport& transport);
		bool operator>=(const airTransport& transport);
		bool operator<(const airTransport& transport);
		bool operator<=(const airTransport& transport);
		friend bool operator!=(airTransport& transport, airTransport& transport2);
};


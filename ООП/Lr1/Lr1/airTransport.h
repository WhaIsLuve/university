#include "color.cpp"
#include <iostream>
#pragma once
class airTransport
{
	private:
		int Engine_power; // �������� ����������
		color Color_transport; // ���� ����������
		char* Model; // ������ ����������
		static int Count; // ���-�� ��������� �������� 
		int Capacity; // ����������� ����������
	public:
		static const int max_count_airTransport = 10; // ������������ ���-�� ��������� �������� ������ airTransport
		airTransport(); // ����������� ��-���������
		airTransport(int power, color colorTranport, const char* m, int capactity_transport); // ����������� ������
		airTransport(const airTransport& transport); // ���������� �����������
		~airTransport(); // ���������� ���������

		int get_engine_power(); // �������� �������� engine_power
		void set_engine_power(int power); // ������ �������� engine_power

		color get_color_transport(); // �������� �������� color_transport
		void set_color_transport(color colorTransport); // ������ �������� color_transport

		char* get_model(); // �������� �������� model
		void set_model(const char* m); // ������ �������� model

		int get_capacity(); // �������� �������� capacity
		void set_capacity(int capacityTranport); // ������ �������� capacity

		
		int get_count(); // �������� ������� ������� �������� ������

		friend std::ostream& operator<<(std::ostream& out, const airTransport& transport);
		airTransport& operator=(const airTransport& transport);
		bool operator==(const airTransport& transport);
		bool operator>(const airTransport& transport);
		bool operator>=(const airTransport& transport);
		bool operator<(const airTransport& transport);
		bool operator<=(const airTransport& transport);
		friend bool operator!=(airTransport& transport, airTransport& transport2);
};


#pragma once
#include "AirTransport.h"
class EngineAirTransport : public AirTransport
{
private:
	const char* path = "C:\\Users\\����\\Desktop\\�����������\\������ ����\\���\\2 �������\\cursOOP\\db\\EngineAirTransport.txt";
protected:
	double _enginePower;
	double _cargoCapacity;
public:
	EngineAirTransport(double enginePower, double cargoCapacity, double capacity, int weight);
	EngineAirTransport(double enginePower, double cargoCapacity);
	EngineAirTransport();
	double GetEnginePower();
	double GetCargoCapacity();
	void SetEnginePower(double enginePower);
	void SetCargoCapacity(double cargoCapacity);

	void virtual SaveInFile();
	void virtual SaveInFile(const char* path);
	void virtual LoadFromFile();
};


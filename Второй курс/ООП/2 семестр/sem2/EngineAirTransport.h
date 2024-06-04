#pragma once
#include "AirTransport.h"
class EngineAirTransport : public AirTransport
{
	protected:
		double _enginePower;
		double _cargoCapacity;
	public:
		EngineAirTransport(double enginePower, double cargoCapacity, double capacity, int weight);
		EngineAirTransport();
		double GetEnginePower();
		double GetCargoCapacity();
		void SetEnginePower(double enginePower);
		void SetCargoCapacity(double cargoCapacity);
		void Show();
		void SaveInFile(std::ofstream& f);
};


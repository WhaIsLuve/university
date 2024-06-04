#pragma once
#include "EngineAirTransport.h"
class WingyTransport : public EngineAirTransport
{
	private:
		int _countEngines;
	public:
		WingyTransport();
		WingyTransport(int countEngines, double cargoCapacity, double enginePower, int capacity, double weight);
		int GetCountEngines();
		void SetCountEngines(int countEngines);
		void Show();
		void SaveInFile(std::ofstream& f);
};
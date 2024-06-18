#pragma once
#include "EngineAirTransport.h"
class Rotorcraft : public EngineAirTransport
{
	private:
		int _countRotor;
	public:
		Rotorcraft();
		Rotorcraft(int countRotor, double cargoCapacity, double enginePower, int capacity, double weight);
		int GetCountRotor();
		void SetCountRotor(int countRotor);
		void Show();
		void SaveInFile(std::ofstream& f);
};
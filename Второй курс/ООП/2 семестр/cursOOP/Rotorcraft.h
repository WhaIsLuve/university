#pragma once
#include "EngineAirTransport.h"

class Rotorcraft : public EngineAirTransport
{
private:
	int _countRotor;
public:
	Rotorcraft();
	int GetCountRotor();
	void SetCountRotor(int countRotor);
};


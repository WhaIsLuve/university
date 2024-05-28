#pragma once
#include "AirTransport.h"
class ManualAirTransport : public AirTransport
{
protected:
	int _timeInAirInSeconds;
public:
	ManualAirTransport();
	ManualAirTransport(int timeInAirSec);
	ManualAirTransport(int timeInAirSec, int capacity, double weight);
	int GetTimeInAir();
	void SetTimeInAir(int timeInAirInSeconds);
};


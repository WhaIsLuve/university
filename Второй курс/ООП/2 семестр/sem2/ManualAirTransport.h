#pragma once
#include "AirTransport.h"
class ManualAirTransport : public AirTransport
{
	protected:
		int _timeInAirInSeconds;
	public:
		ManualAirTransport();
		int GetTimeInAir();
		void SetTimeInAir(int timeInAirInSeconds);
};


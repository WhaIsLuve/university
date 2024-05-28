#pragma once
#include "ManualAirTransport.h"
class BallonTransport : public ManualAirTransport
{
private:
	int _powerFire;
public:
	BallonTransport();
	int GetPowerFire();
	void SetPowerFire(int powerFire);
};


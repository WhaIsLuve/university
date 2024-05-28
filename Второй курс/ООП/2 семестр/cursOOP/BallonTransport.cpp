#include "BallonTransport.h"

BallonTransport::BallonTransport() : ManualAirTransport()
{
	_powerFire = 45;
}

int BallonTransport::GetPowerFire()
{
	return _powerFire;
}

void BallonTransport::SetPowerFire(int powerFire)
{
	_powerFire = powerFire;
}

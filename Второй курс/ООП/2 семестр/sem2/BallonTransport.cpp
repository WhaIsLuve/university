#include "BallonTransport.h"
#include <iostream>
#include "CheckValidation.h"

using namespace std;

BallonTransport::BallonTransport() : ManualAirTransport()
{
	_powerFire = 45;
}

BallonTransport::BallonTransport(int powerFire, int timeInAirSec, int capacity, double weight) : ManualAirTransport(timeInAirSec, capacity, weight)
{
	_powerFire = CheckValidation::CheckNumber(powerFire);
}

int BallonTransport::GetPowerFire()
{
	return _powerFire;
}

void BallonTransport::SetPowerFire(int powerFire)
{
	_powerFire = CheckValidation::CheckNumber(powerFire);
}

void BallonTransport::Show()
{
	cout << "BallonTransport" << endl;
	cout << "power fire: " << _powerFire << endl;
	cout << "time in air in seconds: " << _timeInAirInSeconds << endl;
	cout << "weight: " << _weight << endl;
	cout << "capacity: " << _capacity << endl;
}

void BallonTransport::SaveInFile(std::ofstream& f)
{
	f << "BallonTransport" << endl;
	f << _weight << endl;
	f << _capacity << endl;
	f << GetIsLanding() << endl;
	f << GetIsFlying() << endl;
	f << _powerFire << endl;
	f << _timeInAirInSeconds << endl;
}

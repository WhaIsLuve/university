#include "WingyTransport.h"
#include "CheckValidation.h"
#include <iostream>

using namespace std;

WingyTransport::WingyTransport() : EngineAirTransport(60, 70, 100, 46)
{
	_countEngines = 4;
}

WingyTransport::WingyTransport(int countEngines, double cargoCapacity, double enginePower, int capacity, double weight) : 
	EngineAirTransport(enginePower, cargoCapacity, capacity, weight)
{
	_countEngines = CheckValidation::CheckNumber(countEngines);
}

int WingyTransport::GetCountEngines()
{
	return _countEngines;
}

void WingyTransport::SetCountEngines(int countEngines)
{
	_countEngines = CheckValidation::CheckNumber(countEngines);
}

void WingyTransport::Show()
{
	cout << "WingyTransport" << endl;
	cout << "count of engines: " << _countEngines << endl;
	cout << "cargo capaciry: " << _cargoCapacity << endl;
	cout << "engine power: " << _enginePower << endl;
	cout << "weight: " << _weight << endl;
	cout << "capacity: " << _capacity << endl;
}

void WingyTransport::SaveInFile(std::ofstream& f)
{
	f << "WingyTransport" << endl;
	f << _weight << endl;
	f << _capacity << endl;
	f << GetIsLanding() << endl;
	f << GetIsFlying() << endl;
	f << _countEngines << endl;
	f << _cargoCapacity << endl;
	f << _enginePower << endl;
}
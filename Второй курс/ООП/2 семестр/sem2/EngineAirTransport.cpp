#include "EngineAirTransport.h"
#include "CheckValidation.h"
#include <iostream>
using namespace std;
EngineAirTransport::EngineAirTransport(double enginePower, double cargoCapacity, double capacity, int weight) : AirTransport(capacity, weight)
{
	_cargoCapacity = CheckValidation::CheckNumber(cargoCapacity);
	_enginePower = CheckValidation::CheckNumber(enginePower);
}
EngineAirTransport::EngineAirTransport() : AirTransport()
{
	_cargoCapacity = 20;
	_enginePower = 50;
}
double EngineAirTransport::GetEnginePower()
{
	return _enginePower;
}
double EngineAirTransport::GetCargoCapacity()
{
	return _cargoCapacity;
}
void EngineAirTransport::SetEnginePower(double enginePower)
{
	_enginePower = CheckValidation::CheckNumber(enginePower);
}
void EngineAirTransport::SetCargoCapacity(double cargoCapacity)
{
	_cargoCapacity = CheckValidation::CheckNumber(cargoCapacity);
}
void EngineAirTransport::Show()
{
	cout << "EngineAirTransport" << endl;
	cout << "cargo capaciry: " << _cargoCapacity << endl;
	cout << "engine power: " << _enginePower << endl;
	cout << "weight: " << _weight << endl;
	cout << "capacity: " << _capacity << endl;
}
void EngineAirTransport::SaveInFile(std::ofstream& f)
{
	f << "EngineAirTransport" << endl;
	f << _cargoCapacity << endl;
	f << _enginePower << endl;
	f << _weight << endl;
	f << _capacity << endl;
	f << GetIsLanding() << endl;
	f << GetIsFlying() << endl;
}
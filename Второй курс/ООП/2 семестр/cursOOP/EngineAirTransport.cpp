#include "EngineAirTransport.h"
#include "CheckValidation.h"
#include <fstream>

using namespace std;

EngineAirTransport::EngineAirTransport(double enginePower, double cargoCapacity, double capacity, int weight) : AirTransport(capacity, weight)
{
	_cargoCapacity = CheckValidation::CheckNumber(cargoCapacity);
	_enginePower = CheckValidation::CheckNumber(enginePower);
}

EngineAirTransport::EngineAirTransport(double enginePower, double cargoCapacity) : AirTransport()
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

void EngineAirTransport::SaveInFile()
{
	ofstream out;
	out.open(path);
	if (out.is_open()) {
		out << "EngineAirTransport" << " ";
		out << _cargoCapacity << " ";
		out << _enginePower << " ";
		out << _weight << " ";
		out << _capacity << " ";
		out << GetIsFlying() << " ";
		out << GetIsLanding() << " " << endl;
	}
	out.close();
}

void EngineAirTransport::SaveInFile(const char* path)
{
	ofstream out;
	out.open(path);
	if (out.is_open()) {
		out << "EngineAirTransport" << " ";
		out << _cargoCapacity << " ";
		out << _enginePower << " ";
		out << _weight << " ";
		out << _capacity << " ";
		out << GetIsFlying() << " ";
		out << GetIsLanding() << " " << endl;
	}
	out.close();
}

void EngineAirTransport::LoadFromFile()
{
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
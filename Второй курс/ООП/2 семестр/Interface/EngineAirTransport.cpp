#include "EngineAirTransport.h"
#include "CheckValidation.h"

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
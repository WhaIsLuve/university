#include "Rotorcraft.h"
#include "CheckValidation.h"
#include <iostream>
using namespace std;
Rotorcraft::Rotorcraft() : EngineAirTransport()
{
	_countRotor = 4;
}
Rotorcraft::Rotorcraft(int countRotor, double cargoCapacity, double enginePower, int capacity, double weight) :
	EngineAirTransport(enginePower, cargoCapacity, capacity, weight)
{
	_countRotor = CheckValidation::CheckNumber(countRotor);
}
int Rotorcraft::GetCountRotor()
{
	return _countRotor;
}
void Rotorcraft::SetCountRotor(int countRotor)
{
	_countRotor = CheckValidation::CheckNumber(countRotor);
}
void Rotorcraft::Show()
{
	cout << "Rotorcraft" << endl;
	cout << "count of rotor: " << _countRotor << endl;
	cout << "cargo capaciry: " << _cargoCapacity << endl;
	cout << "engine power: " << _enginePower << endl;
	cout << "weight: " << _weight << endl;
	cout << "capacity: " << _capacity << endl;
}
void Rotorcraft::SaveInFile(std::ofstream& f)
{
	f << "Rotorcraft" << endl;
	f << _weight << endl;
	f << _capacity << endl;
	f << GetIsLanding() << endl;
	f << GetIsFlying() << endl;
	f << _countRotor << endl;
	f << _cargoCapacity << endl;
	f << _enginePower << endl;
}
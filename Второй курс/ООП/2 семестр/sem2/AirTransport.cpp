#include "airTransport.h"
#include <exception>
#include <stdexcept>
#include "CheckValidation.h"
#include <iostream>
using namespace std;
AirTransport::AirTransport()
{
	_weight = 50;
	_capacity = 50;
	_isFlying = false;
	_isLanding = true;
}

AirTransport::AirTransport(int capacity, double weight)
{
	_capacity = CheckValidation::CheckNumber(capacity);
	_weight = CheckValidation::CheckNumber(weight);
	_isFlying = false;
	_isLanding = true;
}

int AirTransport::GetCapacity()
{
	return _capacity;
}

void AirTransport::SetCapacity(int capacity)
{
	_capacity = CheckValidation::CheckNumber(capacity);
}

double AirTransport::GetWeight()
{
	return _weight;
}

void AirTransport::SetWeight(double weight)
{
	_weight = CheckValidation::CheckNumber(weight);
}

bool AirTransport::GetIsFlying()
{
	return _isFlying;
}

bool AirTransport::GetIsLanding()
{
	return _isLanding;
}

void AirTransport::Fly()
{
	if (_isFlying && _isLanding) {
		throw runtime_error("Такого не может быть!!!!");
	}
	_isFlying = true;
	_isLanding = false;
}

void AirTransport::Land()
{
	if (_isFlying && _isLanding) {
		throw logic_error("Такого не может быть!!!!");
	}
	_isFlying = false;
	_isLanding = true;
}

void AirTransport::Show()
{
	cout << "AirTransport" << endl;
	cout << "weight: " << _weight << endl;
	cout << "capacity: " << _capacity << endl;
}

void AirTransport::SaveInFile(std::ofstream& f)
{
	f << "AirTransport" << endl;
	f << _weight << endl;
	f << _capacity << endl;
	f << _isLanding << endl;
	f << _isFlying << endl;
}

bool AirTransport::operator==(IAirTransport& transport)
{
	return this->GetWeight() == transport.GetWeight() && this->GetCapacity() == transport.GetCapacity();
}

bool AirTransport::operator>(IAirTransport& transport)
{
	return this->GetWeight() > transport.GetWeight() && this->GetCapacity() > transport.GetCapacity();
}

bool AirTransport::operator>=(IAirTransport& transport)
{
	return this->GetWeight() >= transport.GetWeight() && this->GetCapacity() >= transport.GetCapacity();
}

bool AirTransport::operator<(IAirTransport& transport)
{
	return this->GetWeight() < transport.GetWeight() && this->GetCapacity() < transport.GetCapacity();
}

bool AirTransport::operator<=(IAirTransport& transport)
{
	return this->GetWeight() <= transport.GetWeight() && this->GetCapacity() <= transport.GetCapacity();
}

bool AirTransport::operator!=(IAirTransport& transport)
{
	return this->GetWeight() != transport.GetWeight() && this->GetCapacity() != transport.GetCapacity();
}

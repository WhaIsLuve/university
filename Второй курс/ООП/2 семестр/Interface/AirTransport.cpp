#include "airTransport.h"
#include <exception>
#include <stdexcept>
#include "CheckValidation.h"

using namespace std;



AirTransport::AirTransport()
{
	_weight = 50;
	_capacity = 50;
	_isFlying = false;
	_isLanding = true;
}
AirTransport::AirTransport(int capacity = 50, double weight = 50)
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

bool AirTransport::operator==(const AirTransport& transport)
{
	return this->_weight == transport._weight && this->_capacity == transport._capacity;
}

bool AirTransport::operator>(const AirTransport& transport)
{
	return this->_weight > transport._weight && this->_capacity > transport._capacity;
}

bool AirTransport::operator>=(const AirTransport& transport)
{
	return this->_weight >= transport._weight && this->_capacity >= transport._capacity;
}

bool AirTransport::operator<(const AirTransport& transport)
{
	return this->_weight < transport._weight && this->_capacity < transport._capacity;
}

bool AirTransport::operator<=(const AirTransport& transport)
{
	return this->_weight <= transport._weight && this->_capacity <= transport._capacity;
}

bool AirTransport::operator!=(AirTransport& transport)
{
	return this->_weight != transport._weight && this->_capacity != transport._capacity;
}

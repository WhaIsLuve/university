#include "airTransport.h"
#include <exception>
#include "CheckValidation.h"

using namespace std;



AirTransport::AirTransport()
{
	_weight = 100;
	_capacity = 100;
	_isFlying = false;
	_isLanding = true;
}

AirTransport::AirTransport(int capacity, double weight)
{
	_capacity = CheckValidation::CheckNegative(capacity);
	_weight = CheckValidation::CheckNegative(weight);
	_isFlying = false;
	_isLanding = true;
}

int AirTransport::GetCapacity()
{
	return _capacity;
}

void AirTransport::SetCapacity(int capacity)
{
	_capacity = CheckValidation::CheckNegative(capacity);
}

double AirTransport::GetWeight()
{
	return _weight;
}

void AirTransport::SetWeight(double weight)
{
	_weight = CheckValidation::CheckNegative(weight);
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
	_isFlying = true;
	_isLanding = false;
}

void AirTransport::Land()
{
	_isFlying = false;
	_isLanding = true;
}

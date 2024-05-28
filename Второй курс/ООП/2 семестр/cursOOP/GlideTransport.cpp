#include "GlideTransport.h"
#include "CheckValidation.h"

GlideTransport::GlideTransport() : ManualAirTransport()
{
	_lengthWing = 20;
}

GlideTransport::GlideTransport(int length) : ManualAirTransport()
{
}

GlideTransport::GlideTransport(int length, int timeInAirSec, int capacity, double weight) : ManualAirTransport(timeInAirSec, capacity, weight)
{
	_lengthWing = CheckValidation::CheckNumber(length);
}

int GlideTransport::GetLengthWing()
{
	return _lengthWing;
}

void GlideTransport::SetLengthWing(int length)
{
	_lengthWing = CheckValidation::CheckNumber(length);
}

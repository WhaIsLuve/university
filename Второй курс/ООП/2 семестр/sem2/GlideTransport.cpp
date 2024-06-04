#include "GlideTransport.h"
#include "CheckValidation.h"
#include <iostream>

using namespace std;

GlideTransport::GlideTransport() : ManualAirTransport()
{
	_lengthWing = 20;
}

GlideTransport::GlideTransport(int length) : ManualAirTransport()
{
	_lengthWing = length;
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

void GlideTransport::Show()
{
	cout << "GlideTransport" << endl;
	cout << "length wing: " << _lengthWing << endl;
	cout << "time in air in seconds: " << _timeInAirInSeconds << endl;
	cout << "weight: " << _weight << endl;
	cout << "capacity: " << _capacity << endl;
}

void GlideTransport::SaveInFile(std::ofstream& f)
{
	f << "GlideTransport" << endl;
	f << _weight << endl;
	f << _capacity << endl;
	f << GetIsLanding() << endl;
	f << GetIsFlying() << endl;
	f << _lengthWing << endl;
	f << _timeInAirInSeconds << endl;
}
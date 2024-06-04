#include "ManualAirTransport.h"
#include "CheckValidation.h"
#include <iostream>

using namespace std;

ManualAirTransport::ManualAirTransport() : AirTransport(4, 25)
{
    _timeInAirInSeconds = 25;
}

ManualAirTransport::ManualAirTransport(int timeInAirSec, int capacity, double weight) : AirTransport(capacity, weight)
{
    _timeInAirInSeconds = CheckValidation::CheckNumber(timeInAirSec);
}

int ManualAirTransport::GetTimeInAir()
{
    return _timeInAirInSeconds;
}

void ManualAirTransport::SetTimeInAir(int timeInAirInSeconds)
{
    _timeInAirInSeconds = CheckValidation::CheckNumber(timeInAirInSeconds);
}

void ManualAirTransport::Show()
{
    cout << "ManualAirTransport" << endl;
    cout << "time in air in seconds: " << _timeInAirInSeconds << endl;
    cout << "weight: " << _weight << endl;
    cout << "capacity: " << _capacity << endl;

}

void ManualAirTransport::SaveInFile(std::ofstream& f)
{
    f << "ManualAirTransport" << endl;
    f << _timeInAirInSeconds << endl;
    f << _weight << endl;
    f << _capacity << endl;
    f << GetIsLanding() << endl;
    f << GetIsFlying() << endl;
}

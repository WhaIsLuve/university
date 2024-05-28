#include "ManualAirTransport.h"
#include "CheckValidation.h"

ManualAirTransport::ManualAirTransport() : AirTransport(4, 25)
{
    _timeInAirInSeconds = 25;
}

ManualAirTransport::ManualAirTransport(int timeInAirSec) : AirTransport()
{
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

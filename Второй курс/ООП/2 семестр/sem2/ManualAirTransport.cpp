#include "ManualAirTransport.h"
#include "CheckValidation.h"

ManualAirTransport::ManualAirTransport() : AirTransport(4, 25)
{
    _timeInAirInSeconds = 25;
}

int ManualAirTransport::GetTimeInAir()
{
    return _timeInAirInSeconds;
}

void ManualAirTransport::SetTimeInAir(int timeInAirInSeconds)
{
    _timeInAirInSeconds = CheckValidation::CheckNumber(timeInAirInSeconds);
}

#include "WingyTransport.h"
#include "CheckValidation.h"

WingyTransport::WingyTransport() : EngineAirTransport()
{
    _countEngines = 4;
}

int WingyTransport::GetCountEngines()
{
    return _countEngines;
}

void WingyTransport::SetCountEngines(int countEngines)
{
    _countEngines = CheckValidation::CheckNegative(countEngines);
}

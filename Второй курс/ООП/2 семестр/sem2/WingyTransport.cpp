#include "WingyTransport.h"
#include "CheckValidation.h"

WingyTransport::WingyTransport() : EngineAirTransport(60, 70, 100, 46)
{
    _countEngines = 4;
}

int WingyTransport::GetCountEngines()
{
    return _countEngines;
}

void WingyTransport::SetCountEngines(int countEngines)
{
    _countEngines = CheckValidation::CheckNumber(countEngines);
}

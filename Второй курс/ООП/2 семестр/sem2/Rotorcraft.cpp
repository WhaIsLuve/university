#include "Rotorcraft.h"
#include "CheckValidation.h"

Rotorcraft::Rotorcraft() : EngineAirTransport()
{
    _countRotor = 4;
}

int Rotorcraft::GetCountRotor()
{
    return _countRotor;
}

void Rotorcraft::SetCountRotor(int countRotor)
{
    _countRotor = CheckValidation::CheckNegative(countRotor);
}

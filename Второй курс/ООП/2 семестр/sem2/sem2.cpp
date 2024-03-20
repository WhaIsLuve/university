#include <iostream>
#include "AirTransport.h"
#include "EngineAirTransport.h"
#include "WingyTransport.h"
#include "Rotorcraft.h"
#include "BallonTransport.h"

using namespace std;

void getCapacity(IAirTransport& transport) {
    cout << "Вместимость" << transport.GetCapacity() << endl;
}

void getEnginePower(EngineAirTransport tranport) {
    cout << "Мощность двигателя" << tranport.GetEnginePower() << endl;
}

int main()
{
    setlocale(LC_ALL, "rus");
    WingyTransport wingy;
    Rotorcraft helicopter;
    BallonTransport ballon;
    getCapacity(wingy);
    getCapacity(helicopter);
    getCapacity(ballon);
    getEnginePower(wingy);
    getEnginePower(helicopter);
}
#include <iostream>
#include "AirTransport.h"
#include "EngineAirTransport.h"
#include "WingyTransport.h"
#include "Rotorcraft.h"
#include "BallonTransport.h"
#include "Dragonyd.h"

using namespace std;

void getCapacity(IAirTransport& transport) {
    cout << "Вместимость: " << transport.GetCapacity() << endl;
}

void getEnginePower(EngineAirTransport tranport) {
    cout << "Мощность двигателя: " << tranport.GetEnginePower() << endl;
}

int main()
{
    setlocale(LC_ALL, "rus");
    WingyTransport wingy;
    Rotorcraft helicopter;
    BallonTransport ballon;
    Dragonyd dragon;
    getCapacity(wingy);
    getCapacity(helicopter);
    getCapacity(ballon);
    getCapacity(dragon);
    getEnginePower(wingy);
    getEnginePower(helicopter);
    try {
        dragon.SetCountEyes(-100);
    }
    catch (exception ex) {
        cout << "ПОЙМАНО ИСКЛЮЧЕНИЕ:" << ex.what() << endl;
    }
}
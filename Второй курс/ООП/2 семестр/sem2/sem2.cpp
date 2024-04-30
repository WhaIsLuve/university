#include <iostream>
#include "AirTransport.h"
#include "EngineAirTransport.h"
#include "WingyTransport.h"
#include "Rotorcraft.h"
#include "BallonTransport.h"
#include "Stack.h"

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
    Stack st;
    st.Push(wingy);
    st.Push(helicopter);
    st.Push(ballon);
    st.ToNull();
    /*getCapacity(wingy);
    getCapacity(helicopter);
    getCapacity(ballon);
    getEnginePower(wingy);
    getEnginePower(helicopter);
    try {
        dragon.SetCountEyes(-100);
    }
    catch (exception ex) {
        cout << "ПОЙМАНО ИСКЛЮЧЕНИЕ:" << ex.what() << endl;
    }*/
}
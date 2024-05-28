#include <iostream>
#include "AirTransport.h"
#include "EngineAirTransport.h"
#include "WingyTransport.h"
#include "Rotorcraft.h"
#include "BallonTransport.h"
#include "Stack.h"
#include "List.h"

using namespace std;

void getCapacity(IAirTransport& transport) {
    cout << "Вместимость: " << transport.GetCapacity() << endl;
}

void getEnginePower(EngineAirTransport tranport) {
    cout << "Мощность двигателя: " << tranport.GetEnginePower() << endl;
}

int main234()
{
    setlocale(LC_ALL, "rus");
    WingyTransport wingy;
    Rotorcraft helicopter;
    BallonTransport ballon;
    Stack st;
    List<AirTransport> list;
    st.Push(wingy);
    list.PushFront(wingy);
    st.Push(helicopter);
    list.PushFront(ballon);
    st.Push(ballon);
    list.PushFront(helicopter);
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
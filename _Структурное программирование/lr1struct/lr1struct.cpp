#include <iostream>

using namespace std;


struct AEROFLOT {
    char* destination;
    char* dateTimeDeparture;
};


int main()
{
    AEROFLOT aer{};
    cin >> aer.destination;
    cout << aer.destination;

    delete aer.destination;
    delete aer.dateTimeDeparture;
}
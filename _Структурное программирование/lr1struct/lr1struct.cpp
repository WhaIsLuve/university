#include <iostream>
#include <string>

using namespace std;


struct AEROFLOT {
    string destination;
    string dateTimeDeparture;
    string dateTimeArrival;
};


int main()
{
    setlocale(LC_ALL, "rus");
    AEROFLOT arrayAeroflot[5];
    AEROFLOT arrayNeed[5];
    int indexArrayNeed = 0;
    string dateTimeDeparturee;
    for (int i = 0; i < 5; i++)
    {
        cout << "Введите пункт назначение" << endl;
        cin >> arrayAeroflot[i].destination;
        cout << "Введите время отправления в формате DD.MM.YYYY" << endl;
        cin >> arrayAeroflot[i].dateTimeDeparture;
        cout << "Введите время прибытия в формате DD.MM.YYYY" << endl;
        cin >> arrayAeroflot[i].dateTimeArrival;
    }
    cout << "Введите нужное время отправления в формате DD.MM.YYYY" << endl;
    cin >> dateTimeDeparturee;
    for (int i = 0; i < 5; i++) 
    {
        if (dateTimeDeparturee == arrayAeroflot[i].dateTimeDeparture)
        {
            arrayNeed[indexArrayNeed] = arrayAeroflot[i];
            indexArrayNeed++;
        }
    }
    if (indexArrayNeed == 0) {
        cout << "\n\n\nНеобходимых рейсов нет" << endl;
    }
    else {
        cout << "\n\n\nНебоходимые рейсы:" << endl;
        for (int i = 0; i < indexArrayNeed; i++)
        {
            cout << arrayNeed[i].destination << endl;
            cout << arrayNeed[i].dateTimeDeparture << endl;
        }
    }
}
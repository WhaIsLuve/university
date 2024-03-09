#include <iostream>
#include <string>

using namespace std;


struct AEROFLOT {
    string destination;
    string time;
    string date;
};


int main()
{
    setlocale(LC_ALL, "rus");
    const int n = 5;
    AEROFLOT arrayAeroflot[n];
    AEROFLOT arrayNeed[n];
    int indexArrayNeed = 0;
    string dateDeparturee;
    for (int i = 0; i < n; i++)
    {
        cout << "Введите пункт назначение" << endl;
        cin >> arrayAeroflot[i].destination;
        cout << "Введите время отправления в формате HH.MM" << endl;
        cin >> arrayAeroflot[i].time;
        cout << "Введите дату отправления в формате DD.MM.YYYY" << endl;
        cin >> arrayAeroflot[i].date;
    }
    cout << "Введите нужную дату отправления в формате DD.MM.YYYY" << endl;
    cin >> dateDeparturee;
    for (int i = 0; i < n; i++) 
    {
        if (dateDeparturee == arrayAeroflot[i].date)
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
            cout << arrayNeed[i].time << endl;
        }
    }
}
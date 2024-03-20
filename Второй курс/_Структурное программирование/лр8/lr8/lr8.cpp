#include <iostream>
#include <fstream>

using namespace std;

double randomDouble()
{
    return (double)(rand()) / (double)(rand());
}

void var17num1() {
    fstream file;
    const char* name = "file.bin";
    int countNumbers;
    cout << "Введите сколько вы хотите записанных чисел в файл?" << endl;
    cin >> countNumbers;
    double randomNumber = randomDouble();
    file.open(name, ios::binary | ios::out);
    if (file.is_open())
    {
        for (int i = 1; i <= countNumbers; i++) {
            file.write((char*)&randomNumber, sizeof(double));
            randomNumber = randomDouble();
        }
    }
    file.close();

    float number;
    cout << "Введите вещественное число " << endl;
    cin >> number;

    double x;
    int count = 0;

    file.open(name, ios::binary | ios::in);
    if (file.is_open())
    {
        while(true) {
            file.read((char*)&x, sizeof(double));
            if (x < number) count++;
            if (file.eof()) break;
        }
    }
    file.close();
    cout << count;
}

int randomInt() {
    int number = rand();
    if (rand() % 2 == 0) {
        return number;
    }
    return -1 * number;
}

void var17num2() {
    int matrix[3][3];
    const char* fileF = "f.bin";
    const char* fileG = "g.bin";
    fstream fileFStream;
    fstream fileGStream;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            matrix[i][j] = randomInt();
        }
    }

    fileFStream.open(fileF, ios::binary | ios::out);
    fileFStream.write((char*)&matrix, sizeof(matrix));
    fileFStream.close();

    fileFStream.open(fileF, ios::binary | ios::in);
    fileGStream.open(fileG, ios::binary | ios::out);

    int x;
    int count = 0;

    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            fileFStream.read((char*)&x, sizeof(int));
            if (x < 0) {
                count++;
                fileGStream.write((char*)&x, sizeof(int));
            }
        }
    }

    fileFStream.close();
    fileGStream.close();

    fileGStream.open(fileG, ios::binary | ios::in);
    if (fileGStream.is_open())
    {
        for (int i = 0; i < count; i++) {
            fileGStream.read((char*)&x, sizeof(int));
            cout << x << endl;
        }
    }
    fileGStream.close();

}


int main()
{
    setlocale(LC_ALL, "rus");
    var17num1();
}


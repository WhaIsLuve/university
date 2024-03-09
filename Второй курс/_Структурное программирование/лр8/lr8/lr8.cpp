#include <iostream>
#include <fstream>

using namespace std;

double randomFloat()
{
    return (double)(rand()) / (double)(rand());
}

void var17num1() {
    fstream file;
    double numbers[10];
    const char* name = "file.bin";
    for (int i = 0; i < 10; i++) {
        numbers[i] = randomFloat();
    }
    file.open(name, ios::binary | ios::out);
    if (file.is_open())
    {
        for (int i = 1; i < 10; i++) {
            file.write((char*)&numbers[i], sizeof(double));
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
        for (int i = 1; i < 10; i++) {
            file.read((char*)&x, sizeof(double));
            if (x < number) count++;
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
    var17num2();
}


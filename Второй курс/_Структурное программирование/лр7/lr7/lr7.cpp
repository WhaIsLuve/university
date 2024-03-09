#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    ofstream out;
    out.open("file.txt");      
    if (out.is_open())
    {
        for (int i = 1; i < 10; i++) {
            for (int j = 0; j < i; j++) {
                out << i;
            }
        out << endl;
        }
    }
    out.close();
}

#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

using namespace std;

int main()
{
   const int len = 100;

    char string[len];
    cin.get(string, len);
    char* word = strtok(string, ",");
    while (word != NULL)
    {
        if (word[strlen(word) - 1] == 'w') {
            cout << word << endl;
        }
        word = strtok(NULL, ",");
    }
}

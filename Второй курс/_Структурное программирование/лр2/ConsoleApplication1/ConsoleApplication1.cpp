#include <iostream>

using namespace std;

int main()
{
    const int len = 100;

    char string[len];
    cin.get(string, len);
    int indexForWord = 0;
    char word[len];
    for (int i = 0; i < len; i++)
    {
        if (string[i] == ',' || string[i] == '\0') {
            if (word[indexForWord-1] == 'w') {
                for (int j = 0; j < indexForWord; j++)
                {
                    cout << word[j];
                }
                if(string[i] != '\0')
                    cout << endl;
            }
            indexForWord = 0;
            memset(word, 0, len);
        }
        else {
            word[indexForWord] = string[i];
            indexForWord++;
        }
    }
}

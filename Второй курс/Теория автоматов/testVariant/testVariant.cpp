#include <iostream>
#include <string>
#include <algorithm>
using namespace std;
int main() {
    string str;
    getline(cin, str);
    string newStr;
    int vowelCount = 0;
    string vowels = "aeiouAEIOU";
    for (int i = 0; i < str.length(); i++) {
        if (str[i] == ' ') {
            if (i > 0) {
                newStr += toupper(str[++i]);
            }
        }
        else {
            newStr += str[i];
        }
        for (int j = 0; j < vowels.length(); j++) {
            if (str[i] == vowels[j]) {
                vowelCount++;
                break;
            }
        }
    }
    cout << "Number of vowels " << vowelCount << endl;
    cout << newStr << endl;
    return 0;
}
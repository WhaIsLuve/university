#include <iostream>

using namespace std;

const int N = 3;

int lastNegative(int* arr) {
    int last_negative = -1;
    for (int i = 0; i < N; i++) {
        if (arr[i] < 0) {
            last_negative = i;
        }
    }
    return last_negative;
}

float lastNegative(float* arr) {
    float last_negative = -1;
    for (int i = 0; i < N; i++) {
        if (arr[i] < 0) {
            last_negative = i;
        }
    }
    return last_negative;
}

int lastNegative(char* arr) {
    return -1;
}

int countDigits(int* arr) {
    int count_digits = 0;
    for (int i = 0; i < N; i++) {
        if (arr[i] >= 0 && arr[i] <= 9) {
            count_digits++;
        }
    }
    return count_digits;
}

int countDigits(float* arr) {
    int count_digits = 0;
    for (int i = 0; i < N; i++) {
        if (arr[i] >= 0 && arr[i] <= 9 && (double)((int)arr[i]) == arr[i]) {
            count_digits++;
        }
    }
    return count_digits;
}

int countDigits(char* arr) {
    int count_digits = 0;
    for (int i = 0; i < N; i++) {
        if (arr[i] >= '1' && arr[i] <= '9') {
            count_digits++;
        }
    }
    return count_digits;
}


int main() {
    setlocale(LC_ALL, "rus");
    char arr[N];
    for (int i = 0; i < N; i++) {
        cin >> arr[i];
    }

    int count_digits = countDigits(arr);

    cout << "Количество цифр: " << count_digits << endl;
    int last_negative = lastNegative(arr);
    if (last_negative == -1) {
        cout << "Нет отрицательных элементов" << endl;
    }
    else {
        cout << "Последний отрицательный элемент: " << arr[last_negative] << endl;
    }

    return 0;
}
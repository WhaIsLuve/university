#include <iostream>

int var17(int n) {
    int sum = 0;
    while (n != 0) {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

int var17recurs(int n) {
    if (n == 0) {
        return n;
    }
    return n % 10 + var17recurs(n / 10);
}

void var17recurs(int n, int* sum) {
    if (n > 0) {
        *sum += n % 10;
        var17recurs(n / 10, sum);
    }
}

int main()
{
    setlocale(LC_ALL, "rus");
    int n;
    std::cin >> n;
    int sum = 0;

    std::cout << "Не рекурсивная функция " << var17(n) << '\n';
    std::cout << "Рекурсивный функция с return " << var17recurs(n) << '\n';

    var17recurs(n, &sum);

    std::cout << "Рекурсивный функция без return " << sum;
}

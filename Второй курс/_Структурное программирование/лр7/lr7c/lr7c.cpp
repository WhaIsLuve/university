#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
    const char* filename = "C:\\Users\\Влад\\Desktop\\Университет\\Второй курс\\_Структурное программирование\\лр7\\lr7c\\file.txt";
    int number = 49; // 49-57 - номер цифр в ascii таблице
    const int n = 10;
    FILE* file;
    file = fopen(filename, "w");
    for (int i = 1; i < 10; i++) {
        for (int j = 0; j < i; j++) {
            fputc(number, file);
        }
        fputc(n, file);
        number++;
    }
    fclose(file);
    return 0;
}
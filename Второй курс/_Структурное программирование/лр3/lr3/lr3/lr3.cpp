#include <iostream>
#include "lr3.h"
using namespace std;


float area(float a, float b, float h)
{
	float sbok = 2 * (a + b) * h;
	float spol = sbok * 2 * (a * b);
	return spol;
}


float volume(float a, float b, float h)
{
	float v = a * b * h;
	return v;
}

void input(float* array, int length) {
	for (int i = 0; i < length; i++) {
		cin >> array[i];
	}
}


void output(float* array, int length) {
	cout << "Элементы массива: ";
	for (int i = 0; i < length; i++) {
		cout << array[i] << " ";
	}
	cout << endl;
}


int main()
{
	setlocale(LC_ALL, "rus");
	float a, b, h;
	cout << "Введите длину сторон прямоугольника через пробел: ";
	cin >> a >> b;
	cout << "Введите высоту прямоугольной призмы: ";
	cin >> h;
	float s, v;
	s = area(a, b, h);
	v = volume(a, b, h);
	cout << "Площадь поверхности прямоугольной призмы: " << s << endl;
	cout << "Объем прямоугольной призмы: " << v << endl;
	return 0;
}

int main2()
{
	setlocale(LC_ALL, "rus");
	int n;
	int pos = 1, neg = 1;
	cout << "Введите длину массива: ";
	cin >> n;
	float* array = new float[n];
	input(array, n);
	output(array, n);
	for (int i = 0; i < n; i++)
	{
		if (array[i] == 0) continue;
		if (array[i] > 0) pos *= array[i];
		if (array[i] < 0) neg *= array[i];
	}
	float absPos = abs(pos);
	float absNeg = abs(neg);
	if (absPos > absNeg) {
		cout << "Произведение положительных элементов больше." << endl;
	}
	else {
		cout << "Произведение отрицательных элементов больше." << endl;
	}
	delete[] array;
	return 0;
}
#include <exception>
#include "CheckValidation.h"
using namespace std;

double CheckValidation::CheckNegative(double number)
{
	if (number < 0) {
		throw exception("����� �� ����� ���� �������������!!!");
	}
	return number;
}

int CheckValidation::CheckNegative(int number)
{
	if (number < 0) {
		throw exception("����� �� ����� ���� �������������!!!");
	}
	return number;
}

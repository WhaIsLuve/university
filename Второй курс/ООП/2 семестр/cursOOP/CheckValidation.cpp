#include "CheckValidation.h"
#include <stdexcept>
using namespace std;

int CheckValidation::CheckNumber(int number)
{
	if (number < 0) {
		throw invalid_argument("����� �� ����� ���� �������������!!!");
	}
	else if (number > 100) {
		throw overflow_error("����� �� ������ ���� ������ 100");
	}
	return number;
}

double CheckValidation::CheckNumber(double number)
{
	if (number < 0) {
		throw invalid_argument("����� �� ����� ���� �������������!!!");
	}
	else if (number > 100) {
		throw overflow_error("����� �� ������ ���� ������ 100");
	}
	return number;
}

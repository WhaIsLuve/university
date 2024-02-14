#include <iostream>

const double E = 0.00005;

double var17(double x) {
	double sum = 0;
	int i = 1;
	double pr = pow(x, 2*i-1)/ (2 * i - 1);
	while (abs(pr) > E) {
		sum += pr;
		i = i + 1;
		pr = pow(x, 2 * i - 1) / (2 * i - 1);
	}

	return sum;
}

void var17(double* x, double* sum) {
	*sum = 0;
	int i = 1;
	double pr = pow(*x, 2 * i - 1) / (2 * i - 1);
	while (abs(pr) > E) {
		*sum += pr;
		i = i + 1;
		pr = pow(*x, 2 * i - 1) / (2 * i - 1);
	}
}

double& var17(double& x, double& sum) {
	sum = 0;
	int i = 1;
	double pr = pow(x, 2 * i - 1) / (2 * i - 1);
	while (abs(pr) > E) {
		sum += pr;
		i = i + 1;
		pr = pow(x, 2 * i - 1) / (2 * i - 1);
	}

	return sum;
}

int main()
{
	double x = 0.10;
	double res1;
	double res2;
	int i;
	std::cin >> i;
	switch (i)
	{
		case 1:
			std::cout << var17(x);
			break;
		case 2:
			var17(&x, &res1);
			std::cout << res1;
			break;
		case 3:
			var17(x, res2);
			std::cout << res2;
			break;
		default:
			break;
	}
}

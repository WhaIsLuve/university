#include "airTransport.h"
#include "List.h"
#include <iostream>

using namespace std;
int main() 
{
	setlocale(LC_ALL,"rus");
	airTransport a;
	airTransport x(500, color::White, "rocket", 20);
	airTransport b(23, color::Black, "helicopter", 8);
	List lst;
	lst.add(a);
	lst.add(x);
	lst.add(b);

	lst.show();

	lst.sort_by_engine_power();

	lst.show();

	return 1;
}
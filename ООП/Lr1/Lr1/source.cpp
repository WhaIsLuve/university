#include "airTransport.h"
#include "List.h"
#include "List.cpp"

#include <iostream>

using namespace std;
int main() 
{
	setlocale(LC_ALL,"rus");
	airTransport a;
	airTransport x(500, color::White, "rocket", 20);
	airTransport b(23, color::Black, "helicopter", 8);
	List<airTransport> lst;
	lst.add(x);
	lst.add(b);
	lst.add(a);
	lst.show();
	return 1;
}
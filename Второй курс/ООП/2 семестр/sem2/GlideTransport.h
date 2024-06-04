#pragma once
#include "ManualAirTransport.h"

class GlideTransport : public ManualAirTransport
{
private:
	int _lengthWing;

public:
	GlideTransport();
	GlideTransport(int length);
	GlideTransport(int length, int timeInAirSec, int capacity, double weight);
	int GetLengthWing();
	void SetLengthWing(int length);
	void Show();
	void SaveInFile(std::ofstream& f);
};
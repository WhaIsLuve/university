#pragma once
#include "ManualAirTransport.h"
class BallonTransport : public ManualAirTransport
{
	private:
		int _powerFire;
	public:
		BallonTransport();
		BallonTransport(int powerFire, int timeInAirSec, int capacity, double weight);
		int GetPowerFire();
		void SetPowerFire(int powerFire);
		void Show();
		void SaveInFile(std::ofstream& f);
};
#pragma once
#include "IAirTransport.h"
class AirTransport : public IAirTransport
{
	private:
		bool _isFlying;
		bool _isLanding;
	protected:
		int _capacity;
		double _weight;
	public:
		AirTransport();
		AirTransport(int capacity, double weight);
		int GetCapacity();
		void SetCapacity(int capacity);
		double GetWeight();
		void SetWeight(double weight);
		bool GetIsFlying();
		bool GetIsLanding();
		void Fly();
		void Land();
		void Show();
		void SaveInFile(std::ofstream& f);
		bool operator==(IAirTransport& transport);
		bool operator>(IAirTransport& transport);
		bool operator>=(IAirTransport& transport);
		bool operator<(IAirTransport& transport);
		bool operator<=(IAirTransport& transport);
		bool operator!=(IAirTransport& transport);
};


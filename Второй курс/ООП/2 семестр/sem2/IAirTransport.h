#pragma once
#include <fstream>
class IAirTransport
{
	public:
		virtual int GetCapacity() = 0;
		virtual double GetWeight() = 0;
		virtual bool GetIsFlying() = 0;
		virtual bool GetIsLanding() = 0;
		virtual void Fly() = 0;
		virtual void Land() = 0;
		virtual void Show() = 0;
		virtual void SaveInFile(std::ofstream& f) = 0;
		virtual bool operator==(IAirTransport& transport) = 0;
		virtual bool operator>(IAirTransport& transport) = 0;
		virtual bool operator>=(IAirTransport& transport) = 0;
		virtual bool operator<(IAirTransport& transport) = 0;
		virtual bool operator<=(IAirTransport& transport) = 0;
		virtual bool operator!=(IAirTransport& transport) = 0;
};


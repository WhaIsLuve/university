#pragma once
class IAirTransport
{
public:
	virtual int GetCapacity() = 0;

	virtual double GetWeight() = 0;

	virtual bool GetIsFlying() = 0;

	virtual bool GetIsLanding() = 0;

	virtual void Fly() = 0;

	virtual void Land() = 0;

	virtual void SaveInFile() = 0;
	virtual void SaveInFile(const char* path) = 0;

	virtual void LoadFromFile() = 0;
	virtual void LoadFromFile(const char* path) = 0;
};


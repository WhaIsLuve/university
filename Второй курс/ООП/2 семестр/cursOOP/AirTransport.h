#pragma once
#include "IAirTransport.h"
#include <nlohmann/json.hpp>

class AirTransport : public IAirTransport
{
private:
	bool _isFlying;
	bool _isLanding;
	const char* path = "C:\\Users\\Влад\\Desktop\\Университет\\Второй курс\\ООП\\2 семестр\\cursOOP\\db\\AirTransport.json";
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

	virtual void SaveInFile();
	virtual void SaveInFile(const char* path);

	virtual void LoadFromFile();
	virtual void LoadFromFile(const char* path);

	bool operator==(const AirTransport& transport);
	bool operator>(const AirTransport& transport);
	bool operator>=(const AirTransport& transport);
	bool operator<(const AirTransport& transport);
	bool operator<=(const AirTransport& transport);
	bool operator!=(AirTransport& transport);
};


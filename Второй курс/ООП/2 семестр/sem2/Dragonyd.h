#pragma once
#include "AirTransport.h"
#include "FantasyAirTransport.h"
class Dragonyd : public AirTransport, public FantasyAirTransport
{
protected:
	int countEyes;
	int intelligence;
	int agressive;
public:
	Dragonyd();
	Dragonyd(int count, int intelligence, int agressive, int capacity, int weight, bool isHaveWings, bool isPeaceful);
	int GetCountEyes();
	void SetCountEyes(int count);
	int GetIntelligence();
	void SetIntelligence(int intelligence);
	int GetAgressive();
	void SetAgressive(int agressive);
};


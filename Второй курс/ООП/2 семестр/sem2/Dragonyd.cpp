#include "Dragonyd.h"
#include "CheckValidation.h"

Dragonyd::Dragonyd() : FantasyAirTransport(), AirTransport(5, 100)
{
	countEyes = 2;
	intelligence = 40;
	agressive = 70;
}

Dragonyd::Dragonyd(int count, 
	int intelligence, 
	int agressive, 
	int capacity, 
	int weight, 
	bool isHaveWings, 
	bool isPeaceful) : AirTransport(capacity, weight), FantasyAirTransport(true, isHaveWings, isPeaceful)
{
	this->countEyes = CheckValidation::CheckNumber(count);
	this->intelligence = CheckValidation::CheckNumber(intelligence);
	this->agressive = CheckValidation::CheckNumber(agressive);
}

int Dragonyd::GetCountEyes()
{
	return countEyes;
}

void Dragonyd::SetCountEyes(int count)
{
	this->countEyes = CheckValidation::CheckNumber(count);
}

int Dragonyd::GetIntelligence()
{
	return intelligence;
}

void Dragonyd::SetIntelligence(int intelligence)
{
	this->intelligence = CheckValidation::CheckNumber(intelligence);
}

int Dragonyd::GetAgressive()
{
	return agressive;
}

void Dragonyd::SetAgressive(int agressive)
{
	this->agressive = CheckValidation::CheckNumber(agressive);
}

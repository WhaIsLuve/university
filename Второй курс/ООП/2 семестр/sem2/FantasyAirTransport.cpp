#include "FantasyAirTransport.h"

FantasyAirTransport::FantasyAirTransport()
{
	isHaveTeaths = isHaveWings = isPeaceful = false;
}

FantasyAirTransport::FantasyAirTransport(bool isHaveTeaths, bool isHaveWings, bool isPeaceful)
{
	this->isHaveTeaths = isHaveTeaths;
	this->isHaveWings = isHaveWings;
	this->isPeaceful = isPeaceful;
}

bool FantasyAirTransport::GetIsHaveTeaths()
{
	return isHaveTeaths;
}

void FantasyAirTransport::SetIsHaveTeaths(bool isHaveTeaths)
{
	this->isHaveTeaths = isHaveTeaths;
}

bool FantasyAirTransport::GetIsHaveWings()
{
	return isHaveWings;
}

void FantasyAirTransport::SetIsHaveWings(bool isHaveWings)
{
	this->isHaveWings = isHaveWings;
}

bool FantasyAirTransport::GetIsPeaceful()
{
	return isPeaceful;
}

void FantasyAirTransport::SetIsPeaceful(bool isPeaceful)
{
	this->isPeaceful = isPeaceful;
}

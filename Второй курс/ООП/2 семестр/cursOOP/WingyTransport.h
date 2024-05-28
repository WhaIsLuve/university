#pragma once
#include "EngineAirTransport.h"
class WingyTransport : public EngineAirTransport
{
private:
	int _countEngines;
public:
	WingyTransport();
	int GetCountEngines();
	void SetCountEngines(int countEngines);
};


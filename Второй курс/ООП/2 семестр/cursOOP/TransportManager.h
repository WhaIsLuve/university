#pragma once
#include "AirTransport.h"
#include "MyStack.h"
class TransportManager
{
	MyStack st;
	public: 
		void CreateAirTransport(int capacity, double weight);
};


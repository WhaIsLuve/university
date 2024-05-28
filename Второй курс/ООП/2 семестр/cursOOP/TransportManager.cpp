#include "TransportManager.h"

void TransportManager::CreateAirTransport(int capacity, double weight)
{
	AirTransport airTransport(capacity, weight);
	airTransport.SaveInFile();
	/*st.Push(airTransport);
	st.SaveInFile();*/
}

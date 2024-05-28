#include "airTransport.h"
#include <exception>
#include <stdexcept>
#include "CheckValidation.h"
#include <iostream>
#include <fstream>

using namespace std;
using namespace nlohmann;


AirTransport::AirTransport()
{
	_weight = 50;
	_capacity = 50;
	_isFlying = false;
	_isLanding = true;
}
AirTransport::AirTransport(int capacity = 50, double weight = 50)
{
	_capacity = CheckValidation::CheckNumber(capacity);
	_weight = CheckValidation::CheckNumber(weight);
	_isFlying = false;
	_isLanding = true;
}

int AirTransport::GetCapacity()
{
	return _capacity;
}

void AirTransport::SetCapacity(int capacity)
{
	_capacity = CheckValidation::CheckNumber(capacity);
}

double AirTransport::GetWeight()
{
	return _weight;
}

void AirTransport::SetWeight(double weight)
{
	_weight = CheckValidation::CheckNumber(weight);
}

bool AirTransport::GetIsFlying()
{
	return _isFlying;
}

bool AirTransport::GetIsLanding()
{
	return _isLanding;
}

void AirTransport::Fly()
{
	if (_isFlying && _isLanding) {
		throw runtime_error("Такого не может быть!!!!");
	}
	_isFlying = true;
	_isLanding = false;
}

void AirTransport::Land()
{
	if (_isFlying && _isLanding) {
		throw logic_error("Такого не может быть!!!!");
	}
	_isFlying = false;
	_isLanding = true;
}

void AirTransport::SaveInFile()
{
	ofstream out;
	json j{};
	j["capacity"] = _capacity;
	j["weight"] = _weight;
	j["additionalInformation"] = NULL;
	out.open(path);
	out << j;
	out.close();
}

void AirTransport::SaveInFile(const char* path)
{
	ofstream out;
	json j{};
	j["stack"];
	j["capacity"] = _capacity;
	j["weight"] = _weight;
	j["additionalInformation"] = NULL;
	out.open(path);
	out << j;
	out.close();
}

void AirTransport::LoadFromFile()
{
	json j{};
	std::string str = std::string((std::istreambuf_iterator<char>(std::ifstream(path))), std::istreambuf_iterator<char>());
	j = j.parse(str);
	SetCapacity(j["capacity"].get<int>());
	SetWeight(j["weight"].get<double>());
}

void AirTransport::LoadFromFile(const char* path)
{
	json j{};
	std::string str = std::string((std::istreambuf_iterator<char>(std::ifstream(path))), std::istreambuf_iterator<char>());
	j = j.parse(str);
	SetCapacity(j["capacity"].get<int>());
	SetWeight(j["weight"].get<double>());
}

bool AirTransport::operator==(const AirTransport& transport)
{
	return this->_weight == transport._weight && this->_capacity == transport._capacity;
}

bool AirTransport::operator>(const AirTransport& transport)
{
	return this->_weight > transport._weight && this->_capacity > transport._capacity;
}

bool AirTransport::operator>=(const AirTransport& transport)
{
	return this->_weight >= transport._weight && this->_capacity >= transport._capacity;
}

bool AirTransport::operator<(const AirTransport& transport)
{
	return this->_weight < transport._weight && this->_capacity < transport._capacity;
}

bool AirTransport::operator<=(const AirTransport& transport)
{
	return this->_weight <= transport._weight && this->_capacity <= transport._capacity;
}

bool AirTransport::operator!=(AirTransport& transport)
{
	return this->_weight != transport._weight && this->_capacity != transport._capacity;
}

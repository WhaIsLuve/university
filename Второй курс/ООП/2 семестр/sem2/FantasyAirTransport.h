#pragma once
class FantasyAirTransport
{
protected:
	bool isHaveTeaths;
	bool isHaveWings;
	bool isPeaceful;
public:
	FantasyAirTransport();
	FantasyAirTransport(bool isHaveTeaths, bool isHaveWings, bool isPeaceful);
	bool GetIsHaveTeaths();
	void SetIsHaveTeaths(bool isHaveTeaths);
	bool GetIsHaveWings();
	void SetIsHaveWings(bool isHaveWings);
	bool GetIsPeaceful();
	void SetIsPeaceful(bool isPeaceful);
};


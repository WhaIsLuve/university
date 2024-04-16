#include "airTransport.h"
#include "List.h"
#include "List.cpp"

#include <iostream>

using namespace std;

enum class State {
	Happy,
	Peace,
	Stress,
	Depresion
};

class Programmer;
class Computer;

class Programmer {
private:
	State mood;
	double alertness;
public:
	Programmer(State mood, double alertness) {
		if (alertness < 0) {
			this->alertness = 0;
		}
		this->alertness = alertness;
		this->mood = mood;
	}
	State getMood() {
		return mood;
	}
	double getAlertness() {
		return alertness;
	}
	void setMood(State state) {
		mood = state;
	}
	void setAlertness(double alertness) {
		if (alertness < 0) {
			cout << "Ѕдительность не может быть отрицательной!" << endl;
			return;
		}
		this->alertness = alertness;
	}

	bool startWork(Computer& computer);
	int fixBug(Computer& computer, int countFixedBugs);
};

class Computer {
private:
	bool isWork;
	int countBug;
public:
	Computer() {
		isWork = false;
		countBug = 0;
	}
	bool getIsWork() {
		return isWork;
	}
	void setIsWork(bool isWork) {
		this->isWork = isWork;
	}
	int getCountBug() {
		return countBug;
	}
	void setCountBug(int count) {
		if (countBug < 0) {
			cout << "Ѕдительность не может быть отрицательной!" << endl;
			return;
		}
		countBug = count;
	}
	int working(Programmer& programmer);
	State notifyError(Programmer& programmer);
};

void StateToString(State mood) {
	switch (mood)
	{
	case State::Happy:
		cout << "Happy" << endl;
		break;
	case State::Peace:
		cout << "Peace" << endl;
		break;
	case State::Stress:
		cout << "Stress" << endl;
		break;
	case State::Depresion:
		cout << "Depresion" << endl;
		break;
	default:
		break;
	}
}

bool Programmer::startWork(Computer& computer) {
	computer.setIsWork(true);
	return computer.getIsWork();
}

int Programmer::fixBug(Computer& computer, int countFixedBugs) {
	computer.setCountBug(computer.getCountBug() - countFixedBugs);
	return computer.getCountBug();
}

int Computer::working(Programmer& programmer) {
	programmer.setAlertness(programmer.getAlertness() - 1);
	return programmer.getAlertness();
}
State Computer::notifyError(Programmer& programmer) {
	if (countBug > 5) {
		programmer.setMood(State::Depresion);
	}
	else {
		programmer.setMood(State::Stress);
	}
	countBug++;
	return programmer.getMood();
}

int main() 
{
	setlocale(LC_ALL,"rus");

	airTransport a;
	airTransport x(500, color::White, "rocket", 20);
	airTransport b(23, color::Black, "helicopter", 8);
	List<airTransport> lst;
	
	lst.add(x);
	lst.add(b);
	lst.add(a);
	lst.show();
	return 1;
}
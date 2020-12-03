#include "Car.h"
#include <iostream>

using namespace std;

RaceCar::RaceCar()
{}

void RaceCar::setSpeed(int mph)
{
	const int MAX_SPEED = 200;
	if (isIgnitionOn)
	{
		if (mph <= MAX_SPEED)
		{
			speed = mph;
		}
		else
		{
			speed = MAX_SPEED;
		}
	}
	else
		cout << "Can't set speed - ignition is off!" << endl;
}


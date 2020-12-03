#include "Car.h"
#include <iostream>

using namespace std;

Car::Car(bool isIgnitionOn, int speed, int carIDnumber, int milesTraveled)
{
	this->isIgnitionOn = isIgnitionOn;
	this->speed = speed;
	this->carIDnumber = carIDnumber;
	this->milesTraveled = milesTraveled;
}

int Car::getCarIDNumber()
{
	return carIDnumber;
}

int Car::getMilesTraveled()
{
	return milesTraveled;
}

void Car::setCarIDNumber(int carIDnumber)
{
	this->carIDnumber = carIDnumber;
}

void Car::showCar()
{
	cout << "Card ID #" << carIDnumber << endl;

	if (isIgnitionOn)
	{
		cout << "Ignition is on. ";
	}
	else
	{
		cout << "Ignition is off. ";
	}

	
	cout << "Speed is " << speed << endl;
	cout << "# of Miles Traveled: " << milesTraveled << endl << endl;
	
}

void Car::turnIgnitionOn()
{
	milesTraveled = 0;
	isIgnitionOn = true;
}

void Car::turnIgnitionOff()
{
	speed = 0;
	isIgnitionOn = false;
}

void Car::setSpeed(int mph)
{
	const int STD_LIMIT = 65;
	if (isIgnitionOn)
	{
		if (mph <= STD_LIMIT)
		{
			speed = mph;
		}
		else
		{
			speed = STD_LIMIT;
		}
	}
	else
	{
		cout << "Can't set speed - ignition is off!" << endl;
	}
}

void Car::setMilesPerSpeed(int speed)
{
	this->milesTraveled += speed;
}

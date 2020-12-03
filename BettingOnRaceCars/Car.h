#pragma once
#include <iostream>

using namespace std;

class Car
{
	protected:
		bool isIgnitionOn;
		int speed;
		int carIDnumber;
		int milesTraveled;
	public:
		Car(bool isIgnitionOn = false, int speed = 0, int carIDnumber = 0, int milesTraveled = 0);
		int getCarIDNumber();
		int getMilesTraveled();
		void setCarIDNumber(int carIDnumber);
		void turnIgnitionOn();
		void turnIgnitionOff();
		void setSpeed(int);
		void showCar();
		void setMilesPerSpeed(int speed);

};

class RaceCar : public Car
{
public:
	RaceCar();
	void setSpeed(int mph);
};
#include <iostream>
#include "Time.h"
#include <string>
#include <iomanip>

using namespace std;

Time::Time(int hours, int minutes)
{
	this->hours = hours;
	this->minutes = minutes;
}

Time::Time(int hours)
{
	if (minutes < 0)
	{
		this->minutes = 0;
	}
	else
	{
		this->hours = hours;
		this->minutes = minutes;
	}
}

int & Time::getHours()
{
	return hours;
}

int & Time::getMinutes()
{
	return minutes;
}

void Time::setHours(int hours)
{
	if (hours > 23)
	{
		hours = 0;
	}
	if (hours < 0)
	{
		hours = 0;
	}

	this->hours = hours;
}

void Time::setMinutes(int minutes)
{
	this->minutes = minutes;
}

void Time::displayTime()
{
	if (minutes == 0 || minutes % 60 != 0 && minutes < 10)
	{
		cout << hours << ":0" << minutes << endl;
	}
	else
	{
		cout << hours << ":" << minutes << endl;
	}
	
}

void Time::addMinutes(int minutes)
{
	if (minutes > 60)
	{
		this->minutes = minutes - 60;
	}
	else
		this->minutes = minutes;
}
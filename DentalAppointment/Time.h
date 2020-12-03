#pragma once
#include <iostream>
#include <string>

using namespace std;

class Time
{
	private:
		int hours;
		int minutes;
	public:
		Time(int hours = 0, int minutes = 0);
		Time(int minutes = 0);
		int & getHours();
		int & getMinutes();
		void setHours(int hours);
		void setMinutes(int minutes);
		void displayTime();
		void addMinutes(int minutes);
};
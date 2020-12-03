#pragma once
#include <iostream>

using namespace std;

class Date
{
private:
	int year;
	int month;
	int day;
public:
	Date(int year = 1970, int month = 1, int day = 1);
	int getYear();
	int getMonth();
	int getDay();
	void setYear(int year);
	void setMonth(int month);
	void setDay(int day);
	void displayDate();

};
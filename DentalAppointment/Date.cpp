#include <iostream>
#include "Date.h"

using namespace std;

Date::Date(int year, int month, int day)
{
	
	this->year = year;
	this->month = month;
	this->day = day;
}

int Date::getYear()
{
	return year;
}

int Date::getMonth()
{
	return month;
}

int Date::getDay()
{
	return day;
}

void Date::setYear(int year)
{
	if (year < 2016)
	{
		year = 2016;
	}
	

	this->year = year;
}

void Date::setMonth(int month)
{
	if (month < 1)
	{
		month = 1;
	}
	if (month > 12)
	{
		month = 12;
	}

	this->month = month;
}

void Date::setDay(int day)
{
	if (month % 2 == 0) // Even month
	{
		if (day > 30 && month != 2)
		{
			day = 30;
		}
		if (year % 4 == 0 && month == 2 && day > 29) // Check for Leap Year
		{
			day = 29;
		}
		if (year % 4 == 1 && month == 2  && day > 28) // Feb only has 28 days
		{
			day = 28;
		}
	}

	if (month % 2 == 1) // Odd month
	{
		if (day > 31)
		{
			day = 31;
		}
	}

	this->day = day;
}

void Date::displayDate()
{
	cout << "Appointment Date: " << month << "/" << day << "/" << year << endl;
}
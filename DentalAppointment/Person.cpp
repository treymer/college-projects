#include <iostream>
#include "Person.h"
#include <string>

using namespace std;

Person::Person(string firstName, string lastName, string zipCode)
{
	this->firstName = firstName;
	this->lastName = lastName;
	this->zipCode = zipCode;
}

string Person::getFirstName()
{
	return firstName;
}

string Person::getLastName()
{
	return lastName;
}

string Person::getZipCode()
{
	return zipCode;
}

void Person::setFirstName(string firstName)
{
	this->firstName = firstName;
}

void Person::setLastName(string lastName)
{
	this->lastName = lastName;
}

void Person::setZipCode(string zipCode)
{
	this->zipCode = zipCode;
}

void Person::displayPerson()
{
	cout << "Patient: " << firstName << " " << lastName << " in ZIP Code " << zipCode << endl;
}
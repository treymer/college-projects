#pragma once
#include <iostream>

using namespace std;

class Person
{
	private:
		string firstName;
		string lastName;
		string zipCode;
	public:
		Person(string firstName = "X", string lastName = "X", string zipCode = "X");
		string getFirstName();
		string getLastName();
		string getZipCode();
		void setFirstName(string firstName);
		void setLastName(string lastName);
		void setZipCode(string zipCode);
		void displayPerson();
};
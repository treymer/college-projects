#include <iostream>
#include "Person.h"
#include "Date.h"
#include "Time.h"
#include "DentalAppointment.h"
#include <string>

using namespace std;

int main()
{
	string firstName, lastName, zipCode;
	int year, month, day;
	int hours, minutes, durationOfAppointment;

	for (int i = 0; i < 3; i++)
	{
		cout << "Enter Patient Last Name: ";
		cin >> lastName;

		cout << "Enter Patient First Name: ";
		cin >> firstName;

		cout << "Enter Appt. Month: ";
		cin >> month;

		cout << "Enter Appt. Day: ";
		cin >> day;

		cout << "Enter Appt. Year: ";
		cin >> year;

		cout << "Enter Appt. Time - Hour (24 hour clock): ";
		cin >> hours;

		cout << "Enter Appt. Time - Minutes: ";
		cin >> minutes;

		cout << "Enter Appt. Duration in Minutes: ";
		cin >> durationOfAppointment;

		DentalAppointment appointment(firstName, lastName, year, month, day, hours, minutes, durationOfAppointment);

		cout << endl;

		appointment.DisplayDentalAppointment();
	}

	system("PAUSE");
	return 0;
}
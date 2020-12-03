#include <iostream>
#include "Person.h"
#include "Date.h"
#include "Time.h"
#include "DentalAppointment.h"

using namespace std;

DentalAppointment::DentalAppointment(string firstName, string lastName, int year, int month, int day, int hours, int minutes, int durationOfAppointment)
	: patient(firstName, lastName), appointmentDate(year, month, day), appointmentStartTime(hours, minutes)
{
	this->patient.setFirstName(firstName);
	this->patient.setLastName(lastName);

	this->appointmentDate.setYear(year);
	this->appointmentDate.setMonth(month);
	this->appointmentDate.setDay(day);

	this->appointmentStartTime.setHours(hours);
	this->appointmentStartTime.setMinutes(minutes);

	if (durationOfAppointment > 240)
	{
		durationOfAppointment = 240;
	}

	//Calculate the end time here
	int endMinutes, endHours;

	endMinutes = durationOfAppointment % 60;
	endHours = (durationOfAppointment / 60) + hours;

	if (minutes + endMinutes < 60)
	{
		endMinutes += minutes;
	}

	if (minutes + endMinutes > 60 && hours + endHours >= 23)
	{
		endMinutes = durationOfAppointment;
		endHours++;
	}

	if (endMinutes + durationOfAppointment == 60)
	{
		endMinutes -= durationOfAppointment;
		endHours++;
	}

	if (endMinutes == 0)
	{
		endMinutes = 0;
	}

	this->appointmentEndTime.setMinutes(endMinutes);
	this->appointmentEndTime.setHours(endHours);
}

void DentalAppointment::DisplayDentalAppointment()
{
	patient.displayPerson();
	appointmentDate.displayDate();

	cout << "Appointment Start: "; appointmentStartTime.displayTime();
	cout << "Appointment End: "; appointmentEndTime.displayTime();

	cout << endl << endl;
}
DentalAppointment::DentalAppointment()
{
}
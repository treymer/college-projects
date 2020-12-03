#pragma once
#include <iostream>
#include <string>
#include "Person.h"
#include "Date.h"
#include "Time.h"

using namespace std;

class DentalAppointment
{
	private:
		Person patient;
		Date appointmentDate;
		Time appointmentStartTime;
		Time appointmentEndTime;
		int durationOfAppointment;
	public:
		DentalAppointment(string firstName, string lastName, int year, int month, int day, int hours, int minutes, int durationOfAppointment = 30);
		DentalAppointment();
		void DisplayDentalAppointment();

};
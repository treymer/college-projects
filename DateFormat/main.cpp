// Read date in form of mm/dd/yyy and display the name of the month, day followed by
// st, nd, rd, or th, and the year.

// TODO: Get rid of switch


#include <iostream>
#include <string>
#include <ctime>

using namespace std;

int main(){

	// Declare variables

	int month, year;
	double day;
	char c;

	// Input date

	cout << "Enter today's date: \n";
	cin >> month >> c >> day >> c >> year;

	// Begin switch to output date

	switch (month){
	case 1: {

		if (day == 1 || day == 21 || day == 31)
			cout << "Jan. " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "Jan. " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "Jan. " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "Jan. " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 2: {

		if (day == 1 || day == 21)
			cout << "Feb. " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "Feb. " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "Feb. " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 29)
			cout << "Feb. " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 3: {

		if (day == 1 || day == 21 || day == 31)
			cout << "March " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "March " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "March " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "March " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 4: {

		if (day == 1 || day == 21)
			cout << "April " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "April " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "April " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "April " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 5: {

		if (day == 1 || day == 21 || day == 31)
			cout << "May " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "May " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "May " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "May " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 6: {

		if (day == 1 || day == 21)
			cout << "June " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "June " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "June " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "June " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 7: {

		if (day == 1 || day == 21 || day == 31)
			cout << "July " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "July " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "July " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "July " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 8: {

		if (day == 1 || day == 21 || day == 31)
			cout << "Aug. " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "Aug. " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "Aug. " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "Aug. " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 9: {

		if (day == 1 || day == 21)
			cout << "Sept. " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "Sept. " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "Sept. " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "Sept. " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 10: {

		if (day == 1 || day == 21 || day == 31)
			cout << "Oct. " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "Oct. " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "Oct. " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "Oct. " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 11: {

		if (day == 1 || day == 21)
			cout << "Nov. " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "Nov. " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "Nov. " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "Nov. " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	case 12: {

		if (day == 1 || day == 21 || day == 31)
			cout << "Dec. " << day << "st, " << year << endl;
		else if (day == 2 || day == 22)
			cout << "Dec. " << day << "nd, " << year << endl;
		else if (day == 3 || day == 23)
			cout << "Dec. " << day << "rd, " << year << endl;
		else if (day >= 4 && day <= 20 || day >= 24 && day <= 30)
			cout << "Dec. " << day << "th, " << year << endl;
		else
			cout << "Please enter a valid date." << endl;
	}break;
	}

	// End switch.

	system("PAUSE");
	return 0;
}


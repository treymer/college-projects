// Output a menu of food and drinks and input the users order to calculate the total.

#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main(){

	// Declare variables

	const double small = 1.20, medium = 1.50, large = 1.70;
	const double tenInch = 3.75, footLong = 4.00;
	double drinks, sandwich, total;
	int ssize;
	char  dsize;

	// Display menu

	cout << "---------------Menu--------------" << endl;
	cout << "Drinks" << endl;
	cout << setfill('.');
	cout << fixed << showpoint << setprecision(2);
	cout << "\t" << left << setw(12) << "Small" << right << setw(10) << small << endl;
	cout << "\t" << left << setw(12) << "Medium" << right << setw(10) << medium << endl;
	cout << "\t" << left << setw(12) << "Large" << right << setw(10) << large << endl;
	cout << "Sandwiches" << endl;
	cout << "\t" << left << setw(12) << "10 inches" << right << setw(10) << tenInch << endl;
	cout << "\t" << left << setw(12) << "12 inches" << right << setw(10) << footLong << endl;

	// Gather input

	cout << "How many drinks?\n";
	cin >> drinks;
	cout << "What size (S=Small, M=Medium, L=Large)?\n";
	cin >> dsize;

	cout << "How many sandwiches?\n";
	cin >> sandwich;
	cout << "What size (12 or 10 inches)?\n";
	cin >> ssize;

	// Begin switch to calculate bill

	switch (dsize)
	{
	case 's': case 'S':{
		switch (ssize){
		case 10:

			total = (drinks * small) + (sandwich * tenInch);
			cout << "Total bill = $" << total << endl; break;
		case 12:

			total = (drinks * small) + (sandwich * footLong);
			cout << "Total bill = $" << total << endl; break;
		}break;
	}

	case 'm': case 'M':{

		switch (ssize){
		case 10:

			total = (drinks * medium) + (sandwich * tenInch);
			cout << "Total bill = $" << total << endl; break;
		case 12:

			total = (drinks * medium) + (sandwich * footLong);
			cout << "Total bill = $" << total << endl; break;
		}break;
	}


	case 'l': case 'L':{

		switch (ssize){
		case 10:

			total = (drinks * large) + (sandwich * tenInch);
			cout << "Total bill = $" << total << endl; break;
		case 12:

			total = (drinks * large) + (sandwich * footLong);
			cout << "Total bill = $" << total << endl; break;

		}break;
	}

	}
	// End switch

	system("PAUSE");
	return 0;
}


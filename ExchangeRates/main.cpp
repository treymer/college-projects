// Enter a start, finish, and jump value for exchange rates to be produced in a table.

#include <iostream>
#include <iomanip>


using namespace std;


int main(){

	// Variables
	int start, finish, jump;
	double yen, euro, pound;

	// Gather input for start, finish and jump.
	cout << "Please enter the start, finish, and jump values for the exchange table: \n";
	cin >> start >> finish >> jump;

	// Creates top row of the table
	cout << setw(8) << char(36) << setw(10) << char(157) << setw(10) << char(156) << setw(10) << char(238) << endl;
	
	// for loop to the solid double line
	for (int i = 0; i <= 45; ++i)
		cout << char(205);
	cout << endl;
	cout << fixed << showpoint << setprecision(2);

	// for loop to calculate the values of yen, euro and pound
	for (double i = start; i <= finish; i = i + jump)
	{
		yen = i * 107.16;
		euro = i * .77;
		pound = i * .61;

		cout << setw(10) << i << setw(10) << yen << setw(10) << euro << setw(10) << pound << setw(10) << endl;

	}

	system("PAUSE");
	return 0;
}


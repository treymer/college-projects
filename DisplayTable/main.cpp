// Display the table using a for-loop and members of <iomanip>

#include <iostream>
#include <string>
#include <iomanip>

using namespace std;


int main(){

	// Declare variables and arrays
	string Names[5] = { "Ronald Reagan", "Bill Clinton", "George Bush",
		"Barack Obama", "Jimmy Carter" };
	long int Salary[5] = { 25000, 300000, 185000, 4500, 1300 };
	double total = 0;

	// Displya top part of the table
	cout << setw(10) << "Name" << setw(25) << "Salary" << endl;
	for (int i = 0; i <= 40; ++i)
		cout << char(196);
	cout << endl;
	cout << fixed << showpoint << setprecision(2) << setfill('.');

	// For loop to display the table with names and salary
	for (int i = 0; i < 5; ++i){
		cout << left << setw(17) << Names[i] << right << setw(22) << Salary[i] << endl;
		total += Salary[i];
	}
	cout << "   Average salaries is $" << total / 5. << endl;

	system("PAUSE");
	return 0;
}


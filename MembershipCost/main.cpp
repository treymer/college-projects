// a program that outputs a menu and calculates the cost of a membership.

#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main(){
	// Variables

	int age;
	char gender;
	string fullName;
	const int childM = 50, childF = 55;
	const int teenM = 150, teenF = 155;
	const int adultM = 275, adultF = 250;
	const double tax = .10;
	double childTotalM, childTotalF, teenTotalM, teenTotalF, adultTotalM, adultTotalF;

	// Display menu

	cout << "----------Fullerton Health Club---------" << endl;
	cout << "Children (Age1-12)" << endl;
	cout << setfill('.');
	cout << fixed << showpoint << setprecision(2);
	cout << "\t" << left << setw(12) << "Male" << right << setw(10) << childM << endl;
	cout << "\t" << left << setw(12) << "Female" << right << setw(10) << childF << endl;
	cout << "Teenagers (Age13-19)" << endl;
	cout << "\t" << left << setw(12) << "Male" << right << setw(10) << teenM << endl;
	cout << "\t" << left << setw(12) << "Female" << right << setw(10) << teenF << endl;
	cout << "Adults (Age > 19)" << endl;
	cout << "\t" << left << setw(12) << "Male" << right << setw(10) << adultM << endl;
	cout << "\t" << left << setw(12) << "Male" << right << setw(10) << adultF << endl;

	// Gather inputs

	cout << "Enter your full name: \n";
	getline(cin,fullName);

	cout << "Enter your age?\n";
	cin >> age;	
		
	cout << "Enter your gender (m/f)?\n";
	cin >> gender;

	// if else to test gender and age

	if (age > 19){

		switch (gender)
		{
		case 'm':case 'M':
			adultTotalM = (adultM * tax) + adultM;
			cout << "Hello Mr. " << fullName << ", your membership fee is $" << adultTotalM << " (10% tax included)\n"; break;
		case 'f':case'F': 
			adultTotalF = (adultF * tax) + adultF;
			cout << "Hello Mrs. " << fullName << ", your membership fee is $" << adultTotalF << " (10% tax included)\n";break;
		default: cout << "Wrong input"; exit(1);
		
		}
	}

	else if (age >=13){

		switch (gender)
			{
			case 'm':case 'M':
				teenTotalM = (teenM * tax) + teenM;
				cout << "Hello Mr. " << fullName << ", your membership fee is $" << teenTotalM << " (10% tax included)\n"; break;
			case 'f':case'F': 
				teenTotalF = (teenF * tax) + teenF;
				cout << "Hello Mrs. " << fullName << ", your membership fee is $" << teenTotalF << " (10% tax included)\n"; break;
			default: cout << "Wrong input"; exit(1);
		
			}
	}

	else
		{

		switch (gender)
			{
			case 'm':case 'M':
				childTotalM = (childM * tax) + childM;
				cout << "Hello Mr. " << fullName << ", your membership fee is $" << childTotalM << " (10% tax included)\n"; break;
			case 'f':case'F': 
				childTotalF = (teenF * tax) + childF;
				cout << "Hello Mrs. " << fullName << ", your membership fee is $" << childTotalF << " (10% tax included)\n"; break;
			default: cout << "Wrong input"; exit(1);
		
			}
	}

	// End of If statements

	system("PAUSE");
	return 0;
}

//Enter a fraction, enter another fraction, then enter a operater. Calculate the total
//and display to user as a fraction.

#include <iostream>
#include <string>
#include <ctime>

using namespace std;


int main()
{
	// Declare variables
	double a, b, c, d;
	double numerator, denominator;
	char operation;
	string name;
	// Gather inputs
	cout << "Enter a fraction: \n";
	cin >> a; cin.ignore(); cin >> b;

	cout << "Enter another fraction: \n";
	cin >> c; cin.ignore(); cin >> d;

	cout << "Enter an operation symbol (+,-,*,/):\n";
	cin >> operation;

	// Begin switch statement for operation

	switch (operation){

	case '+':
		numerator = (a*d) + (c*b);
		denominator = b * d;
		cout << a << '/' << b << operation << c << '/' << d << " = " << numerator << '/' << denominator << endl; break;
	case '-':
		numerator = (a*d) - (c*b);
		denominator = b * d;
		cout << a << '/' << b << operation << c << '/' << d << " = " << numerator << '/' << denominator << endl; break;
	case '*':
		numerator = a * c;
		denominator = b * d;
		cout << a << '/' << b << operation << c << '/' << d << " = " << numerator << '/' << denominator << endl; break;
	case '/':
		numerator = a * d;
		denominator = b * c;
		cout << a << '/' << b << operation << c << '/' << d << " = " << numerator << '/' << denominator << endl; break;
	}

	// End switch statement

	system("PAUSE");
	return 0;
}


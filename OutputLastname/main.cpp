// Write a program to read a full name of a person and display their last name.

#include <iostream>
#include <string>
#include <cctype>

using namespace std;

int main()
{
	// Declare variables
	char yesNo;
	string full_name, last_name;
	int charAmount;

	// Do-while loop to display menu
	do
	{
		// Gather input
		cout << "Please enter your full name: ";
		getline(cin, full_name);
		charAmount = full_name.length();
		// while loop to count backwards through the string to find the last white space
		while (full_name[charAmount] != ' ')
		{
			charAmount--;
		}
		// assigns last name and erases rest of the input
		last_name = full_name;
		last_name.erase(0, charAmount);
		// Outputs the last name
		cout << '\t' << full_name << ", your last name is" << last_name << endl;
		cout << '\t' << "CONTINUE(y/n)?";
		cin >> yesNo;
		// While loop if the user enters an invalid input
		while (yesNo != 'y' && yesNo != 'n')
		{
			cout << '\t' << "Invalid input.\n";
			cout << '\t' << "CONTINUE(y/n)?";
			cin >> yesNo;
			toupper(yesNo);
		}
		cin.ignore();
	} while (yesNo == 'y');

	system("pause");
	// End of program
	return 0;
}


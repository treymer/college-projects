// Create a program that counts the number of Y/N votes with stars ('*').

#include <iostream>
#include <string>

using namespace std;

int main(){

	// Variables
	int yes = 0, no = 0;
	char c, star = '*';

	// Gather the string of votes
	cout << "Enter a string of Yes and No votes: \n";
	cin.get(c);

	// Make first Y/N uppercase
	c = toupper(c);

	// While loop to check and count for upper case Y, N.
	while (c != '\n')
	{
		if (c == 'Y')
			yes++;

		if (c == 'N')
			no++;

		cin.get(c);
		c = toupper(c);
	}

	// for lopp to convert the number of Yes votes to stars
	cout << "YES votes:";
	for (int i = 1; i <= yes; i++)
	{
		cout << '*';
	}
	cout << endl;

	// for lopp to convert the number of No votes to stars
	cout << "NO votes :";
	for (int x = 1; x <= no; x++)
	{
		cout << '*';
	}
	cout << endl;

	//End
	system("PAUSE");
	return 0;
}


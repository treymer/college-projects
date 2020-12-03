// Create a program that reads the number of uppercase letters, digits, and vowels in a sentence.

#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main(){

	// Variable
	int Nv = 0, Nl = 0, Nd = 0;
	char c;

	// Gather input
	cout << "Enter a sentence: \n";
	cin.get(c);  // read first char

	// While loop to read each char to determine whether it is a vowel, number, or uppercase letter.
	while (c != '\n')
	{
		if (c >= 'A' && c <= 'Z')
			Nl++;

		if (c == 'A' || c == 'a' || c == 'E' || c == 'e' || c == 'I' || c == 'i' || c == 'O' || c == 'o' || c == 'U' || c == 'u')
			Nv++;

		if (c >= '0' && c <= '9')
			Nd++;

		cin.get(c);
	}

	// Display results to the user.
	cout << setfill('.');
	cout << fixed;
	cout << "Number of uppercase letters:" << right << setw(10) << Nl << endl;
	cout << "Number of digits:" << right << setw(21) << Nd << endl;
	cout << "Number of vowels:" << right << setw(21) << Nv << endl;


	system("PAUSE");
	return 0;
}


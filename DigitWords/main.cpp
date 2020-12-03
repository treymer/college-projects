// Read a number up to 3 digits and display it in words.

#include <iostream>
#include <string>

using namespace std;

int main()

{
	// Declare variables as the name of the number place.
	int hundreds, tens, ones, number;
	// Gather input from user into number.
	cout << "Please enter a number less than 1000: ";
	cin >> number;
	cout << "The number you have entered is ";

	// Calculations that test for remainders, which determine which case to use in the switch.

	hundreds = (number / 100) % 10;
	tens = (number / 10) % 10;
	ones = number % 10;
	// begin switch to test for hundreds
	switch (hundreds)
	{
	case 1: cout << "One Hundred "; break;
	case 2: cout << "Two Hundred "; break;
	case 3: cout << "Three Hundred "; break;
	case 4: cout << "Four Hundred "; break;
	case 5: cout << "Five Hundred "; break;
	case 6: cout << "Six Hundred "; break;
	case 7: cout << "Seven Hundred "; break;
	case 8: cout << "Eight Hundred "; break;
	case 9: cout << "Nine Hundred "; break;
	}
	if (tens == 1)    // When 10-19 is modded with 10, it will equal 1 with a remainder of 0-9.
	{
		// Begin switch to test for ones
		switch (ones)
		{
		case 0: cout << "Ten"; break;
		case 1: cout << "Eleven"; break;
		case 2: cout << "Twelve"; break;
		case 3: cout << "Thirteen"; break;
		case 4: cout << "Fourteen"; break;
		case 5: cout << "Fifteen"; break;
		case 6: cout << "Sixteen"; break;
		case 7: cout << "Seventeen"; break;
		case 8: cout << "Eighteen"; break;
		case 9: cout << "Nineteen"; break;
		}
	}
	else
	{
		// Begin switch to test for tens.
		switch (tens)
		{
		case 2: cout << "Twenty "; break;
		case 3: cout << "Thirty "; break;
		case 4: cout << "Fourty "; break;
		case 5: cout << "Fifty "; break;
		case 6: cout << "Sixty "; break;
		case 7: cout << "Seventy "; break;
		case 8: cout << "Eighty "; break;
		case 9: cout << "Ninety "; break;
		}
		// Special cases that need correct grammar
		if ((tens == 0) && (ones > 0))        // tests if 'and' needs to be inserted.
			{
				cout << "and ";
			}
		switch (ones)
		{
		case 1: cout << "One"; break;
		case 2: cout << "Two"; break;
		case 3: cout << "Three"; break;
		case 4: cout << "Four"; break;
		case 5: cout << "Five"; break;
		case 6: cout << "Six"; break;
		case 7: cout << "Seven"; break;
		case 8: cout << "Eight"; break;
		case 9: cout << "Nine"; break;
		}
	}

	// End switch statements
	cout << endl; // endl to look nice.

	// Pause program for output.

	system("PAUSE");
	return 0;
}


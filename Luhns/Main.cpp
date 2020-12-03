/*
* Created By: Tyler Reymer
* Course: ISDS 371
* Homework #1 Luhn Algorithm
* Date: 1/31/16
*/

#include <iostream>

using namespace std;

//***********************************************MAIN*******************************************************
int main()
{
	// Declare Variables
	int one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, chksm = 0;
	int sum = 0;
	int total = 0;
	int verify = 0;

	// Gather User Input into Variables
	cout << "Enter first set of 4 Credit Card Digits (each separated by a space): ";
	cin >> one >> two >> three >> four;
	cout << "Enter second set of 4 Credit Card Digits (each separated by a space): ";
	cin >> five >> six >> seven >> eight;
	cout << "Enter third set of 4 Credit Card Digits (each separated by a space): ";
	cin >> nine >> ten >> eleven >> twelve;
	cout << "Enter last set of 4 Credit Card Digits (each separated by a space): ";
	cin >> thirteen >> fourteen >> fifteen >> chksm;
	cout << endl;

	//*********************************First Set*********************************
	fifteen *= 2;
	if (fifteen > 9)
		sum += ((fifteen % 10) + (fifteen / 10));	
	else
		sum += fifteen;

	sum += fourteen;

	thirteen *= 2;
	if (thirteen > 9)
		sum += ((thirteen % 10) + (thirteen / 10));
	else
		sum += thirteen;
	//*********************************Second Set*********************************
	sum += twelve;

	eleven *= 2;
	if (eleven > 9)
		sum += ((eleven % 10) + (eleven / 10));
	else
		sum += eleven;
	
	sum += ten;

	nine *= 2;
	if (nine > 9)
		sum += ((nine % 10) + (nine / 10));
	else
		sum += nine;
	//*********************************Third Set*********************************
	sum += eight;

	seven *= 2;
	if (seven > 9)
		sum += ((seven % 10) + (seven / 10));
	else
		sum += seven;

	sum += six;

	five *= 2;
	if (five > 9)
		sum += ((five % 10) + (five / 10));
	else
		sum += five;
	//*********************************Last Set*********************************
	sum += four;

	three *= 2;

	if (three > 9)
		sum += ((three % 10) + (three / 10));
	else
		sum += three;

	sum += two;

	one *= 2;
	if (one > 9)
		sum += ((one % 10) + (one / 10));
	else
		sum += one;
	//******************************************************************

	total = sum * 9; // Multiply sum by 9
	verify = total % 10; // Find the chksm number

	cout << "Is Valid: ";
	if (verify == chksm) // If chksm matches, then its valid
		cout << true;
	else
		cout << false;
	cout << endl;
	
	system("PAUSE");
	return 0;
	//******************************** END ************************************
}





// Create a program to produced random addition problems <100

#include <iostream>
#include <ctime>

using namespace std;

int main() {

	// Variables
	int x, y, answer;
	char yN;

	// Random number based on time
	srand(time(0));

	// Do while loop to display a problem and ask the user to continue.
	do{
		x = rand() % 100;
		y = rand() % 100;

		cout << x << "+" << y << "=? ";
		cin >> answer;


		if (x + y == answer)
			cout << "Correct!\n";
		else
			cout << "Wrong!\n";
		cout << "Continue (y/n)?";
		cin >> yN;
		yN = toupper(yN);

	} while (yN == 'Y');

	// End

	return 0;
}


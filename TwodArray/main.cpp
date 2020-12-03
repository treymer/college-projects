// Use a two dimensional array to generate the output for tshirt.

#include <iostream>

using namespace std;


int main(){

	// Declare variables and array
	int shirts[3][4] = { 22, 30, 10, 7,      // Red
		21, 23, 7, 11,		// Blue
		8, 11, 10, 12 };	// Pink
	int totalShirts = 0, totalBlue = 0, totalLarge = 0;

	// Calculate and display total number of shirts
	for (int row = 0; row < 3; ++row){
		for (int column = 0; column < 4; ++column){

			totalShirts += shirts[row][column];

		}

	}
	cout << "Total number of T-Shirts: " << totalShirts << endl;

	// Calculate and display total number of blue shirts
	for (int row = 1; row <= 1; ++row){
		for (int column = 0; column < 4; ++column){

			totalBlue += shirts[row][column];

		}
	}
	cout << "Total number of BLUE T-Shirts: " << totalBlue << endl;

	// Calculate and display the number of large shirts
	for (int row = 0; row < 3; ++row){
		for (int column = 2; column <= 2; ++column){

			totalLarge += shirts[row][column];

		}
	}
	cout << "Total number of LARGE T-Shirts: " << totalLarge << endl;

	system("PAUSE");
	return 0;
}


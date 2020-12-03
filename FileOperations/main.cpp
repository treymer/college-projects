// Create text file. Write a program to read data from the file, store into arrays Name 
//and Age. Display arrays, show oldest, and teenagers.


#include <fstream>
#include <string>
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	// Declare variables and arrays
	ifstream test;
	string name[7];
	string student, teenager;
	int age[7];
	int max = age[0];
	int teen = 0;

	// Open the text file
	test.open("people.txt");

	// Display the top of the table
	cout << setw(6) << "Name" << setw(13) << "Age" << endl;
	for (int i = 0; i <= 20; ++i)
		cout << char(196);
	cout << endl;

	// Display the data from the file into a table
	for (int i = 0; i < 7; ++i){
		test >> name[i] >> age[i];
		cout << setw(15) << left << name[i] << "\t " << right << age[i] << endl;
		// Calculate the oldest student
		if (age[i] > max){
			max = age[i];
			student = name[i];
		}
	}

	cout << endl;
	cout << "Oldest student: " << student << endl;
	cout << "Name of teenager student: " << teenager;

	// Calculate the teenagers
	for (int x = 0; x < 7; ++x){
		if (age[x] >= 13 && age[x] <= 19){
			teen++;
			teenager = name[x];
			cout << teenager << " ";
		}
	}
	cout << endl;

	test.close();
	system("PAUSE");
	return 0;

}


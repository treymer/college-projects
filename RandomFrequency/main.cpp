/*
=================================================================================
File: Question1_Project8
=================================================================================
Programmer: Tyler Reymer
Date: 10/30/2014
Class: CPSC 121
Time: TR 2:30pm, T lab
Instructor: Dr. Ray Ahmandnia
Project: Project No. 8, Question 1

Description:
Generate 30 random numbers between 0 and 9. Find frequency of each number.
=================================================================================
*/
#include <iostream>
#include <ctime>
#include <iomanip>

using namespace std;

struct NUM
{
	int n;
	int freq;
};
// ================================ Main function ================================
int main()
{
	// Creates array and initializes first number to 0
	NUM All[10];
	All[0].n = 0;
	// Create variables
	int random = 0;
	int largest = 0; 

	// Assigns n 0-9 and initializes all frequencies
	for (int j = 0; j < 10; ++j)
	{
		All[j].n = j;
		All[j].freq = 0;
	}
	// seeds time
	srand(time(NULL));

	// Generates 30 random numbers and count frequencies. 
	for (int i = 0; i < 30; ++i)
	{
		random = rand() % 10;
		All[random].freq++;
		// Finds largest frequency
		if (All[random].freq > largest)
		{
			largest = All[random].freq;
		}
	}

	// Creates and intializes smallest to the first frequency
	int smallest = All[0].freq;

	// Finds the smallest frequency
	for (int i = 0; i < 10; ++i)
	{
		if (All[i].freq < smallest)
		{
			smallest = All[i].freq;
		}
	}
	// Outputs the headers of the tables
	cout << "Number" << setw(10) << "Frequency" << endl;

	for (int i = 0; i < 20; ++i)
	{
		cout << "_";
	}

	cout << endl;
	// Outputs the table with frequencies
	for (int x = 0; x < 10; ++x)
	{
		cout << left << setw(10) << All[x].n;
		cout << left << setw(10) << All[x].freq;
		cout << endl;
	}
	// Finds all of the numbers with the largest frequency
	cout << "Number(s) with largest frequency of " << largest << " is/are: ";
	for (int i = 0; i < 10; ++i)
	{
		if (All[i].freq == largest)
		{
			cout << All[i].n << ' ';
		}
	}
	cout << endl;
	// Finds all of the numbers with the smallest frequency
	cout << "Number(s) with smallest frequency of " << smallest << " is/are: ";
	for (int i = 0; i < 10; ++i)
	{
		if (All[i].freq == smallest)
		{
			cout << All[i].n << ' ';
		}
	}
	cout << endl;
	// Pauses cmd window
	system("pause");
	// Terminates program
	return 0;

}


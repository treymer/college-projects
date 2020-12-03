/*
=================================================================================
File: Question2_Project10
=================================================================================
Programmer: Tyler Reymer
Date: 11/13/2014
Class: CPSC 121
Time: TR 2:30pm, T lab
Instructor: Dr. Ray Ahmandnia
Project: Project No. 10, Question 2

Description:
Use given class declaration to write a complete program for the problem.
=================================================================================
*/

#include <iostream>

using namespace std;
// =================================== Object ====================================
class TWO
{
	private: int age[5];
	public:
		// Read data into array age
		void ReadData();
		// A friend to return the average of data in array age of object p
		friend int FindAverage(TWO p);
		// Find and return the mac and min age
		void FindMaxMin(int& maxAge, int& minAge);
		// Display ages > age average
		void aboveAve(int ageAve);
		// Display the mac and min ages
		void DisplayMaxMinAge(int maxAge, int minAge);
		// Release all memory used by objects
		~TWO();
};
// Read data into array
void TWO::ReadData()
{
	cout << "Enter 5 ages: ";
	for (int i = 0; i < 5; ++i)
	{
		cin >> age[i];
	}
}
// Find and return the average
int FindAverage(TWO p)
{
	int total = 0;
	for (int i = 0; i < 5; ++i)
	{
		total += p.age[i];
	}
	return total / 5;
}
// Find the max and min
void TWO::FindMaxMin(int& maxAge, int& minAge)
{
	maxAge = minAge = age[0];
	for (int i = 0; i < 5; ++i)
	{
		if (age[i] > maxAge)
		{
			maxAge = age[i];
		}
		if (age[i] < minAge)
		{
			minAge = age[i];
		}
	}

}
// Display ages above average
void TWO::aboveAve(int ageAve)
{
	cout << "Ages above average: ";
	for (int i = 0; i < 5; ++i)
	{
		if (age[i] > ageAve)
		{
			cout << age[i] << " ";
		}
	}
	cout << endl;
}
// Display the max and min ages
void TWO::DisplayMaxMinAge(int maxAge, int minAge)
{
	cout << "Maximum age is " << maxAge << endl;
	cout << "Minimum age is " << minAge << endl;
}
// Destructor
TWO::~TWO()
{}
// ================================ Main function ================================
int main(){
	// Create object
	TWO p;
	// Call function to read data
	p.ReadData();
	// Declare variables and call function
	int max = 0, min = 0;
	p.FindMaxMin(max, min);
	// Call FindAverage function in object p and send it to function aboveAve
	p.aboveAve(FindAverage(p));
	// Call function to display max and min
	p.DisplayMaxMinAge(max, min);
	// Pause the window
	system("pause");
	// Terminate the program
	return 0;
}


// Write a function template to display each array.

#include <iostream>
#include <algorithm>
#include <cstring>
#include <string>

using namespace std;

// These are the template functions I created.
template <class T1>
void Display(T1 x[], int n);

template <class T2>
void DisplaySorted(T2 x[], int n);

// ================================ Main function ================================
int main()
{
	// Declare arrays
	int age[5] = { 22, 33, 11, 16, 10 };
	string name[4] = { "Bill", "Adam", "Mary", "David" };

	// Call functions
	cout << "Original array age: ";
	Display(age, 5);
	cout << "Original array name: ";
	Display(name, 4);
	cout << "Sorted array age: ";
	DisplaySorted(age, 5);
	cout << "Sorted array name: ";
	DisplaySorted(name, 4);

	system("PAUSE");
	return 0;
}
//============================= Created functions ==================================
template <class T1>
void Display(T1 x[], int n)
{
	for (int i = 0; i < n; i++)
	{
		cout << x[i] << ' ';
	}
	cout << endl;
}

template <class T2>
void DisplaySorted(T2 x[], int n)
{
	sort(x, x + n);
	for (int i = 0; i < n; i++)
	{
		cout << x[i] << ' ';
	}
	cout << endl;
}


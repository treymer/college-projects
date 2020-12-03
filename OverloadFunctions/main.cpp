// Display using overloaded function, use two templates functions for show and sort.

#include <iostream>
#include <string>
#include <cstring>
#include <algorithm>

using namespace std;
// User created functions.
void Display(int x[], int n);
void Display(char x[], int n);
void Display(string x[], int n);

template <class T1, class T2>
void SortArray(T1 x[], T2 n);

template <class T3, class T4>
void Show(T3 x[], T4 n);
int main()
{
	int a[5] = { 1, 2, 3, 4, 5 };
	char c[6] = { 'a', 'r', 'r', 'a', 'y', 's' };
	string d[3] = { "try", "enjoy", "programming" };
	// Display all arrays using overload functions
	cout << "Array a using the Display function: ";
	Display(a, 5);
	cout << "Array c using the Display function: ";
	Display(c, 6);
	cout << "Array d using the Display function: ";
	Display(d, 3);
	cout << endl;
	// Sort arrays using template
	SortArray(a, 5);
	SortArray(c, 6);
	SortArray(d, 3);
	// Show array using template
	cout << "Array a using the Show function: ";
	Show(a, 5);
	cout << "Array c using the Show function: ";
	Show(c, 6);
	cout << "Array d using the Show function: ";
	Show(d, 3);

	system("PAUSE");
	return 0;
}
void Display(int x[], int n)
{
	for (int i = 0; i < n; ++i)
	{cout << x[i] << " ";}
	cout << endl;
}
void Display(char x[], int n)
{
	for (int i = 0; i < n; ++i)
	{cout << x[i] << " ";}
	cout << endl;
}
void Display(string x[], int n)
{
	for (int i = 0; i < n; ++i)
	{cout << x[i] << " ";}
	cout << endl;
}

template <class T1, class T2>
void SortArray(T1 x[], T2 n)
{sort(x, x + n);}

template <class T3, class T4>
void Show(T3 x[], T4 n)
{
	for (int i = 0; i < n; ++i)
	{cout << x[i] << " ";}
	cout << endl;
}


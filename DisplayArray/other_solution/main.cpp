// Display each array using the following calling statements.

#include <iostream>
#include <string>
#include <cstring>
#include <algorithm>

using namespace std;
// User created functions.
void DisplayA(int a[], int n);
void DisplayB(int a[][4], int n);
void DisplayC(int a[][3][2], int n);
int main()
{
	int a[5] = { 1, 2, 3, 4, 5 };
	int b[3][4] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	int c[2][3][2] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	// Display arrays
	cout << "This is array a: \n"; DisplayA(a, 5);
	cout << "This is array b: \n"; DisplayB(b, 3);
	cout << "This is array c: \n"; DisplayC(c, 2);

	system("PAUSE");
	return 0;
}
void DisplayA(int a[], int n)
{
	for (int i = 0; i < n; ++i)
	{
		cout << a[i] << '\t';
	}
	cout << endl;
}
void DisplayB(int a[][4], int n)
{
	for (int i = 0; i < n; ++i)
	{
		for (int j = 0; j < 4; ++j)
		{
			cout << a[i][j] << '\t';
		}cout << endl;
	}cout << endl;
}
void DisplayC(int a[][3][2], int n)
{
	int count = 0;
	for (int i = 0; i < n; i++)
	{
		cout << "Row = " << count << endl ;
		count++;
		for (int j = 0; j < 3; j++)
		{
			for (int x = 0; x < 2; ++x)
			{
				cout << a[i][j][x] << '\t';
			}cout << endl;
		} cout << endl;
	}
}


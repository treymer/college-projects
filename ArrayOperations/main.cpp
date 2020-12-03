// Write a complete program to us the following main function.

#include <iostream>
#include <fstream>
#include <algorithm>
#include <cstring>
#include <string>

using namespace std;
// User created functions.
void CopyData(string fname, int x[]);
void Display(int x[]);
float FindAve(int x[]);
void Display(int x[], float a);
void FindMaxMin(int x[], int& max, int& min);
void Display(int x, int y);
//Const
const int N = 6;
int main()
{
	int a[N];

	//Copy data from file into array a
	CopyData("data.txt", a);

	//Display array a
	Display(a);

	//Find and display the average of numbers in array a
	float average = FindAve(a);
	cout << "Average = " << average << endl;

	//Display numbers whose value is >= average
	Display(a, average);

	//Find and display the maximum and minimum numbers in array a
	int max = a[0], min = a[0];
	FindMaxMin(a, max, min);
	Display(max, min);

	//Terminiate program
	system("PAUSE");
	return 0;
}
void CopyData(string fname, int x[])
{
	fstream f;
	f.open(fname, ios::in);
	for (int i = 0; i < 6; ++i)
	{f >> x[i];}
	f.close();
}
void Display(int x[])
{
	cout << "This is array a: ";
	for (int i = 0; i < 6; i++)
	{cout << x[i] << ' ';}
	cout << endl;
}
float FindAve(int x[])
{
	int sum = 0; float average = 0.0;
	for (int i = 0; i < 6; ++i)
	{sum += x[i];}
	average = sum/6.;
	return average;
}
void Display(int x[], float ave)
{
	cout << "Data values above average: ";
	for (int i = 0; i < 6; ++i)
	{
		if (x[i] > ave)
		{cout << x[i] << " ";}
	}cout << endl;
}
void FindMaxMin(int x[], int& max, int& min)
{
	for (int i = 0; i < 6; ++i)
	{
		if (x[i] > max) max = x[i];
		if (x[i] < min) min = x[i];
	}
}

void Display(int x, int y)
{
	cout << "Maximum = " << x << endl;
	cout << "Minimum = " << y << endl;
}


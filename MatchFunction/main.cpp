// Write each function to match their corresponding calling statement.

#include <iostream>
#include <cmath>

using namespace std;
// Declare functions
void ReadData(int& x, int& y, int& z);
int ComputeSum(int x, int y, int z);
void ComputeAverage(int x, int y, int z, float& average);
void Display(int total, float average);
void FindMaxMin(int x, int y, int z, int& max, int& min);
void DisplayMaxMin(int x, int y, int z, int max, int min);

int main()
{
	// Read Data into x, y, and z
	int x, y, z;
	ReadData(x, y, z);

	// Compute the total of x, y, and z
	int total;
	total = ComputeSum(x, y, z);

	// Compute the average of x, y, and z
	float average;
	ComputeAverage(x, y, z, average);

	// Display total and avergae of x, y, and z
	Display(total, average);

	// Find the maximum and minimum of x, y, and z
	int max, min;
	FindMaxMin(x, y, z, max, min);

	// Display the max and min valuse;
	DisplayMaxMin(x, y, z, max, min);

	system("PAUSE");

	// Terminate the program
	return 0;
}

void ReadData(int& x, int& y, int& z)
{
	cout << "Enter three integer numbers: ";
	cin >> x >> y >> z;
}

int ComputeSum(int x, int y, int z)
{
	return x + y + z;
}

void ComputeAverage(int x, int y, int z, float& average)
{
	average = (x + y + z) / 3.;
}

void Display(int total, float average)
{
	cout << "Total = " << total << endl;
	cout << "Average = " << average << endl;
}

void FindMaxMin(int x, int y, int z, int& max, int& min)
{
	if (x > y && x > z)
	{max = x;}
	if (y > x && y > z)
	{max = y;}
	if (z > x && z > y)
	{max = z;}

	if (x < y && x < z)
	{min = x;}
	if (y < x && y < z)
	{min = y;}
	if (z < x && z < y)
	{min = z;}
}

void DisplayMaxMin(int x, int y, int z, int max, int min)
{
	cout << "The max and min values of " << x << ", " << y << " and " << z << " are " << max << " and " << min << endl;
}


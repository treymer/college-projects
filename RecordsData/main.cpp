#include <iostream>
#include <fstream>
#include <string>
#include <cstring>
#include <algorithm>
#include <cctype>
#include <iomanip>

using namespace std;
// Const and Record for arrays and inputs
const int N = 5;
struct RECORD
{
	char Name[20];
	int Age;
	float Gpa;
};
// User created functions.
void CopyRecords(string fname, RECORD x[]);
void Display(RECORD x[]);
void AgeGpaAverage(RECORD x[], float& AgeAve, float& GpaAve);
void Display(float AgeAve, float GpaAve);
int main()
{
	RECORD p[N]; 
	

	// Read data from file into array p
	CopyRecords("data2.txt", p);
	// Display RECORD
	Display(p);
	// Find averages
	float AgeAve, GpaAve;
	AgeGpaAverage(p, AgeAve, GpaAve);
	// Display averages
	Display(AgeAve, GpaAve);

	system("PAUSE");
	return 0;
}
void CopyRecords(string fname, RECORD x[])
{
	fstream f;
	f.open(fname, ios::in);
	for (int i = 0; i < 5; ++i)
	{
		f.getline(x[i].Name, 20, '/');
		f >> x[i].Age;
		f >> x[i].Gpa;
	}
	f.close();
}
void Display(RECORD x[])
{
	cout << setw(8) << "Name" << setw(14) << "Age" << setw(10) << "Gpa"  << endl;
	for (int i = 0; i <= 40; ++i)
		cout << char(45);
	cout << endl;
	cout << fixed << showpoint << setprecision(2);
	for (int i = 0; i < 5; ++i)
	{
		_strupr_s(x[i].Name);
		cout << left << setw(20) << x[i].Name;
		cout << left << setw(10) << x[i].Age;
		cout << left << setw(10) << x[i].Gpa;
	}cout << endl;
}
void AgeGpaAverage(RECORD x[], float& AgeAve, float& GpaAve)
{
	float sumAge = 0.0, sumGpa = 0.0;
	for (int i = 0; i < 5; ++i)
	{
		sumAge += x[i].Age;
		sumGpa += x[i].Gpa;
	}
	AgeAve = sumAge / 5.;
	GpaAve = sumGpa / 5.;
}
void Display(float AgeAve, float GpaAve)
{
	cout << "Their AGE average is " << AgeAve << " and their GPA average is " << GpaAve << endl;
}


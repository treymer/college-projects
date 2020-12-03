/*
=================================================================================
File: Question1_Project10
=================================================================================
Programmer: Tyler Reymer
Date: 11/13/2014
Class: CPSC 121
Time: TR 2:30pm, T lab
Instructor: Dr. Ray Ahmandnia
Project: Project No. 10, Question 1

Description:
Use given class declaration to write a complete program for the problem.
=================================================================================
*/

#include <iostream>
#include <iomanip>

using namespace std;
// =================================== Object ====================================
class POINT
{
	private: float x, y;
	public:
		// Constructor to set x,y equal to zero
		POINT();
		// Member to read x and y coordinate of each vertex
		void ReadData(char vertex);
		// Display the (x,y) of a given vertex
		void Display(char vertex);
		// Friend to compute the distance between vertices p(x,y) and q(x,y)
		friend float Distance(POINT p, POINT q);
		// Compute and display the perimete of ABCD
		friend void DisplayPer(float AB, float AC, float CD, float BD);
		// Destructor to release all memore used by objects in the program
		~POINT();
};
// Constructor
POINT::POINT()
{
	x = 0; y = 0;
}
// Read data
void POINT::ReadData(char vertex)
{
	cout << "Enter the x and y coordinates of vertex " << vertex << ": ";
	cin >> x >> y;
}
// Display the data
void POINT::Display(char vertex)
{
	cout << fixed << setprecision(2);
	cout << vertex << "(" << x << "," << y << ")";
}
// Return the distance of each point
float Distance(POINT p, POINT q)
{
	return sqrt((p.x - q.x)*(p.x - q.x) + (p.y - q.y) * (p.y - q.y));
}
// Calculate and display the perimeter
void DisplayPer(float AB, float AC, float CD, float BD)
{
	float perimeter;
	perimeter = AB + AC + CD + BD;
	cout << "Perimeter = " << perimeter << endl;
}
// Destructor
POINT::~POINT()
{}

// ================================ Main function ================================

int main()
{
	// Create variables
	POINT A, B, C, D;
	// Output the following and read data
	cout << "For the rectangle ABCD:\n";
	A.ReadData('A');
	B.ReadData('B');
	C.ReadData('C');
	D.ReadData('D');
	
	//Draw the rectangle
	A.Display('A'); cout << "-----------------------------------------"; B.Display('B'); cout << endl;
	cout << "\t     |                                        |" << endl;
	cout << "\t     |                                        |" << endl;
	cout << "\t     |                                        |" << endl;
	C.Display('C'); cout << "-----------------------------------------"; D.Display('D'); cout << endl;

	// Compute the length of each side
	float AB = Distance(A, B); cout << "\tAB=" << AB << endl;
	float AC = Distance(A, C); cout << "\tAC=" << AC << endl;
	float CD = Distance(C, D); cout << "\tCD=" << CD << endl;
	float BD = Distance(B, D); cout << "\tBD=" << BD << endl;

	//Compute and display permeter
	DisplayPer(AB, AC, CD, BD);

	// Pause the window
	system("pause");

	//Terminate program
	return 0;
}


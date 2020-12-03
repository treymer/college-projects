#include <iostream>

using namespace std;

class test
{
public:
	int afunction(){
		return 5;
	}
private:
	int three;
};
//================================main========================
int main()
{
	// Declare variables
	int numStudents, total = 0;
	float average = 0;

	cout << "Enter number of students: " << endl;
	cin >> numStudents;

	// Dynamic array
	int *movies = new int[numStudents];

	// input movies
	for (int i = 0; i < numStudents; i++)
	{
		cout << "Enter movies seen in a month for student " << i+1 << ": ";
		cin >> movies[i];
	}

	// Calculates total
	for (int i = 0; i < numStudents; i++)
		total += movies[i];

	// Calculates Average
	average = total / numStudents;

	// Outputs average
	cout << "The average movies seen in a month for " << numStudents << " students is " << average << endl;

	delete movies;
	// Pause
	system("PAUSE");
	// End program
	return 0;
}


#include <iostream>
#include <string>

using namespace std;

// Class PayRoll object
class PayRoll{
private:
	string employeeName;
	double hrlyRate;
	double hours;

public:
	PayRoll()
	{
		employeeName = "";
		hrlyRate = 0.0;
		hours = 0.0;
	}
	void readData()
	{
		cout << "Enter the employees name:" << endl;
		cin >> employeeName;
		cout << "Enter their rate of pay: " << endl;
		cin >> hrlyRate;
		cout << "Enter their hours worked: " << endl;
		cin >> hours;
	}

	void employeePay()
	{
		cout << employeeName << "'s pay is $" << hrlyRate * hours << endl;
	}
	~PayRoll(){};
};
//============================MAIN==================================
int main() {
	// Create array of objects
	PayRoll array[3];

	// For loop to read data into objects
	for (int i = 0; i < 3; ++i)
	{
		array[i].readData();
	}

	// For loop to calculate and print pay
	for (int i = 0; i < 3; ++i)
	{
	array[i].employeePay();
	}

	// End program
	return 0;

}


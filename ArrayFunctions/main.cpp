// Display array, find max, min, and average. Sort array and display.

#include <iostream>
#include <algorithm>
#include <iomanip>

using namespace std;

int main(){
	// Declare variable and array
	int a[6] = { 3, 9, 7, 8, 1, 4 };
	int max = a[0];
	int min = a[0];
	int total = 0;

	// Displays original array
	cout << fixed << setprecision(2);
	cout << "This is the original array a: ";

	for (int i = 0; i < 6; ++i){
		cout << a[i] << " ";
	}

	cout << endl;
	// Finds and display max and min
	for (int x = 0; x < 6; ++x){

		if (a[x] > max) max = a[x];
		if (a[x] < min) min = a[x];
		total += a[x];
	}
	cout << "Maximum = " << max << " Minimum = " << min << " Average = " << total / 6. << endl;
	// Sorts array and displays it
	sort(a, a + 6);

	cout << "This is the sorted form of array a: ";

	for (int i = 0; i < 6; ++i){
		cout << a[i] << " ";
	}
	cout << endl;

	system("PAUSE");
	return 0;
}


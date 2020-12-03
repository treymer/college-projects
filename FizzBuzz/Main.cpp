/*
* Created By: Tyler Reymer
* Course: ISDS 371
* Date: 1/31/16
* FIZZBUZZ - HW #1
*/

#include <iostream>
#include <string>

using namespace std;
//**************************************MAIN**************************************
int main()
{
	const string FIZZ = "Fizz";
	const string BUZZ = "Buzz";
	const string FIZZBUZZ = "FizzBuzz";
	 // Loop to check numbers 1 - 100
	for (int i = 1; i <= 100; i++)    
	{
		if (i % 15 == 0)  // If divisble by 3 & 5
		{
			cout << FIZZBUZZ << endl;
		}
		else if (i % 5 == 0)  // If divisible by 5
		{
			cout << BUZZ << endl;
		}
		else if (i % 3 == 0)  // If divisible by 3
		{
			cout << FIZZ << endl;
		}
		else             // Otherwise, print i
			cout << i << endl;
	}

	system("PAUSE");
	return 0;
}
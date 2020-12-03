/*
* Created By: Tyler Reymer
* Course: ISDS 371
* HW 1 Prime Numbers
* Date: 1/31/16
*/

#include <iostream>

using namespace std;

int main()
{
	int count = 0;
	for (int i = 2; i <= 100; i++)
	{
		bool prime = true;
		for (int j = 2; j*j <= i; j++)
		{
			if (i % j == 0)
			{
				prime = false;
				break;
			}
		}
		if (prime)
		{
			count++;
			cout << i << "\t";
			if (count >= 5)
			{
				cout << endl;
				count = 0;
			}
		}
	}

	system("PAUSE");
	return 0;
}
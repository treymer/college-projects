/*
* By: Tyler Reymer
* Class: ISDS 371
* Project: Arcade Scores, Homework #4
* Date: 5/5/16
*/

#include <iostream>
#include <string>
#include "player.h"
#include <vector>
#include <time.h>
#include <algorithm>

using namespace std;
//********************************************************* MAIN ***************************************************************
int main()
{
	const int DIVISOR = 10;

	vector<Player> players;
	unsigned index;
	Player player;
	string name = "";
	int guess = 0;
	int random = 0;
	int score = 0;
	int count = 0;

	cout << "Enter player name or ZZZ to quit: ";
	getline(cin, name);

	while (name != "ZZZ" && name != "zzz")
	{
		player.setName(name);

		cout << "Guess my number from 1 to 10: ";
		cin >> guess;

		srand((unsigned)time(NULL)); // seed time

		random = rand() % DIVISOR + 1;  // +1 makes it 1-10

		score = guess - random;

		if (score < 0)
		{
			score = score / -1; // If score is negative, make it positive
		}

		// Output random num and users score
		cout << "The number was " << random << endl;
		cout << player.getName() << ", your score is " << score << endl;
		player.setScore(score);

		// Push play object into vector
		players.push_back(player);

		if (score > 1)
		{
			cout << "Better luck next time.\n\n";
		}
		
		else
		{
			cout << "Very Good!\n\n";
		}

		cout << "All time champions list so far:\n"; 

		// Sort vector according to score
		sort(players.begin(), players.end());

		if (players.size() > 5) // Only display 5 top scores if vector size is larger than 5
		{
			for (index = 0; index < 5; ++index)
			{
				cout << players[index] << endl;
			}
		}
		else
		{
			for (index = 0; index < players.size(); ++index)
			{
				cout << players[index] << endl;
			}
		}

		cout << "Enter player name or ZZZ to quit: ";
		cin.ignore();
		getline(cin, name);		

	}

	system("PAUSE");
	return 0;
	//********************** END **********************
}


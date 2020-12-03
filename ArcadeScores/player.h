
#include <iostream>
#include <string>

using namespace std;

#ifndef _PLAYER_H_
#define _PLAYER_H_

class Player {
	friend ostream & operator << (ostream & out, const Player & plyr);

	private:
		string name;
		int score;
	public:
		string getName();
		int getScore();
		void setName(string name);
		void setScore(int score);
		bool operator < (Player & other);
};

#endif
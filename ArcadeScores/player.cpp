#include <iostream>
#include "player.h"
#include <string>

using namespace std;

int Player::getScore()
{
	return score;
}

string Player::getName()
{
	return name;
}

void Player::setScore(int score)
{
	this->score = score;
}

void Player::setName(string name)
{
	this->name = name;
}

ostream & operator << (ostream & out, const Player & plyr)
{
	out << plyr.score << "\t" << plyr.name;
	return out;
}

bool Player::operator < (Player & other)
{
	return this->score < other.score;
}


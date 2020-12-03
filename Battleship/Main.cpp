/*
Created By: Tyler Reymer
Created On: 02/23/2016
Project: Battleship, Homework 2
*/

#include <iostream>

using namespace std;

const int SHIP = 5;
const int SUNK = 2;
const int SIZE = 9;

void checkBoard(int gameBoard[][SIZE], int row, int column/*, const int SHIP, const int SUNK*/);
bool everythingSunk(int gameBoard[][SIZE]/*, const int SUNK*/);

int main() 
{
	int gameBoard[SIZE][SIZE] = { 0 };
	int row = 0;
	int column = 0;
	bool allShipsSunk = false;

	// Ship 1 - Submarine
	gameBoard[1][4] = SHIP;
	gameBoard[1][5] = SHIP;
	gameBoard[1][6] = SHIP;

	// Ship 2 - Frigate
	gameBoard[3][2] = SHIP;
	gameBoard[3][3] = SHIP;

	// Ship 3 - Battleship
	gameBoard[2][9] = SHIP;
	gameBoard[3][9] = SHIP;
	gameBoard[4][9] = SHIP;
	gameBoard[5][9] = SHIP;
	gameBoard[6][9] = SHIP;

	// Ship 4 - Destroyer
	gameBoard[5][4] = SHIP;
	gameBoard[6][4] = SHIP;
	gameBoard[7][4] = SHIP;

	// Ship 5 - Aircraft Carrier
	gameBoard[8][6] = SHIP;
	gameBoard[8][7] = SHIP;
	gameBoard[8][8] = SHIP;
	gameBoard[8][9] = SHIP;

	cout << "Welcome to Battleship!\n";
	cout << "========================\n";

	while (allShipsSunk != true)
	{
		cout << "Enter row: ";
		cin >> row;
		cout << "Enter a column: ";
		cin >> column;

		checkBoard(gameBoard, row, column/*, SHIP, SUNK*/);
		everythingSunk(gameBoard/*, SUNK*/);

		if (everythingSunk(gameBoard))
		{
			cout << "Congratulations! You have sunk all of the battleships!!!\n";
			allShipsSunk = true;
		}
		else
		{
			cout << "There are still battleships left to be sunk!\n";
		}

	}

	system("PAUSE");

	return 0;
}
void checkBoard(int gameBoard [][SIZE], int row, int column/*, const int SHIP, const int SUNK*/)
{

	/*for (int i = 0; i < SIZE; i++)
	{
		for (int j = 0; j < SIZE; j++)
		{*/
			if (gameBoard[row][column] = SUNK)
			{
				cout << "Already Hit!\n";
			}
			else if (gameBoard[row][column] = SHIP)
			{
				cout << "Hit!\n";
				gameBoard[row][column] = SUNK;
			}
			else
			{
				cout << "Miss!\n";
			}
	//	}
	//}
}

bool everythingSunk(int gameBoard[][SIZE]/*, const int SUNK*/)
{
	bool SubmarineSunk = false;
	bool FrigateSunk = false;
	bool BattleshipSunk = false;
	bool DestroyerSunk = false;
	bool AircraftCarrierSunk = false;

	if (gameBoard[1][4] == SUNK && gameBoard[1][5] == SUNK && gameBoard[1][6] == SUNK)
	{
		cout << "Submarine sunk!\n";
		SubmarineSunk = true;
	}
	
	else if (gameBoard[3][2] == SUNK && gameBoard[3][3] == SUNK)
	{
		cout << "Frigate sunk!\n";
		FrigateSunk = true;
	}
	else if (gameBoard[2][9] == SUNK && gameBoard[3][9] == SUNK && gameBoard[4][9] == SUNK && gameBoard[5][9] == SUNK && gameBoard[6][9] == SUNK)
	{
		cout << "Battleship sunk!\n";
		BattleshipSunk = true;
	}
	else if (gameBoard[5][4] == SUNK && gameBoard[6][4] == SUNK && gameBoard[7][4] == SUNK)
	{
		cout << "Destroyer sunk!\n";
		DestroyerSunk = true;
	}
	else if (gameBoard[8][6] == SUNK && gameBoard[8][7] == SUNK && gameBoard[8][8] == SUNK && gameBoard[8][9] == SUNK)
	{
		cout << "Aircraft Carrier sunk!\n";
		AircraftCarrierSunk = true;
	}

	if (SubmarineSunk && FrigateSunk && BattleshipSunk && DestroyerSunk && AircraftCarrierSunk)
	{
		return true;
		//cout << "Congratulations! You have sunk all of the battleships!!!\n";
	}
	else
	{
		return false;
	}

}
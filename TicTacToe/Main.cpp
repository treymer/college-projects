#include <iostream>
#include <string>

const int SIZE = 3;

using namespace std;

class TicTacToe
{
private:
	char gameBoard[SIZE][SIZE];
public:
	// Constructor
	TicTacToe();
	void printBoard();
	void TicTacToe::makeMove(char move, char XorO);
	void TicTacToe::checkWinner(char XorO, bool & winner);
	void TicTacToe::boardReset();
	// Destructor
	~TicTacToe();
};
TicTacToe::TicTacToe()
{
	int count = 49;
	for (int row = 0; row < SIZE; row++)
	{
		for (int column = 0; column < SIZE; column++)
		{
			gameBoard[row][column] = count;
			count++;
		}
	}
}
void TicTacToe::printBoard()
{
	cout << "     |     |     \n";
	cout << "  " << gameBoard[0][0] << "  |  " << gameBoard[0][1] << "  |  " << gameBoard[0][2] << endl;
	cout << "     |     |     \n";
	cout << "-----|-----|-----\n";
	cout << "     |     |     \n";
	cout << "  " << gameBoard[1][0] << "  |  " << gameBoard[1][1] << "  |  " << gameBoard[1][2] << endl;
	cout << "     |     |     \n";
	cout << "-----|-----|-----\n";
	cout << "     |     |     \n";
	cout << "  " << gameBoard[2][0] << "  |  " << gameBoard[2][1] << "  |  " << gameBoard[2][2] << endl;
	cout << "     |     |     \n";
}
void TicTacToe::makeMove(char move, char XorO)
{
	int numMove = move - '0';
	int count = 0;

		for (int row = 0; row < SIZE; row++)
		{
			for (int column = 0; column < SIZE; column++)
			{
				count++;
				if (count == numMove && gameBoard[row][column] == move)
				{
					gameBoard[row][column] = XorO;
					return;
				}
				else if ((gameBoard[row][column] == 'O' || gameBoard[row][column] == 'X') && gameBoard[row][column] != move && count == numMove)
				{
					cout << "You can't move there, try again: ";
					cin >> move;

					for (int row = 0; row < SIZE; row++)
					{
						for (int column = 0; column < SIZE; column++)
						{
							if (gameBoard[row][column] == move && gameBoard[row][column] != XorO)
							{
								gameBoard[row][column] = XorO;
								return;
							}
						}
					}
				}
				
			}
		}
	
}
void TicTacToe::checkWinner(char XorO, bool & winner)
{
	if ((gameBoard[0][0] == XorO && gameBoard[0][1] == XorO && gameBoard[0][2] == XorO) || (gameBoard[1][0] == XorO && gameBoard[1][1] == XorO && gameBoard[1][2] == XorO) || (gameBoard[2][0] == XorO && gameBoard[2][1] == XorO && gameBoard[2][2] == XorO))
		{
			cout << "Winner!\n"; 
			winner = true;
		}
	else if ((gameBoard[0][0] == XorO && gameBoard[1][0] == XorO && gameBoard[2][0] == XorO) || (gameBoard[0][1] == XorO && gameBoard[1][1] == XorO && gameBoard[2][1] == XorO) || (gameBoard[0][2] == XorO && gameBoard[1][2] == XorO && gameBoard[2][2] == XorO))
		{
			cout << "Winner!\n";
			winner = true;
		}
	else if ((gameBoard[0][0] == XorO && gameBoard[1][1] == XorO && gameBoard[2][2] == XorO) || (gameBoard[0][2] == XorO && gameBoard[1][1] == XorO && gameBoard[2][0] == XorO))
		{
			cout << "Winner!\n";
			winner = true;
		}
	else
		{
			winner = false;
		}
	
}
void TicTacToe::boardReset()
{
	int count = 49;
	for (int row = 0; row < SIZE; row++)
	{
		for (int column = 0; column < SIZE; column++)
		{
			gameBoard[row][column] = count;
			count++;
		}
	}
}
TicTacToe::~TicTacToe()
{}
int main()
{
	TicTacToe userGame;
	char XorO = '\0';
	char move = '\0';
	char playAgain = '\0';

	bool winner = false;
	bool playGame = true;
	
	while (playGame)
	{
		do
		{
			userGame.printBoard();
			cout << "It is X's Turn.\n";
			XorO = 'X';
			cout << "Enter your move: ";
			cin >> move;
			userGame.makeMove(move, XorO);
			
			userGame.checkWinner(XorO, winner);
			if (winner) { break; }

			userGame.printBoard();
			cout << "It is O's Turn.\n";
			XorO = 'O';
			cout << "Enter your move: ";
			cin >> move;
			userGame.makeMove(move, XorO);

			userGame.checkWinner(XorO, winner);
			if (winner) { break; }


		} while (winner == false);

		userGame.printBoard();

		cout << "Play again? (Y/N): ";
		cin >> playAgain;

		if (playAgain == 'Y' || playAgain == 'y')
		{
			playGame = true;
			userGame.boardReset();
		}
		else
			playGame = false;
	}

	userGame.printBoard();
	cout << "Winner!\n";


	system("PAUSE");

	return 0;
}
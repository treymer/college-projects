#include <iostream>
#include <ctime>
#include <algorithm>

using namespace std;

void shuffleDeck(int shuffleDeck[], int n);
void printDeck(int printDeck[], int n);
void sortDeck(int sortDeck[], int n);

//===============================Main==========================
int main() {
	// Declare deck 
	const int N = 52;
	int deck[N] = { 0 };

	// Assign 1-52 to deck
	for (int i = 0; i < N; ++i)
	{
		deck[i] = i + 1;
	}

	// Output deck
	for (int i = 0; i < N; ++i)
	{
		cout << deck[i] << " ";
	}
	cout << endl;

	srand(time(NULL));

	// Shuffle and output deck
	shuffleDeck(deck, N);
	printDeck(deck, N);

	cout << endl;

	// Sort deck and print 
	sortDeck(deck, N);
	printDeck(deck, N);

	system("PAUSE");

	// Terminate program
	return 0;
}

void shuffleDeck(int shuffleDeck[], int n)
{
	int random = 0;
	int temp;

	for (int i = 0; i < n; ++i)
	{
		random = rand() % 51 + 1;
		temp = shuffleDeck[i];
		shuffleDeck[i] = shuffleDeck[random];
		shuffleDeck[random] = temp;
	}
}

void printDeck(int printDeck[], int n)
{
	for (int i = 0; i < n; ++i)
	{
		cout << printDeck[i] << " ";
	}
}

void sortDeck(int sortDeck[], int n)
{
	sort(sortDeck, sortDeck + n);
}


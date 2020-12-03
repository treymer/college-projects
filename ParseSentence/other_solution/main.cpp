#include <iostream>
#include <cctype>

using namespace std;

// This is the function I created for vowels
bool isvowel(char c);

int main() {

	// Declare variables
	int NumberVowels = 0, NumberLowerCase = 0, NumberWords = 1, NumberUpperCase = 0;
	char c;

	// Gather users input
	cout << "Please enter a sentence: \n";
	cin.get(c);
	
	// While loop to check for words, vowels, upper and lower case
	while (c != '\n')
	{

		if (isupper(c))
			NumberUpperCase++;
		if (islower(c))
			NumberLowerCase++;
		if (isvowel(c))
			NumberVowels++;
		if (isspace(c))
			NumberWords++;

		cin.get(c);

	}

	// Output the results
	cout << "Number of upper case letters: " << NumberUpperCase << endl;
	cout << "Number of lower case letters: " << NumberLowerCase << endl;
	cout << "Number of vowels: " << NumberVowels << endl;
	cout << "Number of words: " << NumberWords << endl;

	system("PAUSE");

	return 0;
}

bool isvowel(char c)
{
	c = toupper(c);
	if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U') return true;
	else return false;

}


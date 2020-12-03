#include "Car.h"
#include <iostream>
#include <ctime>

using namespace std;

int main()
{
	const int LENGTH_OF_RACE = 500;
	const int DIVISOR = 200;

	int raceCarOneSpeed = 0;
	int raceCarTwoSpeed = 0;

	double money = 100.00;
	double winnings = 0;
	double bet = 0.0;
	int carBet, winningCar;

	cout << "Welcome to the Race Car Betting Game!\n"
		 << "=====================================" << endl << endl;

	cout << "You have $" << money << endl
		 << "How much would you like to bet? ";
	cin >> bet;

	while (money > 0 && bet > 0)
	{
		RaceCar raceCarOne, raceCarTwo;

		cout << "Which car do you want to bet on? ";
		cin >> carBet;
		cout << endl;

		raceCarOne.setCarIDNumber(1);
		raceCarTwo.setCarIDNumber(2);

		raceCarOne.turnIgnitionOn();
		raceCarTwo.turnIgnitionOn();

		while (raceCarOne.getMilesTraveled() < LENGTH_OF_RACE || raceCarTwo.getMilesTraveled() < LENGTH_OF_RACE)
		{
			srand((unsigned)time(NULL));
			raceCarOneSpeed = rand() % DIVISOR;
			raceCarOne.setSpeed(raceCarOneSpeed);
			raceCarOne.setMilesPerSpeed(raceCarOneSpeed);

			raceCarTwoSpeed = rand() % DIVISOR;
			raceCarTwo.setSpeed(raceCarTwoSpeed);
			raceCarTwo.setMilesPerSpeed(raceCarTwoSpeed);

		}

		if (raceCarOne.getMilesTraveled() > LENGTH_OF_RACE && raceCarOne.getMilesTraveled() > raceCarTwo.getMilesTraveled())
		{
			cout << "Car " << raceCarOne.getCarIDNumber() << " has won the race!" << endl << endl;
			winningCar = 1;
		}
		else
		{
			cout << "Car " << raceCarTwo.getCarIDNumber() << " has won the race!\n" << endl;
			winningCar = 2;
		}

		raceCarOne.showCar();
		raceCarTwo.showCar();

		if (carBet == winningCar)
		{
			cout << "Congratulation! Your car won!\n" << endl;
			money += bet;
		}
		else
		{
			cout << "You car lost! ";
			money -= bet;
		}

		cout << "You have $" << money << endl;

		if (money > 0)
		{
			cout << "How much would you like to bet? ";
			cin >> bet;
		}
	}

	cout << "You are out of money! Good Bye!" << endl;

	system("PAUSE");
	return 0;

}
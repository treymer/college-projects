#include <iostream>
#include <string>

using namespace std;

class Car{

private:
	int year;
	string make;
	int speed;

public:
	Car(int y, string mak){
		year = y;
		make = mak;
		speed = 0;
		//return 0;
	}
	int carInfo(int &x, string &y, int &z){
		x = year;
		y = make;
		z = speed;
		return 0;
	}
	void accelerate(){
		speed += 5;
	}
	void brake(){
		speed -= 5;
		cout << year << " " << make << " " << speed << "\n";
	}
};

int main(){

	int x, z;
	string y;

	Car Toyota(2015, "red");

	Toyota.accelerate();
	Toyota.accelerate();
	Toyota.accelerate();
	Toyota.accelerate();
	Toyota.accelerate();
	Toyota.carInfo(x, y, z);

	cout << x << " " << y << " " << z << "\n";

	Toyota.brake();
	Toyota.brake();
	Toyota.brake();
	Toyota.brake();
	Toyota.brake();
	Toyota.carInfo(x, y, z);

	cout << x << " " << y << " " << z << "\n";

	cin.get();

	return 0;
}


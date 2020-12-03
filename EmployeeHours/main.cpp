#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

void printDay(int n);

int main() {
    // Constant for number of employees
    const int N = 5;
    
    // enum for days of the week, arrays for employees names and hours
    enum weekDay {Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
    string employeeName[N];
    double employeeHours[N][7] = {0.0};
    
    // double to hold weekend hours
    double weekendHours = 0.0;
    
    for(int i = 0; i < N; ++i)
    {
        cout << "Enter the employee name: ";
        cin >> employeeName[i];
        
        for(weekDay day = Sunday; day <= Saturday; day = static_cast<weekDay> (day +1))
        {
            cout << "Enter hours for "; printDay(day); cout << ": ";
            cin >> employeeHours[i][day];
        }
        cout << endl;
    }
    
    // Output labels for table
    for(weekDay day = Sunday; day <= Saturday; day = static_cast<weekDay> (day +1))
    {
        cout << setw(15); printDay(day); //cout << setw(11);
    }
    cout << endl;
    
    cout << fixed << showpoint << setprecision(2);
    
    // Display solid double line
    for(int i = 0; i <= 110; ++i)
    {cout << "_";}
    
    cout << endl;
    
    // Output table
    for(int i = 0; i < N; ++i)
    {
        cout << left << setw(8) << employeeName[i] << "  " << setw(15);
        for(weekDay day = Sunday; day <= Saturday; day = static_cast<weekDay> (day +1))
        {
            if(day == Saturday || day == Sunday)
            {
                employeeHours[i][day] = employeeHours[i][day] * 1.5;
            }
            cout << setw(15) << employeeHours[i][day];
        }
        cout << endl;
        weekendHours = 0.0;
    }
    
    return 0;
    
}
// Function to print the day of the week
void printDay(int n)
{
    switch(n){
        case 1: cout << "Sunday"; break;
        case 2: cout << "Monday"; break;
        case 3: cout << "Tuesday"; break;
        case 4: cout << "Wednesday"; break;
        case 5: cout << "Thursday"; break;
        case 6: cout << "Friday"; break;
        case 7: cout << "Saturday"; break;
    }
}


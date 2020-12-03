// Find the 43rd Fibonacci number and time how long it takes using recursive and non.

#include <iostream>
#include <ctime>

 using namespace std;
 // User defined functions
 long long RecursiveFibo(size_t n);
 long long NonRecursiveFibo(size_t n);

 int main()
 {	// Declare integers
	 int begin;
	 int end;
	 // Begin clock and call functions
	 begin = clock();
	 cout << "The 43rd Fibonacci number is " << RecursiveFibo(43) << ". " << endl;
	 end = clock();
	 cout << "The run-time of this recursive function is " << (end - begin) / CLK_TCK << " seconds." << endl;
	 begin = clock();
	 cout << "The 43rd Fibonacci number is " << NonRecursiveFibo(43) << ". " << endl;
	 end = clock();
	 cout << "The run-time of this non-recursive function is " << (end - begin) / CLK_TCK << " seconds." << endl;

	// terminate the program

	system("pause");
	return 0;
}
long long RecursiveFibo(size_t n)
 {
	 if (n <= 2)
		 {return 1;}
	 else
		 {return RecursiveFibo(n - 1) + RecursiveFibo(n - 2);}
}

 long long NonRecursiveFibo(size_t n)
 {
	 long long first = 1;
	 long long second = 1;
	 long long next;
	 if (n <= 2)
	 {
		 return 1;
	 }
		 for (int i = 2; i < n; ++i)
		 {
			 next = first + second;
			 first = second;
			 second = next;
		 }
   return next;

	}


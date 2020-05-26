// This is a single-line comment.

/* Multi-line comments!
Useful for explaining stuff
in detail. */

#include <iostream> // gives access to cin, cout, etc.
#include <string> // for c++ strings

/* 
  uncomment the following line 
  if you want to avoid appending the prefix `std::` 
  to cin, cout, string, etc. 
  See the cheatsheet for more information.
*/
// using namespace std; 

int main()
{

  // Integer objects are declared like this
  int i = 0;

  // Other fundamental data types: 
  float f = 0.0;
  double d = 0.0; // more precise than float
  bool b = true;
  char c = "x"; // single character (ASCII standard by default)

  // Re-assigning values
  f = 1.0;
  b = false;
  
  // Take care when you mix and match variables of different types.
  // Depending on the conversion, it may behave in unexpected ways.
  // We'll touch upon this more later.
  d = f + 0.1;
  
  for (i = 0; i < 10; i++) {
    // print the value of i on a new line
    std::cout << i << std::endl;
  }

  std::string user_input;
  std::cin >> user_input;

  // You can chain as many shift operations as you like
  std::cout << "echoing" << user_input << std:endl;

  while (i > 0) {
    // cout can print different types in the same function call.
    std::cout << "In " << i << "..." << std::endl;

    // Make sure to evaluate a _changing_ condition 
    // so you don't loop infinitely!
    i--; 
  }

  
  /* 

  By convention, returning 0 means success and 1 means failure.
  Programs running your code may do something different depending
  on this return code.

  */
  return i;
}
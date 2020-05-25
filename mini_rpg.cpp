#include <iostream>
#include <string>

int main()
{
  // Create a string. Note that it was imported at the top
  std::string welcome_message = "Welcome, please enter your name: ";
  std::cout << welcome_message;

  std::string player_name = "Player";
  // Read in a value the user typed into the command line
  std::cin >> player_name;

  // print to the console
  std::cout << "Welcome, player " + player_name << std::endl;
}
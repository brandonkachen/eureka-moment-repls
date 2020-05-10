#define DEBUG

using System;
using System.Diagnostics;

class Level0 
{
  static int Main()
  {
    /* 
    Level #0: Welcome, player! 
    
    Choose your hero and make sure the following assertion 
    holds true.

    */

    string[] heros = {"warrior", "archer", "mage", "orc"};
    string hero_name = ""; // fixme
    int hero_id = -1; // fixme

    try
    {
      Debug.Assert(hero_name == heros[hero_id]);
    }
    catch 
    {
      Console.WriteLine("1.1 - wrong.");
      return 0;
    }

    Console.WriteLine("1.1 - correct.");

    /*

    Great, now we're ready to start on our journey. 
    If you had chosen to be a warrior, you'll take 
    the warrior path, which is in the northern direction. 
    If you chose to be an archer instead, you'll be starting off 
    in the eastern direction. 
    If you chose to be a mage, you'll start off in facing the south. 
    Finally, if you chose to be an orc, you'll start towards the west.

    We'll represent the map as a coordinate plane. North means moving 
    along the y-axis in a positive direction, east means moving along 
    the x-axis in a positive direction, etc. Your player will walk 10 steps 
    in the direction you've chosen. 
    
    Encapsulate this logic using if-statements.

    */

    playerCoord = (0,0);

    //fixme
    if (false) 
    {
      
    }

    /* 
    
    Oops! We forgot to pick up some travel supplies. Let's go back really quickly.

    For funsies, let's switch it up by using a switch-case statement (see what I did there?).

    Encapsulate the logic of walking backward in a switch-case statement.
    */

    //fixme
    switch(false)
    {
      case false:
        break;
      default:
        break;
    }

    try
    {
      Debug.Assert(playerCoord == (0,0));
    }
    catch 
    {
      Console.WriteLine("1.2/1.3 - wrong.");
      return 0;
    }

    Console.WriteLine("1.2/1.3 - correct.");

    /*

    We may have ended up back where we started, but we're wiser for it!
    For one thing, we know how annoying it is to handle these low-level
    operations for direction and distance. Let's make our future lives easier.
    
    Write a function whose input is:
    * the player's current coordinates
    * the direction they are heading in
    * the distance they traveled.
    and returns the player's final coordinates.

    */

    try 
    {
      Debug.Assert(GetNewCoords((0,0), "NORTH", 3) == (0,3));
      Debug.Assert(GetNewCoords((1,0), "SOUTH", 46) == (-45, 0));
      Debug.Assert(GetNewCoords((22,42), "EAST", 20) == (42,42));
      Debug.Assert(GetNewCoords((101,53), "WEST", 1) == (100,53));
      Debug.Assert(GetNewCoords((0,0), "WEST", -11) == (11,0));
    }
    catch
    {
      Console.WriteLine("1.4 - wrong.");
      return 0;
    }
    
    Console.WriteLine("1.4 - correct.");

    /*

    Phew! Good work, we've reached the end of this level. 
    Make sure to save your work (repl.it should autosave it for you)
    and feel free to add some more tests in here to verify 
    everything is working as expected. The road ahead is filled
    with easy and hard problems to solve, so don't fret if you
    don't get everything. You're not supposed to, otherwise there'd
    be nothing to teach!

    Best of luck!

    */
    
    return 0;
  }
}

public int GetNewCoords() //fixme
{
  return (0,0);
}
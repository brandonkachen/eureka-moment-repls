// Control Flow + Arrays

using System;

class Game
{
  static void assertEqual<T>(T actual, T expected, string testName) where T : System.IComparable<T>
  // static void assertEqual<T>(T actual, T expected, string testName)
  {
    if (actual.CompareTo(expected) == 0)
    {
      Console.WriteLine(testName + " - test passed.");
    }
    else
    {
      Console.WriteLine(testName + " - test failed.");
    }
  }

  static int Main()
  {

    /* 

    Welcome, player! Choose your hero to begin.
    
    1: Make sure the following assertion holds true.

    */

    string[] hero_choices = {"warrior", "archer", "mage", "ninja"};
    string hero = ""; // fixme
    int hero_id = 0; // fixme

    string ct_prefix = "ControlFlowAndArrays: ";
    string ct = ct_prefix + "1";
    assertEqual(hero, hero_choices[hero_id], ct);

    /*

    Great, now we're ready to start on our journey. 
    If you had chosen to be a warrior, you'll take 
    the warrior path, which is in the northern direction. 
    If you chose to be an archer instead, you'll be starting off 
    in the eastern direction. 
    If you chose to be a mage, you'll start off in facing the south. 
    Finally, if you chose to be an ninja, you'll start towards the west.

    We'll represent the map as a coordinate plane. North means moving 
    along the y-axis in a positive direction, east means moving along 
    the x-axis in a positive direction, etc. Your player will walk 10 
    steps in the direction you've chosen. For example, a mage's final 
    coordinates would be (0,-10). 
    
    2: Encapsulate this logic using if-statements.

    */

    (int, int) playerCoord = (0,0);

    //fixme
    if (false) 
    {
      
    }

    /* 
    
    Oops! We forgot to pick up some travel supplies. Let's go back really quickly.

    For funsies, let's switch it up by using a switch-case statement (see what I did there?).

    3: Encapsulate the logic of walking backward in a switch-case statement.

    */

    //fixme
    switch(false)
    {
      default:
        break;
    }

    // assertEqual(playerCoord, (0, 0), "2 & 3"); //uncommentme when you're ready to test

    /*

    We may have ended up back where we started, but we're wiser for it!
    For one thing, we know how annoying it is to handle these low-level
    operations for direction and distance. Let's make our future lives easier.
    
    4: Write a function whose input is:
    * the player's current coordinates
    * the direction they are heading in
    * the distance they traveled.
    and returns the player's final coordinates.

    */

    ct = ct_prefix + "4";
    assertEqual(GetNewCoords((0,0), "NORTH", 3), (0,3), ct + ".1");
    assertEqual(GetNewCoords((1,0), "SOUTH", 46), (-45, 0), ct + ".2");
    assertEqual(GetNewCoords((22,42), "EAST", 20), (42,42), ct + ".3");
    assertEqual(GetNewCoords((101,53), "WEST", 1), (100,53), ct + ".4");
    assertEqual(GetNewCoords((0,0), "WEST", -11), (11,0), ct + ".5");
    assertEqual(GetNewCoords((0,0), "WEST", -11), (11,0), ct + ".6");

    /*

    Uh oh! Just as you picked up your supplies, a group of wild goblins
    spotted you and are running toward you! You must stand your ground and fight.
    There are five goblins, and their health levels are represented in 
    an array below. 
    
    Warriors deal 10 damage per turn.
    Archers deal 5 damage per turn.
    Mages deal 7 damage per turn.
    Ninjas deal 3 damage per turn.
    Goblins deal 1 damage per turn.

    The battle is turn-based, starting with you. Each entity gets a turn to 
    deal damage and can pick any other entity to attack. Damage can only be done
    to one entity, even if it exceeds the entity's health. Health cannot go below 0.
    You start attacking first.

    5: Implement the "fightGoblins" function, which automates this brawl according
    to the rules above. Its output is the player's current health 

    */

    int playerHealth = 100;
    int[] goblinHealths = { 10, 7, 5, 8, 9 };

    var fightResult = fightGoblins(playerHealth, hero, goblinHealths);
    playerHealth = fightResult.Item1;
    goblinHealths = fightResult.Item2;
    int turnsTaken = fightResult.Item3;

    ct = ct_prefix + "5";
    assertEqual(playerHealth, 0, ct);

    if (hero == "warrior") {
      assertEqual(turnsTaken, 5, ct);
    }
    else if (hero == "archer") {
      assertEqual(turnsTaken, 9, ct);
    }
    else if (hero == "mage") {
      assertEqual(turnsTaken, 8, ct);
    } 
    else if (hero == "ninja") {
      assertEqual(turnsTaken, 15, ct);
    }
    else {
      assertEqual(false, true, ct);
    }

    /*

    Great job vanquishing your enemies! In addition to other useful supplies,
    you found a map of the local area elevation, which is represented as a 2D 
    array. Why don't we open it and see what the terrain around us looks like? 

    6: Print the map out to the console. Your output should look like:

    0000000
    0046810
    0133210
    0122210
    0111110
    0000000

    */

    int[,] elevationMap = { 
      { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 0 }, { 0, 4, 3, 2, 1, 0 }, { 0, 6, 3, 2, 1, 0 }, { 0, 8, 2, 2, 1, 0 }, { 0, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }
      };
      
    /*

    Phew! Good work, we've reached the end of this level. 
    Make sure to save your work (repl.it should autosave it for you)
    and feel free to add some more tests in here to verify 
    everything is working as expected.

    */
    
    return 0;
  }

  static (int, int) GetNewCoords((int, int) coord, string dir, int distance) //fixme
  {
    return (0,0);
  }

  static (int, int[], int) fightGoblins(int ph, string hero, int[] gh) //fixme
  {
    return (100, gh, 0);
  }
}

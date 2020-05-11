// Classes

using System;

/*

For this section, we'll be building basic moving game entities 
inspired by the "mobs" in the game Minecraft. 
We'll call ours "emobs" (eureka mobs).

We'll have four types of emobs: passive, neutral, hostile.
Each of our emobs has these attributes:
* health -> health of the emob
* awarenessRadius -> how close (in blocks) a player must be for the emob to detect them
* detectionAction -> action the emob takes when it detects a player
* hurtAction -> action the emob takes when it is hurt

1: Create classes for these emobs following the attributes described in each section. Also, add a function to each emob class called "listAtts" that writes all of the emob's attributes to the console. This function takes in no parameters and doesn't return.

*/

/* 

Passive emobs:
* health: 10
* awarenessRadius: 16
* detectionAction: "nothing"
* hurtAction: "run_away_randomly"

*/
public class Bat
{
  //todo: fill this out!

  
}

public class Fox
{
  //todo: fill this out!
}

/* 

Neutral emobs:
* health: 15
* awarenessRadius: 16
* detectionAction: "nothing"
* hurtAction: "attack"

*/
public class Dolphin
{
  //todo: fill this out!
}

public class Enderman
{
  //todo: fill this out!
}

/* 

Hostile emobs:
* health: 25
* awarenessRadius: 20
* detectionAction: "attack"
* hurtAction: "attack"

*/

public class Slime
{
  //todo: fill this out!
}

public class Creeper
{
  //todo: fill this out!
}

/*

Hm, these emobs are a bit too similar.
Let's give them names when we create them and have them
say their names back to us.

2: Add code to the classes above so each of their objects say: "I'm <name> and I'm a/an <emob-class-name>." when they are instantiated.

*/


/*

Ok, looking good. Now we know everything they're doing at all times...
Except when they die! That's a pretty important piece of the puzzle,
especially for the hostile emobs. Let's fix this.

3: Add code to the classes above so each of their objects say: "Goodbye, cruel world." when they are removed.

*/

class Emobs
{
  static int Main()
  {
    //uncomment the following lines when you're ready to test
    // Bat bat1 = new Bat("Leopold"); // creation event: "I'm Leopold and I'm a Bat!"
    // bat1.listAtts();
    // bat1.Dispose(); // deletion event: "Goodbye, cruel world."
    return 0;
  }
}
/*
In this project, I use logic and conditional statements to write a classic text-based Choose Your Own Adventure Game. 
Depending on what choices the user makes, the program will have a different result.
*/

using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

      // Start the story
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

      // Inform user what to do next
      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      string capNoiseChoice = noiseChoice.ToUpper();

      // Test point: save and run code

      // Add user decison outcomes
      if (capNoiseChoice == "NO") {
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
        Console.WriteLine("The END.");
        return;
      } 
      else if (capNoiseChoice == "YES") {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
      }
      
      // It is time for user to make another decision
       Console.Write("Type OPEN or KNOCK: ");
       string doorChoice = Console.ReadLine();
       string capDoorChoice = doorChoice.ToUpper();
       
       // Add another user decison outcomes
      if (capDoorChoice == "KNOCK") {
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
        Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
        Console.Write("Type your answer: ");
        string riddleAnswer = Console.ReadLine();
        string capRiddleAnswer = riddleAnswer.ToUpper();
        
        if (capRiddleAnswer == "NOTHING") {
          Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door.");
          Console.WriteLine("The END.");
          return;
        } else {
          Console.WriteLine("You answered incorrectly. The door doesn't open.");
          Console.WriteLine("The END.");
          return;
        }

      } 
      else if (capDoorChoice == "OPEN") {
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");

        Console.Write("Enter a number (1-3): ");
        string keyChoice = Console.ReadLine();
    
        switch (keyChoice) 
        {
          case "1":
            Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange... The END");
            break;
          case "2":
            Console.WriteLine("You choose the second key. The door doesn't open. The END");
            break;
          case "3":
            Console.WriteLine("You choose the third key. The door doesn't open. The END");
            break;
          default:
            Console.WriteLine("Invalid selection");
            break;

        }
      }
    }
  }
}

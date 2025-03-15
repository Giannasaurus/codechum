/** Name Input
    Write a program that prompts the user to enter their name and then prints a welcome message that includes their name.

    * Sample Output 1
      > Enter your name: Cody
        Welcome, Cody!

    * Sample Output 2
      > Enter your name: David
        Welcome, David!

    * Sample Output 3
      > Enter your name: Vincent
        Welcome, Vincent! */

using System;

class MainClass {
    static public void Main()
    {
        // variables
        string name="";
        
        // ask user for name
        Console.Write("Enter your name: ");
        name=Console.ReadLine();
        
        // result
        Console.Write($"Welcome, {name}!");
    }
}

/** passed test cases
  * test case 1:
    > Enter your name: Cody
      Welcome, Cody!
  * test case 2:
    > Enter your name: David
      Welcome, David!
  * test case 3:
    > Enter your name: Vincent
      Welcome, Vincent!
  * test case 4:
    > Enter your name: Raul
      Welcome, Raul!
  * test case 5:
    > Enter your name: Johnray
      Welcome, Johnray!
  * test case 6: 
    > Enter your name: Elon
      Welcome, Elon! */

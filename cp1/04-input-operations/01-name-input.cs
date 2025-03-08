/* Name Input
  Write a program that prompts the user to enter their name and then prints a welcome message that includes their name.

  Sample Output 1
  > Enter your name: Cody
    Welcome, Cody!

  Sample Output 2
  > Enter your name: David
    Welcome, David!

  Sample Output 3
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

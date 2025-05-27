/** Two String Input
    Write a program that asks for two string inputs, first and second, and prints the strings in the following format: "{first} {second} {first}"
  
  * Sample Output 1
    > Enter the first string: Hello
      Enter the second string: World
      Hello World Hello

  * Sample Output 2
    > Enter the first string: Code
      Enter the second string: Chum
      Code Chum Code

  * Sample Output 3
    > Enter the first string: First
      Enter the second string: Second
      First Second First */

using System;

class Program {
    static void Main() {
        // variables
        string first="", second="";
        
        // ask for 2 strings
        Console.Write("Enter the first string: ");
        first=Console.ReadLine();
        Console.Write("Enter the second string: ");
        second=Console.ReadLine();
        
        // display with format
        Console.Write($"{first} {second} {first}");
    }
}

/** passed test cases
  * test case 1:
    > Enter the first string: Hello
      Enter the second string: World
      Hello World Hello
  * test case 2:
    > Enter the first string: Code
      Enter the second string: Chum
      Code Chum Code
  * test case 3:
    > Enter the first string: First
      Enter the second string: Second
      First Second First
  * test case 4:
    > Enter the first string: One
      Enter the second string: Piece
      One Piece One
  * test case 5:
    > Enter the first string: Python
      Enter the second string: Java
      Python Java Python
  * test case 6:
    > Enter the first string: Chum
      Enter the second string: Code
      Chum Code Chum */

/* Three Strings Now
  Write a program that asks for three string inputs, first, second, and third. Print the following strings in the format: {first} - {second} - {third}
  
  > Sample Output 1
    Enter the first string: Hello
    Enter the second string: World
    Enter the third string: Test
    Hello - World - Test

  > Sample Output 2
    Enter the first string: First
    Enter the second string: Second
    Enter the third string: Third
    First - Second - Third

  > Sample Output 3
    Enter the first string: Always
    Enter the second string: Been
    Enter the third string: Alive
    Always - Been - Alive */

using System;

class Program {
    static void Main() {
        // variables
         string first="", second="", third="";
         
        // ask for 3 strings
        Console.Write("Enter the first string: ");
        first=Console.ReadLine();
        Console.Write("Enter the second string: ");
        second=Console.ReadLine();
        Console.Write("Enter the third string: ");
        third=Console.ReadLine();
        
        // display with format
        Console.Write($"{first} - {second} - {third}");
    }
}

/** passed test cases
  * test case 1:
    Enter the first string: Hello
    Enter the second string: World
    Enter the third string: Test
    Hello - World - Test
  * test case 2:
    Enter the first string: First
    Enter the second string: Second
    Enter the third string: Third
    First - Second - Third
  * test case 3:
    Enter the first string: Always
    Enter the second string: Been
    Enter the third string: Alive
    Always - Been - Alive
  * test case 4:
    Enter the first string: Root
    Enter the second string: Rat
    Enter the third string: Reed
    Root - Rat - Reed
  * test case 5:
    Enter the first string: x
    Enter the second string: y
    Enter the third string: z
    x - y - z
  * test case 6:
    Enter the first string: aa
    Enter the second string: bb
    Enter the third string: cc
    aa - bb - cc */

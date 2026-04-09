/** Concatenating Hello
    Create a program that asks the user a enter string. Use the predefined string function to concatenate the string "Hello" to the entered string and print the result.

    * Sample Output 1
      > Enter a string: world
        Concatenated string: worldHello

    * Sample Output 2
      > Enter a string: chum
        Concatenated string: chumHello

    * Sample Output 3
      > Enter a string: Hello
        Concatenated string: HelloHello */

using System;

class Program {
    static void Main() {
        // variables
        string hello="Hello", world, concatStr;
        
        // ask for string
        Console.Write("Enter a string: ");
        world=Console.ReadLine();
        
        // concat hello to input
        concatStr=world+hello;
        
        // display concatenated string
        Console.Write($"Concatenated string: {concatStr}");
    }
}

/** passed test cases
  * test case 1:
    > Enter a string: world
Concatenated string: worldHello
  * test case 2:
    > Enter a string: chum
Concatenated string: chumHello
  * test case 3:
    > Enter a string: Hello
Concatenated string: HelloHello
  * test case 4:
    > Enter a string: Hi
Concatenated string: HiHello
  * test case 5:
    > Enter a string: Arf
Concatenated string: ArfHello
  * test case 6:
    > Enter a string: Meow
Concatenated string: MeowHello */

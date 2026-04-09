/** Sentence Length
    Write a program that calculates and prints the length of the given string in the code editor using the predefined string function.

    * Sample Output 1
      > Length of the string: 19 */

using System;

class Program {
    static void Main() {
        string str = "Programming is Fun!";
        int length;
        
        // calculate string length
        length = str.Length;
        
        // display string length
        Console.Write($"Length of the string: {length}");
    }
}

/** passed test cases
  * test case 1:
    > Length of the string: 19 */

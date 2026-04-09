/** String to Integer
    Write a program that takes a string input and then converts the input into an integer. Print the new integer in format "String converted to integer: {integer}".

  * Sample Output 1
    > Enter a string: 222
      String converted to integer: 222

  * Sample Output 2
    > Enter a string: 343
      String converted to integer: 343

  * Sample Output 3
    > Enter a string: 243
      String converted to integer: 243 */

using System;

class Program {
    static void Main() {
        // variables
        string stringInput="";
        int integer;
        
        // ask for string
        Console.Write("Enter a string: ");
        stringInput=Console.ReadLine();
        
        // str to int conversion
        integer=int.Parse(stringInput);
        
        // str converted to int
        Console.Write($"String converted to integer: {integer}");
    }
}

/** passed test cases
  * test case 1:
    > Enter a string: 222
      String converted to integer: 222
  * test case 2:
    > Enter a string: 343
      String converted to integer: 343
  * test case 3:
    > Enter a string: 243
      String converted to integer: 243
  * test case 4:
    > Enter a string: 2511
      String converted to integer: 2511
  * test case 5:
    > Enter a string: 3312
      String converted to integer: 3312
  * test case 6:
    > Enter a string: 512
      String converted to integer: 512 */

/** ASCII Sum
    Write a program that takes two characters. Add their integer equivalents and print the sum after in format "Sum: {result}".

    * Sample Output 1
      > Enter first character: A
        Enter second character: B
        Sum: 131
    
    * Sample Output 2
      > Enter first character: $
        Enter second character: 2
        Sum: 86
    
    * Sample Output 3
      > Enter first character: 1
        Enter second character: 3
        Sum: 100 */

using System;

class Program {
    static void Main() {
        // variables
        char char1, char2;
        int ascii1, ascii2, result;
        
        // ask for 2 characters
        Console.Write("Enter first character: ");
        char1=Console.ReadLine()[0];
        Console.Write("Enter second character: ");
        char2=Console.ReadLine()[0];
        
        // convert chars to int (ascii)
        ascii1=(int)char1;
        ascii2=(int)char2;
        
        // calculate sum of converted strings
        result=ascii1+ascii2;
        
        // result
        Console.Write($"Sum: {result}");
    }
}

/** passed test cases
  * test case 1:
    > Enter first character: A
      Enter second character: B
      Sum: 131
  * test case 2:
    > Enter first character: $
      Enter second character: 2
      Sum: 86
  * test case 3:
    > Enter first character: 1
      Enter second character: 3
      Sum: 100
  * test case 4:
    > Enter first character: 0
      Enter second character: *
      Sum: 90
  * test case 5:
    > Enter first character: -
      Enter second character: +
      Sum: 88
  * test case 6:
    > Enter first character: {
      Enter second character: }
      Sum: 248 */

/** Absolute Value Calculator
    Write a program that asks the user to enter a negative number. Use the predefined math function to print the absolute value of the number.

    * Sample Output 1
      > Enter a negative number: -1
        Absolute value: 1
    
    * Sample Output 2
      > Enter a negative number: -5
        Absolute value: 5

    * Sample Output 3
      > Enter a negative number: -500
        Absolute value: 500 */

using System;

class Program {
    static void Main() {
        // variables
        int negativeNum, absoluteValue;
        
        // ask for negative num 
        Console.Write("Enter a negative number: ");
        negativeNum=int.Parse(Console.ReadLine());
        
        // convert to absolute value
        absoluteValue=Math.Abs(negativeNum);
        
        // result
        Console.Write($"Absolute value: {absoluteValue}");
    }
}

/** passed test cases
  * test case 1:
    > Enter a negative number: -1
      Absolute value: 1
  * test case 2:
    > Enter a negative number: -5
      Absolute value: 5
  * test case 3:
    > Enter a negative number: -500
      Absolute value: 500
  * test case 4:
    > Enter a negative number: -2
      Absolute value: 2
  * test case 5:
    > Enter a negative number: -300
      Absolute value: 300
  * test case 6:
    > Enter a negative number: -33
      Absolute value: 33 */

/** Same Sign
    Write a program that takes two integers, num1 and num2, as input and checks if they have the same sign.
    If both num1 and num2 are greater than 0 or both are less than 0, it prints "Numbers have the same sign." Otherwise, it does nothing.

    * Sample Output 1
      > Enter first number: 245
        Enter second number: 3
        Numbers have the same sign.

    * Sample Output 2
      > Enter first number: -45
        Enter second number: 5
    
    * Sample Output 3
      > Enter first number: 0
        Enter second number: 1 */

using System;

class Program {
    static void Main() {
        int num1, num2; 
        
        Console.Write("Enter first number: ");
        num1=int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        num2=int.Parse(Console.ReadLine());
        
        if((num1 > 0 && num2 > 0) || (num1 < 0 && num2 < 0)) {
            Console.Write("Numbers have the same sign.");
        } else {
        }
    }
}

/** passed test cases
  * should use: if statement
  * test case 1:
    > Enter first number: 245
      Enter second number: 3
      Numbers have the same sign.
  * test case 2:
    > Enter first number: -45
      Enter second number: 5
  * test case 3:
    > Enter first number: 0
      Enter second number: 1
  * test case 4:
    > Enter first number: -1
      Enter second number: -9
      Numbers have the same sign.
  * test case 5:
    > Enter first number: 12
      Enter second number: 3
      Numbers have the same sign.
  * test case 6:
    > Enter first number: 9
      Enter second number: -9 */

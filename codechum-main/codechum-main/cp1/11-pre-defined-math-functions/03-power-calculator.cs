/** Power Calculator
    Create a program that asks the user to enter two numbers: a base and an exponent. Use the predefined math function to calculate and print the result of raising the base to the power of the exponent.

    * Sample Output 1
      > Enter the base: 2
        Enter the exponent: 3
        Result: 8.00

    * Sample Output 2
      > Enter the base: 5
        Enter the exponent: 2.2
        Result: 34.49

    * Sample Output 3
      > Enter the base: 8
        Enter the exponent: 3.3
        Result: 955.43 */

using System;

class Program {
    static void Main() {
        // variables
        double baseNum, exponentNum, result;
        
        // ask for 2 num 
        Console.Write("Enter the base: ");
        baseNum=double.Parse(Console.ReadLine());
        Console.Write("Enter the exponent: ");
        exponentNum=double.Parse(Console.ReadLine());
        
        // calculate raise base to power of exponent
        result=Math.Pow(baseNum,exponentNum);
        
        // result
        Console.Write($"Result: {result:f2}");
    }
}

/** passed test cases
  * test case 1:
    > Enter the base: 2
      Enter the exponent: 3
      Result: 8.00
  * test case 2:
    > Enter the base: 5
      Enter the exponent: 2.2
      Result: 34.49
  * test case 3:
    > Enter the base: 8
      Enter the exponent: 3.3
      Result: 955.43
  * test case 4:
    > Enter the base: 3.5
      Enter the exponent: 2
      Result: 12.25
  * test case 5:
    > Enter the base: 4.5
      Enter the exponent: 2
      Result: 20.25
  * test case 6:
    > Enter the base: 3
      Enter the exponent: 3
      Result: 27.00 */

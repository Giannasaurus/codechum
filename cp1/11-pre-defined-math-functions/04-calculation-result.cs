/** Calculation Result
    Write a program that prompts the user to enter two numbers. The program should use the predefined math functions to calculate the result by taking the absolute difference between the two numbers, raising it to the power of 3, and then finding the square root of the result. Finally, the program should print the calculated result in two decimal places.

    * Sample Output 1
      > Enter the first number: 5
        Enter the second number: 7
        Result: 2.83

    * Sample Output 2
      > Enter the first number: 10
        Enter the second number: 30
        Result: 89.44

    * Sample Output 3
      > Enter the first number: 2
        Enter the second number: 7
        Result: 11.18 */

using System;

class Program {
    static void Main() {
        // variables
        double num1, num2;
        double absDiff, powerOf3, result;
        
        // ask for 2 num 
        Console.Write("Enter the first number: ");
        num1=double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2=double.Parse(Console.ReadLine());
        
        // calculate absolute difference, raise to power of 3, and find sqrt of result
        absDiff=Math.Abs(num1-num2);
        powerOf3=Math.Pow(absDiff,3);
        result=Math.Sqrt(powerOf3);
        
        // display result in 2 dec places
        Console.Write($"Result: {result:f2}");
    }
}

/** passed test cases
  * test case 1:
    > Enter the first number: 5
      Enter the second number: 7
      Result: 2.83
  * test case 2:
    > Enter the first number: 10
      Enter the second number: 30
      Result: 89.44
  * test case 3:
    > Enter the first number: 2
      Enter the second number: 7
      Result: 11.18
  * test case 4:
    > Enter the first number: 5
      Enter the second number: 5
      Result: 0.00
  * test case 5:
    > Enter the first number: 21
      Enter the second number: 101
      Result: 715.54
  * test case 6:
    > Enter the first number: 33
      Enter the second number: 44
      Result: 36.48 */

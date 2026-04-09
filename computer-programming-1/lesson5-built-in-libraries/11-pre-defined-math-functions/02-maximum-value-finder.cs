/** Maximum Value Finder
    Write a program that asks the user to enter two numbers. Use the predefined math function to find and print the smallest value among the two numbers.
  
    * Sample Output 1
      > Enter the first number: 5
        Enter the second number: 6
        The largest number is: 6

    * Sample Output 2
      > Enter the first number: 10
        Enter the second number: 20
        The largest number is: 20

    * Sample Output 3
      > Enter the first number: 100
        Enter the second number: 200
        The largest number is: 200 */

using System;

class Program {
    static void Main() {
        // variables
        int num1, num2, largerNum;
        
        // ask for 2 num 
        Console.Write("Enter the first number: ");
        num1=int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2=int.Parse(Console.ReadLine());
        
        // find larger num 
        largerNum=Math.Max(num1,num2);
        
        // result
        Console.Write($"The largest number is: {largerNum}");
    }
}

/** passed test cases
  * test case 1:
    > Enter the first number: 5
      Enter the second number: 6
      The largest number is: 6
  * test case 2:
    > Enter the first number: 10
      Enter the second number: 20
      The largest number is: 20 
  * test case 3:
    > Enter the first number: 100
      Enter the second number: 200
      The largest number is: 200
  * test case 4:
    > Enter the first number: -1
      Enter the second number: 1
      The largest number is: 1
  * test case 5:
    > Enter the first number: -100
      Enter the second number: 100
      The largest number is: 100
  * test case 6:
    > Enter the first number: 3
      Enter the second number: 9
      The largest number is: 9 */

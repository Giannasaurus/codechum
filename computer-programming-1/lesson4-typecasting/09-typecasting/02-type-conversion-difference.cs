/** Type Conversion Difference
    Write a program that takes two numbers (one integer and one float) and take their difference after converting the integer to a float. Finally, print the result in format "The difference is: {result}".
    
    * Sample Output 1
      > Enter an integer: 5
        Enter a float: 3.14
        The difference is: 1.86
    
    * Sample Output 2
      > Enter an integer: 90
        Enter a float: 5.2321
        The difference is: 84.77
      
    * Sample Output 3
      > Enter an integer: 3
        Enter a float: 0.412421
        The difference is: 2.59 */

using System;

class Program {
    static void Main() {
        // variables
        int num1;
        float num2, difference;
        
        // ask for two numbers
        Console.Write("Enter an integer: ");
        num1=int.Parse(Console.ReadLine());
        Console.Write("Enter a float: ");
        num2=float.Parse(Console.ReadLine());
        
        // calculate difference
        difference=num1-num2;
        
        // result
        Console.Write($"The difference is: {difference:f2}");
    }
}

/** passed test cases
  * test case 1:
    > Enter an integer: 5
      Enter a float: 3.14
      The difference is: 1.86
  * test case 2:
    > Enter an integer: 90
      Enter a float: 5.2321
      The difference is: 84.77
  * test case 3:
    > Enter an integer: 3
      Enter a float: 0.412421
      The difference is: 2.59
  * test case 4:
    > Enter an integer: 4123
      Enter a float: 232.2321
      The difference is: 3890.77
  * test case 5:
    > Enter an integer: 50
      Enter a float: 232.12323
      The difference is: -182.12
  * test case 6:
    > Enter an integer: 1000
      Enter a float: 23.2323
      The difference is: 976.77 */

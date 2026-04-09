/** Addition and Subtraction
    Write a program that accepts two integer inputs, x, and y. Show the output when x is added by y, and also, when x is subtracted by y.
  
    * Sample Output 1
      > Enter x: 10
        Enter y: 5
        10 + 5 = 15
        10 - 5 = 5
    
    * Sample Output 2
      > Enter x: 18
        Enter y: 7
        18 + 7 = 25
        18 - 7 = 11
    
    * Sample Output 3
      > Enter x: 37
        Enter y: 66
        37 + 66 = 103
        37 - 66 = -29 */

using System;

class MainClass {
    static public void Main()
    {
        // variables
        int x, y, sum, diff;
        
        // ask for input
        Console.Write("Enter x: ");
        x=int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        y=int.Parse(Console.ReadLine());
        
        // calculate sum and difference
        sum=x+y;
        diff=x-y;
        
        // display output
        Console.WriteLine($"{x} + {y} = {sum}");
        Console.WriteLine($"{x} - {y} = {diff}");
    }
}

/** passed test cases
  * test case 1:
    > Enter x: 10
      Enter y: 5
      10 + 5 = 15
      10 - 5 = 5
  * test case 2:
    > Enter x: 18
      Enter y: 7
      18 + 7 = 25
      18 - 7 = 11
  * test case 3:
    > Enter x: 37
      Enter y: 66
      37 + 66 = 103
      37 - 66 = -29
  * test case 4:
    > Enter x: 84
      Enter y: 7
      84 + 7 = 91
      84 - 7 = 77
  * test case 5:
    > Enter x: 0
      Enter y: 0
      0 + 0 = 0
      0 - 0 = 0
  * test case 6:
    > Enter x: 1
      Enter y: 1
      1 + 1 = 2
      1 - 1 = 0*/

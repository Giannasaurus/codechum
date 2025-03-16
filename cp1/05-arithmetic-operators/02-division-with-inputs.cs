/** Division with Inputs
    Write a program that takes two numbers, x, and y, as input from the user and prints the quotient when x is divided by y.
  
    * Sample Output 1
      > Enter x: 10
        Enter y: 2
        Quotient: 5
    
    * Sample Output 2
      > Enter x: 6
        Enter y: 3
        Quotient: 2
    
    * Sample Output 3
    > Enter x: 4
      Enter y: 2
      Quotient: 2 */

using System;

class MainClass {
    static public void Main()
    {
        // variables
        int x, y;
        
        // ask for 2 numbers
        Console.Write("Enter x: ");
        x=int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        y=int.Parse(Console.ReadLine());
        
        // calculate quotient
        int quotient=x/y;
        
        // display output
        Console.Write("Quotient: " + quotient);
    }
}

/** passed test cases
  * test case 1:
    > Enter x: 10
      Enter y: 2
      Quotient: 5
  * test case 2:
    > Enter x: 6
      Enter y: 3
      Quotient: 2
  * test case 3:
    > Enter x: 4
      Enter y: 2
      Quotient: 2
  * test case 4:
    > Enter x: -200
      Enter y: 5
      Quotient: -40
  * test case 5:
    > Enter x: 20
      Enter y: 4
      Quotient: 5
  * test case 6:
    > Enter x: 1221
      Enter y: 3
      Quotient: 407 */

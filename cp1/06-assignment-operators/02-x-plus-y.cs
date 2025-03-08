/* X plus Y
  Write a program that asks for two integer numbers, x, and y. Then, add y to x, and assign it to x using the += operator.
  
  Sample Output 1
  > Enter x: 10
    Enter y: 5
    Result: 15
    
  Sample Output 2
  > Enter x: 1
    Enter y: 1
    Result: 2
    
  Sample Output 3
  > Enter x: 3
    Enter y: 4
    Result: 7 */

using System;

class Program {
    static void Main() {
        // variables
        int x, y;
        
        // ask for input
        Console.Write("Enter x: ");
        x=int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        y=int.Parse(Console.ReadLine());
        
        // add y to x 
        x+=y;
        
        // display sum
        Console.Write("Result: {0}", x);
    }
}

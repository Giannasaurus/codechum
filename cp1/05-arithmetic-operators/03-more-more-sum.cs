/* More, more sum
  Write a program that takes in three integer inputs, x, y, and z, and prints their sum.
  
  Sample Output 1
  > Enter x: 10
    Enter y: 24
    Enter z: 3
    Sum: 37
    
  Sample Output 2
  > Enter x: 7
    Enter y: 9
    Enter z: 4
    Sum: 20
    
  Sample Output 3
  > Enter x: 20
    Enter y: 46
    Enter z: 56
    Sum: 122 */

using System;

class MainClass {
    static public void Main()
    {
        // variables
        int x, y, z;
        
        // ask for input
        Console.Write("Enter x: ");
        x=int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        y=int.Parse(Console.ReadLine());
        Console.Write("Enter z: ");
        z=int.Parse(Console.ReadLine());
        
        // calculate sum
        int sum=x+y+z;
        
        // display output
        Console.Write("Sum: " + sum);
    }
}

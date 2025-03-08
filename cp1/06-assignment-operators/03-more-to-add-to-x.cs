/* More To Add to X
  Write a program that asks for three integer numbers, x, y, and z. Then, add y and z to x, and assign it to x using the += operator.
  
  Sample Output 1
  > Enter x: 1
    Enter y: 2
    Enter z: 3
    Result: 6
    
  Sample Output 2
  > Enter x: 1
    Enter y: 1
    Enter z: 1
    Result: 3
    
  Sample Output 3
  > Enter x: 2
    Enter y: 4
    Enter z: 6
    Result: 12 */

using System;

class Program {
    static void Main() {
        // variables
        int x, y, z;
        
        // ask for input
        Console.Write("Enter x: ");
        x=int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        y=int.Parse(Console.ReadLine());
        Console.Write("Enter z: ");
        z=int.Parse(Console.ReadLine());
        
        // add y and z to x 
        x+=y+=z;
        
        // display sum
        Console.Write("Result: {0}", x);
    }
}

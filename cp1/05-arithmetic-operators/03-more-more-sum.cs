/** More, more sum
    Write a program that takes in three integer inputs, x, y, and z, and prints their sum.
  
    * Sample Output 1
      > Enter x: 10
        Enter y: 24
        Enter z: 3
        Sum: 37
    
    * Sample Output 2
      > Enter x: 7
        Enter y: 9
        Enter z: 4
        Sum: 20
    
    * Sample Output 3
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

/** passed test cases
  * test case 1:
    > Enter x: 10
      Enter y: 24
      Enter z: 3
      Sum: 37
  * test case 2:
    > Enter x: 7
      Enter y: 9
      Enter z: 4
      Sum: 20
  * test case 3:
    > Enter x: 20
      Enter y: 46
      Enter z: 56
      Sum: 122
  * test case 4:
    > Enter x: 20
      Enter y: 84
      Enter z: 66
      Sum: 170
  * test case 5:
    > Enter x: 46
      Enter y: 34
      Enter z: 22
      Sum: 102
  * test case 6:
    > Enter x: 100
      Enter y: 99
      Enter z: 747
      Sum: 946 */

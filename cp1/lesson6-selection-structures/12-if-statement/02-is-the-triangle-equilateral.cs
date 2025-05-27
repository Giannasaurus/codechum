/** Is The Triangle Equilateral?
    Write a program that takes three integers x, y, and z, as input and checks if they represent the sides of an equilateral triangle.
    An equilateral triangle has all sides of equal length, so this function checks if x, y, and z are all equal.
    If they are equal, it prints "Triangle is equilateral." Otherwise, it does nothing.

    * Sample Output 1
      > Enter x: 10
        Enter y: 5
        Enter z: 4

    * Sample Output 2
      > Enter x: 5
        Enter y: 5
        Enter z: 5
        Triangle is equilateral.

    * Sample Output 3
      > Enter x: 4
        Enter y: 4
        Enter z: 4
        Triangle is equilateral. */

using System;

class Program {
    static void Main() {
        int x,y,z;
        
        Console.Write("Enter x: ");
        x=int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        y=int.Parse(Console.ReadLine());
        Console.Write("Enter z: ");
        z=int.Parse(Console.ReadLine());
        
        if(x==y && y==z && z==x) {
            Console.Write("Triangle is equilateral.");
        } else {
        }
    }
}

/** passed test cases
  * should use: if statement
  * test case 1:
    > Enter x: 10
      Enter y: 5
      Enter z: 4
  * test case 2:
    > Enter x: 5
      Enter y: 5
      Enter z: 5
      Triangle is equilateral.
  * test case 3:
    > Enter x: 4
      Enter y: 4
      Enter z: 4
      Triangle is equilateral.
  * test case 4:
    > Enter x: 6
      Enter y: 7
      Enter z: 9
  * test case 5:
    > Enter x: 10
      Enter y: 42
      Enter z: 22
  * test case 6:
    > Enter x: 12
      Enter y: 56
      Enter z: 32 */

/** Equality
    Write a program that takes two integers, x and y, as input and checks if they are equal. If x is equal to y, it print "Numbers are equal."
  
    * Sample Output 1
      > Enter x: 10
        Enter y: 10
        Numbers are equal.

    * Sample Output 2
      > Enter x: 3
        Enter y: 4
  
    * Sample Output 3
      > Enter x: 8
        Enter y: 8
        Numbers are equal. */

using System;

class Program {
    static void Main() {
        int x,y;
        
        Console.Write("Enter x: ");
        x=int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        y=int.Parse(Console.ReadLine());
        
        if(x==y) {
            Console.Write("Numbers are equal.");
        }
    }
}

/** passed test cases
  * test case 1:
    > Enter x: 10
      Enter y: 10
      Numbers are equal.
  * test case 2:
    > Enter x: 3
      Enter y: 4
  * test case 3:
    > Enter x: 8
      Enter y: 8
      Numbers are equal.
  * test case 4:
    > Enter x: 7
      Enter y: 6
  * test case 5:
    > Enter x: 4
      Enter y: 4
      Numbers are equal.
  * test case 6:
    > Enter x: 1
      Enter y: -1 */

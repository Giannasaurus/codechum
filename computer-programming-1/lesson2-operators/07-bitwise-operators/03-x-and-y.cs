/** X AND Y
    Write a program that asks for two integers X and Y, and then do the AND operator with them. Print the result in the format: X AND Y = ?

    * Sample Output 1
      > Enter the first integer: 12
        Enter the second integer: 25
        12 AND 25 = 8

    * Sample Output 2
      > Enter the first integer: 33
        Enter the second integer: 14
        33 AND 14 = 0

    * Sample Output 3
      > Enter the first integer: 914
        Enter the second integer: 313
        914 AND 313 = 272 */

using System;

class Program {
    static void Main() {
        int X, Y, result;
        
        Console.Write("Enter the first integer: ");
        X=int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        Y=int.Parse(Console.ReadLine());
        
        result=X&Y;
        
        Console.Write($"{X} AND {Y} = {result}");
    }
}

/** passed test cases
  * test case 1:
    > Enter the first integer: 12
      Enter the second integer: 25
      12 AND 25 = 8
  * test case 2:
    > Enter the first integer: 33
      Enter the second integer: 14
      33 AND 14 = 0
  * test case 3:
    > Enter the first integer: 914
      Enter the second integer: 313
      914 AND 313 = 272
  * test case 4:
    > Enter the first integer: 0
      Enter the second integer: -14
      0 AND -14 = 0
  * test case 5:
    > Enter the first integer: 55
      Enter the second integer: 23
      55 AND 23 = 23
  * test case 6:
    > Enter the first integer: 23
      Enter the second integer: 62
      23 AND 62 = 22 */

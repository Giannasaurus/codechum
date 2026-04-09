/** Write a program that takes three integers, num1, num2, and num3, as input and check if all three numbers are equal. If all numbers are equal, print "All numbers are equal." Otherwise, print "Not all numbers are equal."

    * Sample Output 1
      > Enter first number: 1
        Enter second number: 2
        Enter third number: 3
        Not all numbers are equal.

    * Sample Output 2
      > Enter first number: 4
        Enter second number: 4
        Enter third number: 4
        All numbers are equal.

    * Sample Output 3
      > Enter first number: 0
        Enter second number: 0
        Enter third number: 0
        All numbers are equal. */

using System;

class Program {
    static void Main() {
        int num1, num2, num3;
        
        Console.Write("Enter first number: ");
        num1=int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        num2=int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        num3=int.Parse(Console.ReadLine());
        
    if (num1==num2||num2==num3||num3==num1) {
        Console.Write("All numbers are equal.");
    } else {
        Console.Write("Not all numbers are equal.");
    }
    }
}

/** passed test cases
  * should use: if-else statement
  * test case 1:
    > Enter first number: 1
      Enter second number: 2
      Enter third number: 3
      Not all numbers are equal.
  * test case 2:
    > Enter first number: 4
      Enter second number: 4
      Enter third number: 4
      All numbers are equal.
  * test case 3:
    > Enter first number: 0
      Enter second number: 0
      Enter third number: 0
      All numbers are equal.
  * test case 4:
    > Enter first number: -1
      Enter second number: -2
      Enter third number: -3
      Not all numbers are equal.
  * test case 5:
    > Enter first number: 3
      Enter second number: 4
      Enter third number: 5
      Not all numbers are equal.
  * test case 6:
    > Enter first number: 5
      Enter second number: 5
      Enter third number: 5
      All numbers are equal. */

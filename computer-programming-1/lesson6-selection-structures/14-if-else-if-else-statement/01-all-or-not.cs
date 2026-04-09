/** Write a program that takes three integers, num1, num2, and num3, as input and classifies them based on the following conditions:
    If all three numbers are positive, it prints "All numbers are positive."
    If all three numbers are negative, it prints "All numbers are negative."
    If all three numbers are even, it prints "All numbers are even."
    If all three numbers are odd, it prints "All numbers are odd."
    If none of the above conditions are met, it prints "Numbers are different."

    * Sample Output 1
      > Enter first number: 1
        Enter second number: 2
        Enter third number: 3
        All numbers are positive.

    * Sample Output 2
      > Enter first number: -1
        Enter second number: -2
        Enter third number: -3
        All numbers are negative.

    * Sample Output 3
      > Enter first number: -2
        Enter second number: 4
        Enter third number: -6
        All numbers are even. */

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
        
        if (num1>0&&num2>0&&num3>0) {
            Console.Write("All numbers are positive.");
        } else if (num1<0&&num2<0&&num3<0) {
            Console.Write("All numbers are negative.");
        } else if (num1%2==0&&num2%2==0&&num3%2==0) {
            Console.Write("All numbers are even.");
        } else if (num1%2!=0&&num2%2!=0&&num3%2!=0) {
            Console.Write("All numbers are odd.");
        } else {
            Console.Write("Numbers are different.");
        }
    }
}

/** passed test cases
  * should use: if-else if statement
  * test case 1:
    > Enter first number: 1
      Enter second number: 2
      Enter third number: 3
      All numbers are positive.
  * test case 2:
    > Enter first number: -1
      Enter second number: -2
      Enter third number: -3
      All numbers are negative.
  * test case 3:
    > Enter first number: -2
      Enter second number: 4
      Enter third number: -6
      All numbers are even.
  * test case 4:
    > Enter first number: -3
      Enter second number: -7
      Enter third number: 9
      All numbers are odd.
  * test case 5:
    > Enter first number: 1
      Enter second number: -4
      Enter third number: 3
      Numbers are different.
  * test case 6:
    > Enter first number: 12
      Enter second number: 51
      Enter third number: 23
      All numbers are positive. */

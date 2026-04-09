/** Write a program that takes an integer num as input and prints whether it is divisible by 4, 3, 2, or none of these. It uses the following logic:
    If num is divisible by 4, it prints "The number is divisible by 4."
    If num is not divisible by 4 but is divisible by 3, it prints "The number is divisible by 3."
    If num is not divisible by 4, not divisible by 3, but is divisible by 2, it prints "The number is divisible by 2."
    If num is not divisible by 4, not divisible by 3, and not divisible by 2, it prints "The number is not divisible by 2, 3, or 4."

    * Sample Output 1
      > Enter an integer: 12
        The number is divisible by 4.

    * Sample Output 2
      > Enter an integer: 9
        The number is divisible by 3.

    * Sample Output 3
      > Enter an integer: 5
        The number is not divisible by 2, 3, or 4. */

using System;

class Program {
    static void Main() {
        int num;
        
        Console.Write("Enter an integer: ");
        num=int.Parse(Console.ReadLine());
        
        if (num%4==0) {
            Console.Write("The number is divisible by 4.");
        } else if (num%4!=0&&num%3==0) {
            Console.Write("The number is divisible by 3.");
        } else if (num%4!=0&&num%3!=0&&num%2==0) {
            Console.Write("The number is divisible by 2.");
        } else if (num%4!=0&&num%3!=0&&num%2!=0) {
            Console.Write("The number is not divisible by 2, 3, or 4.");
        } else {
        }
    }
}

/** passed test cases
  * should use: if-else if statement
  * test case 1:
    > Enter an integer: 12
      The number is divisible by 4.
  * test case 2:
    > Enter an integer: 9
      The number is divisible by 3.
  * test case 3:
    >Enter an integer: 5
      The number is not divisible by 2, 3, or 4.
  * test case 4:
    > Enter an integer: 2
      The number is divisible by 2.
  * test case 5:
    > Enter an integer: 34
      The number is divisible by 2.
  * test case 6:
    > Enter an integer: 60
      The number is divisible by 4. */

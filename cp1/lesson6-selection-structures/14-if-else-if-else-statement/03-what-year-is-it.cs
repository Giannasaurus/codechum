/** Write a program that takes an integer year as input and prints its type based on the following rules:
    If year is a multiple of 100, it further checks if it's a multiple of 400.
    If it is, it prints "It's a leap century year." If not, it prints "It's a century year."
    If year is not a multiple of 100 but is a multiple of 4, it prints "It's a leap year."
    If year doesn't satisfy any of the above conditions, it prints "It's neither a leap year nor a century year."

    * Sample Output 1
      > Enter a year: 2020
        It's a leap year.

    * Sample Output 2
      > Enter a year: 1996
        It's a leap year.

    * Sample Output 3
      > Enter a year: 1997
        It's neither a leap year nor a century year. */

using System;

class Program {
    static void Main() {
        int year;
        
        Console.Write("Enter a year: ");
        year=int.Parse(Console.ReadLine());
        
        if (year%100==0) {
            if (year%400==0) {
                Console.Write("It's a leap century year.");
            } else {
                Console.Write("It's a century year.");
            }
        } else if (year%4==0) {
            Console.Write("It's a leap year.");
        } else {
            Console.Write("It's neither a leap year nor a century year.");
        }
    }
}

/** passed test cases
  * should use: if-else if statement
  * test case 1:
    > Enter a year: 2020
      It's a leap year.
  * test case 2:
    > Enter a year: 1996
      It's a leap year.
  * test case 3:
    > Enter a year: 1997
      It's neither a leap year nor a century year.
  * test case 4:
    > Enter a year: 2000
      It's a leap century year.
  * test case 5:
    > Enter a year: 1900
      It's a century year.
  * test case 6:
    > Enter a year: 1500
      It's a century year. */

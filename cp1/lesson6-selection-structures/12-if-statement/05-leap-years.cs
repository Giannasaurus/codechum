/** Leap Years
    Write a program that takes an integer year as input and performs the following steps to determine if the year is a leap year:

    * Checks if year is divisible by 4 (i.e., year % 4 == 0) to check if it's a multiple of 4.
    * Checks if year is not divisible by 100 (i.e., year % 100 != 0) to exclude years that are multiples of 100 but not multiples of 400.
    * Checks if year is divisible by 400 (i.e., year % 400 == 0) to include years that are multiples of 400.
      Input: An integer, year, representing a year.
    * The program should print "Year is a leap year." if condition is met. Otherwise, do nothing.

    * Sample Output 1
      > Enter the year: 2000
        Year is a leap year.

    * Sample Output 2
      > Enter the year: 2024
        Year is a leap year.

    * Sample Output 3
      > Enter the year: 1999 */

using System;

class Program {
    static void Main() {
        int year;
        
        Console.Write("Enter the year: ");
        year=int.Parse(Console.ReadLine());
        
        if((year%4==0 && year%100!=0) || year%400==0) {
            Console.Write("Year is a leap year.");
        }
    }
}

/** passed test cases
  * test case 1:
    > Enter the year: 2000
      Year is a leap year.
  * test case 2:
    > Enter the year: 2024
      Year is a leap year.
  * test case 3:
    > Enter the year: 1999
  * test case 4:
    > Enter the year: 1900
  * test case 5:
    > Enter the year: 2024
      Year is a leap year.
  * test case 6:
    > Enter the year: 1983 */

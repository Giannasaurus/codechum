/** Write a program that takes integers month and day as inputs, check if the date falls under the zodiac sign of Capricorn (December 22 - January 19). If it falls under the zodiac sign of Capricorn, print "Your zodiac sign is Capricorn."; otherwise, print "Your zodiac sign is not Capricorn."

    * Sample Output 1
      > Enter your birth month: 12
        Enter your birth day: 22
        Your zodiac sign is Capricorn.

    * Sample Output 2
      > Enter your birth month: 1
        Enter your birth day: 19
        Your zodiac sign is Capricorn.

    * Sample Output 3
      > Enter your birth month: 7
        Enter your birth day: 30
        Your zodiac sign is not Capricorn. */

using System;

class Program {
    static void Main() {
        int month, day;
        
        Console.Write("Enter your birth month: ");
        month=int.Parse(Console.ReadLine());
        Console.Write("Enter your birth day: ");
        day=int.Parse(Console.ReadLine());
        
        if((month==12&&day>=22&&day<=31)||(month==1&&day>=1&&day<=19)) {
            Console.Write("Your zodiac sign is Capricorn.");
        } else {
            Console.Write("Your zodiac sign is not Capricorn.");
        }
    }
}

/** passed test cases
  * should use: if-else statement
  * test case 1:
    > Enter your birth month: 12
      Enter your birth day: 22
      Your zodiac sign is Capricorn.
  * test case 2:
    > Enter your birth month: 1
      Enter your birth day: 19
      Your zodiac sign is Capricorn.
  * test case 3:
    > Enter your birth month: 7
      Enter your birth day: 30
      Your zodiac sign is not Capricorn.
  * test case 4:
    > Enter your birth month: 13
      Enter your birth day: 5
      Your zodiac sign is not Capricorn.
  * test case 5:
    > Enter your birth month: 2
      Enter your birth day: 30
      Your zodiac sign is not Capricorn.
  * test case 6:
    > Enter your birth month: 33
      Enter your birth day: 44
      Your zodiac sign is not Capricorn. */

/** Write a program that two integer inputs, birthYear and currentYear, and calculate the age by subtracting birthYear from currentYear.
    Then store the calculated age as an integer.
    The program should then check if the square root of the age is an integer, indicating that it's a perfect square.
    If it's a perfect square, print "Your age is a perfect square." Otherwise, print "Your age is not a perfect square."

    * Sample Output 1
      > Enter your birth year: 2000
        Enter the current year: 2025
        Your age is a perfect square.

    * Sample Output 2
      > Enter your birth year: 1997
        Enter the current year: 2023
        Your age is not a perfect square.

    * Sample Output 3
      > Enter your birth year: 2020
        Enter the current year: 2024
        Your age is a perfect square. */

using System;

class Program {
    static void Main() {
        int birthYear, currentYear, age;
        double sqrtAge;
        
        Console.Write("Enter your birth year: ");
        birthYear=int.Parse(Console.ReadLine());
        Console.Write("Enter the current year: ");
        currentYear=int.Parse(Console.ReadLine());
        
        age=currentYear-birthYear;
        sqrtAge=Math.Sqrt(age);
        
        if (sqrtAge==Math.Floor(sqrtAge)) {
            Console.Write("Your age is a perfect square.");
        } else {
            Console.Write("Your age is not a perfect square.");
        }
    }
}

/** passed test cases
  * should use: if-else statement
  * test case 1:
    > Enter your birth year: 2000
      Enter the current year: 2025
      Your age is a perfect square.
  * test case 2:
    > Enter your birth year: 1997
      Enter the current year: 2023
      Your age is not a perfect square.
  * test case 3:
    > Enter your birth year: 2020
      Enter the current year: 2024
      Your age is a perfect square.
  * test case 4:
    > Enter your birth year: 2024
      Enter the current year: 2021
      Your age is not a perfect square.
  * test case 5:
    > Enter your birth year: 2001
      Enter the current year: 2024
      Your age is not a perfect square.
  * test case 6:
    > Enter your birth year: 2020
      Enter the current year: 2024
      Your age is a perfect square. */

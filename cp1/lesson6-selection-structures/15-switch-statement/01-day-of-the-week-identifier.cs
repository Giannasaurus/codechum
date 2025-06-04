/** Write a program that takes an integer day as input.
    This program should print the name of the day of the week corresponding to the provided day using the following rules:

    If day is 1, print "Monday"
    If day is 2, print "Tuesday"
    If day is 3, print "Wednesday"
    If day is 4, print "Thursday"
    If day is 5, print "Friday"
    If day is 6, print "Saturday"
    If day is 7, print "Sunday"
    If day is not in the range of 1 to 7, print "Invalid input."

  * Sample Output 1
    > Enter a number between 1 and 7: 1
      Monday

  * Sample Output 2
    > Enter a number between 1 and 7: 2
      Tuesday

  * Sample Output 3
    > Enter a number between 1 and 7: 3
      Wednesday */

using System;

class Program {
    static void Main() {
        int day;
        
        Console.Write("Enter a number between 1 and 7: ");
        day=int.Parse(Console.ReadLine());
        
        switch (day) {
            case 1:
            Console.Write("Monday");
            break;
            case 2:
            Console.Write("Tuesday");
            break;
            case 3:
            Console.Write("Wednesday");
            break;
            case 4:
            Console.Write("Thursday");
            break;
            case 5:
            Console.Write("Friday");
            break;
            case 6:
            Console.Write("Saturday");
            break;
            case 7:
            Console.Write("Sunday");
            break;
            default:
            Console.Write("Invalid input.");
            break;
        }
    }
}

/** passed test cases
  * test case 1:
    > Enter a number between 1 and 7: 1
      Monday
  * test case 2:
    > Enter a number between 1 and 7: 2
      Tuesday
  * test case 3:
    > Enter a number between 1 and 7: 3
      Wednesday
  * test case 4:
    > Enter a number between 1 and 7: 4
      Thursday
  * test case 5:
    > Enter a number between 1 and 7: 5
      Friday
  * test case 6:
    > Enter a number between 1 and 7: 6
      Saturday
  * test case 7:
    > Enter a number between 1 and 7: 7
      Sunday
  * test case 8:
    > Enter a number between 1 and 7: 8
      Invalid input. */

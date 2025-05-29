/** Write a program that takes an integer (1-7) as input and prints the corresponding day of the week based on the following conditions:
    If the input is 1, print "Monday"
    If the input is 2, print "Tuesday"
    If the input is 3, print "Wednesday"
    If the input is 4, print "Thursday"
    If the input is 5, print "Friday"
    If the input is 6, print "Saturday"
    If the input is 7, print "Sunday"
    If the input is any other value, print "Invalid input"

  * Sample Output 1
    > Enter day: 1
      Monday

  * Sample Output 2
    > Enter day: 4
      Thursday

  * Sample Output 3
    > Enter day: 5
      Friday */

using System;

class Program {
    static void Main() {
        int dayNum;
        
        Console.Write("Enter day: ");
        dayNum=int.Parse(Console.ReadLine());
        
        if (dayNum==1) {
            Console.Write("Monday");
        } else if (dayNum==2) {
            Console.Write("Tuesday");
        } else if (dayNum==3) {
            Console.Write("Wednesday");
        } else if (dayNum==4) {
            Console.Write("Thursday");
        } else if (dayNum==5) {
            Console.Write("Friday");
        } else if (dayNum==6) {
            Console.Write("Saturday");
        } else if (dayNum==7) {
            Console.Write("Sunday");
        } else {
            Console.Write("Invalid input");
        }
    }
}

/** passed test cases
  * should use: if-else if statement
  * test case 1:
    > Enter day: 1
      Monday
  * test case 2:
    > Enter day: 4
      Thursday
  * test case 3:
    > Enter day: 5
      Friday
  * test case 4:
    > Enter day: 6
      Saturday
  * test case 5:
    > Enter day: 7
      Sunday
  * test case 6:
    > Enter day: 8
      Invalid input */

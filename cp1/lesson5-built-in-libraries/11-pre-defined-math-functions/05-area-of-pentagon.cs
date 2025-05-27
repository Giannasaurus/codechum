/** Area of a Pentagon
    Write a program that prompts the user to enter the length of the side of a regular pentagon. The program should use the predefined math functions to calculate the area of the pentagon using the entered side length. Finally, the program should print the calculated area of the pentagon in two decimal places.

    * Area of pentagon formula:
      a = 1/4 sqrt 5(5+2 sqrt 5) a^@
      Where a is the length of one side
      
    * Sample Output 1
      > Enter side: 5
        Area of Pentagon: 43.01

    * Sample Output 2
      > Enter side: 10
        Area of Pentagon: 172.05

    * Sample Output 3
      > Enter side: 3
        Area of Pentagon: 15.48 */

using System;

class Program {
    static void Main() {
        // variables
        double sideLen, pentagonArea;
        
        // ask for len of side of regular pentagon
        Console.Write("Enter side: ");
        sideLen=double.Parse(Console.ReadLine());
        
        //  calculate area of pentagon
        pentagonArea=(1.0/4.0)*Math.Sqrt(5*(5+2*Math.Sqrt(5)))*Math.Pow(sideLen,2);
        
        // result in 2 dec places
        Console.Write($"Area of Pentagon: {pentagonArea:f2}");
    }
}

/** passed test cases
  * test case 1:
    > Enter side: 5
      Area of Pentagon: 43.01
  * test case 2:
    > Enter side: 10
      Area of Pentagon: 172.05
  * test case 3:
    > Enter side: 3
      Area of Pentagon: 15.48
  * test case 4:
    > Enter side: 4
      Area of Pentagon: 27.53
  * test case 5:
    > Enter side: 12
      Area of Pentagon: 247.75
  * test case 6:
    > Enter side: 15
      Area of Pentagon: 387.11 */

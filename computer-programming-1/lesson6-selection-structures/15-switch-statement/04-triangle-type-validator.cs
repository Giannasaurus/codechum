/** Write a program that takes a character type and three float values side1, side2, and side3 as input.
    It should determine and print the type of triangle based on the values of side1, side2, and side3 and the character type. Follow these rules:

    If type is 'E' or 'e', check if all three sides are equal. If they are equal, print "The given sides form an Equilateral triangle." Otherwise, print "The given sides do not form an Equilateral triangle."
    If type is 'I' or 'i', check if at least two sides are equal. If they are, print "The given sides form an Isosceles triangle." Otherwise, print "The given sides do not form an Isosceles triangle."
    If type is 'S' or 's', check if all three sides are different. If they are, print "The given sides form a Scalene triangle." Otherwise, print "The given sides do not form a Scalene triangle."
    For any other value of type, print "Invalid triangle type identifier."

  * Sample Output 1
    > Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): E
      Enter the length of side 1: 5
      Enter the length of side 2: 5
      Enter the length of side 3: 5
      The given sides form an Equilateral triangle.

  * Sample Output 2
    > Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): E
      Enter the length of side 1: 5
      Enter the length of side 2: 4
      Enter the length of side 3: 5
      The given sides do not form an Equilateral triangle.

  * Sample Output 3
    > Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): I
      Enter the length of side 1: 5
      Enter the length of side 2: 4
      Enter the length of side 3: 5
      The given sides form an Isosceles triangle. */

using System;

class Program {
    static void Main() {
        string type;
        float side1, side2, side3;
        
        Console.Write("Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): ");
        type=Console.ReadLine();
        Console.Write("Enter the length of side 1: ");
        side1=float.Parse(Console.ReadLine());
        Console.Write("Enter the length of side 2: ");
        side2=float.Parse(Console.ReadLine());
        Console.Write("Enter the length of side 3: ");
        side3=float.Parse(Console.ReadLine());
        
        switch (type[0]) {
            case 'E':
            if (side1==side2&&side2==side3) {
                Console.Write("The given sides form an Equilateral triangle.");
            } else {
                Console.Write("The given sides do not form an Equilateral triangle.");
            }
            break;
            case 'I':
            if (side1==side2||side2==side3||side3==side1) {
                Console.Write("The given sides form an Isosceles triangle.");
            } else {
                Console.Write("The given sides do not form an Isosceles triangle.");
            }
            break;
            case 'S':
            if (side1!=side2&&side2!=side3&&side3!=side1) {
                Console.Write("The given sides form a Scalene triangle.");
            } else {
                Console.Write("The given sides do not form a Scalene triangle.");
            }
            break;
            default:
            Console.Write("Invalid triangle type identifier.");
            break;
        }
    }
}

/** passed test cases
  * test case 1:
    > Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): E
      Enter the length of side 1: 5
      Enter the length of side 2: 5
      Enter the length of side 3: 5
      The given sides form an Equilateral triangle.
  * test case 2:
    > Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): E
      Enter the length of side 1: 5
      Enter the length of side 2: 4
      Enter the length of side 3: 5
      The given sides do not form an Equilateral triangle.
  * test case 3:
    > Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): I
      Enter the length of side 1: 5
      Enter the length of side 2: 4
      Enter the length of side 3: 5
      The given sides form an Isosceles triangle.
  * test case 4:
    > Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): I
      Enter the length of side 1: 5
      Enter the length of side 2: 3
      Enter the length of side 3: 4
      The given sides do not form an Isosceles triangle.
  * test case 5:
    > Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): S
      Enter the length of side 1: 30
      Enter the length of side 2: 60
      Enter the length of side 3: 90
      The given sides form a Scalene triangle.
  * test case 6:
    > Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): S
      Enter the length of side 1: 45
      Enter the length of side 2: 45
      Enter the length of side 3: 90
      The given sides do not form a Scalene triangle. */

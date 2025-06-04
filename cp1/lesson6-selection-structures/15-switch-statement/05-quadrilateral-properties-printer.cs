/** Write a program that takes a character quadrilateralType as input and prints the properties of the corresponding quadrilateral type.
    Follow these rules:

    If quadrilateralType is 'S' or 's', print the properties of a Square:
    "Properties of a Square:"
    " - All sides are equal"
    " - All angles are 90 degrees"
    
    If quadrilateralType is 'R' or 'r', print the properties of a Rectangle:
    "Properties of a Rectangle:"
    " - Opposite sides are equal"
    " - All angles are 90 degrees"

    If quadrilateralType is 'P' or 'p', print the properties of a Parallelogram:
    "Properties of a Parallelogram:"
    " - Opposite sides are parallel"
    " - Opposite angles are equal"

    If quadrilateralType is 'T' or 't', print the properties of a Trapezoid:
    "Properties of a Trapezoid:"
    " - One pair of opposite sides are parallel"
    " - Adjacent angles are supplementary"
  
    For any other value of quadrilateralType, print "Invalid Quadrilateral type."

    * Sample Output 1
      > Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): S
        Properties of a Square:
        - All sides are equal
        - All angles are 90 degrees
  
    * Sample Output 2
      > Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): R
        Properties of a Rectangle:
       - Opposite sides are equal
       - All angles are 90 degrees
  
    * Sample Output 3
      > Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): P
        Properties of a Parallelogram:
        - Opposite sides are parallel
        - Opposite angles are equal */

using System;

class Program {
    static void Main() {
        string quadrilateralType;
        
        Console.Write("Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): ");
        quadrilateralType=Console.ReadLine();
        
        switch (quadrilateralType[0]) {
            case 'S':
            Console.Write("Properties of a Square:\n");
            Console.Write(" - All sides are equal\n");
            Console.Write(" - All angles are 90 degrees");
            break;
            case 'R':
            Console.Write("Properties of a Rectangle:\n");
            Console.Write(" - Opposite sides are equal\n");
            Console.Write(" - All angles are 90 degrees");
            break;
            case 'P':
            Console.Write("Properties of a Parallelogram:\n");
            Console.Write(" - Opposite sides are parallel\n");
            Console.Write(" - Opposite angles are equal");
            break;
            case 'T':
            Console.Write("Properties of a Trapezoid:\n");
            Console.Write(" - One pair of opposite sides are parallel\n");
            Console.Write(" - Adjacent angles are supplementary");
            break;
            default:
            Console.Write("Invalid Quadrilateral type.");
            break;
        }
    }
}

/** passed test cases
  * test case 1:
    > Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): S
      Properties of a Square:
      - All sides are equal
      - All angles are 90 degrees
  * test case 2:
    > Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): R
      Properties of a Rectangle:
      - Opposite sides are equal
      - All angles are 90 degrees
  * test case 3:
    > Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): P
      Properties of a Parallelogram:
      - Opposite sides are parallel
      - Opposite angles are equal
  * test case 4:
    > Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): T
      Properties of a Trapezoid:
      - One pair of opposite sides are parallel
      - Adjacent angles are supplementary
  * test case 5:
    > Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): x
      Invalid Quadrilateral type.
  * test case 6:
    > Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): a
      Invalid Quadrilateral type. */

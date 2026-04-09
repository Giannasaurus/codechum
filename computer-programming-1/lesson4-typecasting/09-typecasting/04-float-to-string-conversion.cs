/** Float to String Conversion
    Write a program that takes a string containing a float as parameter and converts it into a floating-point number. Finally, print the result in format "Floating-point number: {result}".

  * Sample Output 1
    > Enter a string containing a float: 3.14
      Floating-point number: 3.14

  * Sample Output 2
    > Enter a string containing a float: 0.5
      Floating-point number: 0.50
    
  * Sample Output 3
     >Enter a string containing a float: -2.75
      Floating-point number: -2.75 */

using System;

class Program {
    static void Main() {
        // variables
        string numWithString="";
        float result;
        
        // ask for string
        Console.Write("Enter a string containing a float: ");
        numWithString=Console.ReadLine();
        
        // convert string to float
        result=float.Parse(numWithString);
        
        // result 
        Console.Write($"Floating-point number: {result:f2}");
    }
}

/** passed test cases
  * test case 1:
    > Enter a string containing a float: 3.14
      Floating-point number: 3.14
  * test case 2:
    > Enter a string containing a float: 0.5
      Floating-point number: 0.50
  * test case 3:
    > Enter a string containing a float: -2.75
      Floating-point number: -2.75
  * test case 4:
    > Enter a string containing a float: 100.99
      Floating-point number: 100.99
  * test case 5:
    > Enter a string containing a float: 143.2321
      Floating-point number: 143.23
  * test case 6:
    > Enter a string containing a float: 0.23125
      Floating-point number: 0.23 */

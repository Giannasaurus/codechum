/** String Length and Sum
    Write a program that prompts the user to enter two strings and calculates the length of each string using the predefined string function. The program should then compute the sum of the lengths of the two strings and display the individual string lengths and their sum.

    * Sample Output 1
      > Enter the first string: Programming
        Enter the second string: Fun!
        Length of the first string: 11
        Length of the second string: 4
        Sum: 15

    * Sample Output 2
      > Enter the first string: code
        Enter the second string: chum
        Length of the first string: 4
        Length of the second string: 4
        Sum: 8

    * Sample Output 3
      > Enter the first string: c
        Enter the second string: plusplus
        Length of the first string: 1
        Length of the second string: 8
        Sum: 9 */

using System;

class Program {
    static void Main() {
        // variables
        string str1, str2;
        int str1Len, str2Len, sumLen;
        
        // ask for 2 str 
        Console.Write("Enter the first string: ");
        str1=Console.ReadLine();
        Console.Write("Enter the second string: ");
        str2=Console.ReadLine();
        
        // calculate len of 2 str 
        str1Len=str1.Length;
        str2Len=str2.Length;
        
        // calculate sum of len of 2 str
        sumLen=str1Len+str2Len;
        
        // display str lens and sums
        Console.Write($"Length of the first string: {str1Len}\n");
        Console.Write($"Length of the second string: {str2Len}\n");
        Console.Write($"Sum: {sumLen}");
    }
}

/** passed test cases
  * test case 1:
    > Enter the first string: Programming
      Enter the second string: Fun!
      Length of the first string: 11
      Length of the second string: 4
      Sum: 15
  * test case 2:
    > Enter the first string: code
      Enter the second string: chum
      Length of the first string: 4
      Length of the second string: 4
      Sum: 8
  * test case 3:
    > Enter the first string: c
      Enter the second string: plusplus
      Length of the first string: 1
      Length of the second string: 8
      Sum: 9
  * test case 4:
    > Enter the first string: sea
      Enter the second string: sharp
      Length of the first string: 3
      Length of the second string: 5
      Sum: 8
  * test case 5:
    > Enter the first string: hello
      Enter the second string: everyone
      Length of the first string: 5
      Length of the second string: 8
      Sum: 13
  * test case 6:
    > Enter the first string: test
      Enter the second string: test
      Length of the first string: 4
      Length of the second string: 4
      Sum: 8 */

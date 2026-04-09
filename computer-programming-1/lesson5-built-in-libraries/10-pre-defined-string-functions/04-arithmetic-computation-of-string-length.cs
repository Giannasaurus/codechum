/** Arithmetic Computation of String Length
    Write a program that prompts the user to enter three strings and performs string length calculations along with arithmetic computations. The program should calculate the length of each entered string and then compute the result as the sum of the lengths of the first two strings divided by the length of the third string.

    * Sample Output 1
      > Enter the first string: first
        Enter the second string: second
        Enter the third string: third
        Length of the first string: 5
        Length of the second string: 6
        Length of the third string: 5
        Result: 2
    
    * Sample Output 2
      > Enter the first string: programming
        Enter the second string: is
        Enter the third string: fun
        Length of the first string: 11
        Length of the second string: 2
        Length of the third string: 3
        Result: 4
    
    * Sample Output 3
      > Enter the first string: codechum
        Enter the second string: is
        Enter the third string: best
        Length of the first string: 8
        Length of the second string: 2
        Length of the third string: 4
        Result: 2 */

using System;

class Program {
    static void Main() {
        // variables
        string str1, str2, str3;
        int str1Len, str2Len, str3Len, str12sum, sum;
        
        // enter 3 str
        Console.Write("Enter the first string: ");
        str1=Console.ReadLine();
        Console.Write("Enter the second string: ");
        str2=Console.ReadLine();
        Console.Write("Enter the third string: ");
        str3=Console.ReadLine();
        
        // calculate str len 
        str1Len=str1.Length;
        str2Len=str2.Length;
        str3Len=str3.Length;
        
        // calculate first two str len / 3rd str len
        str12sum=str1Len+str2Len;
        sum=str12sum/str3Len;
        
        // display result
        Console.Write($"Length of the first string: {str1Len}\n");
        Console.Write($"Length of the second string: {str2Len}\n");
        Console.Write($"Length of the third string: {str3Len}\n");
        Console.Write($"Result: {sum}");
    }
}

/** passed test cases
  * test case 1:
    > Enter the first string: first
      Enter the second string: second
      Enter the third string: third
      Length of the first string: 5
      Length of the second string: 6
      Length of the third string: 5
      Result: 2
  * test case 2:
    > Enter the first string: programming
      Enter the second string: is
      Enter the third string: fun
      Length of the first string: 11
      Length of the second string: 2
      Length of the third string: 3
      Result: 4
  * test case 3:
    > Enter the first string: codechum
      Enter the second string: is
      Enter the third string: best
      Length of the first string: 8
      Length of the second string: 2
      Length of the third string: 4
      Result: 2
  * test case 4:
    > Enter the first string: happy
      Enter the second string: new
      Enter the third string: year
      Length of the first string: 5
      Length of the second string: 3
      Length of the third string: 4
      Result: 2
  * test case 5:
    > Enter the first string: happy
      Enter the second string: birthday
      Enter the third string: everone
      Length of the first string: 5
      Length of the second string: 8
      Length of the third string: 7
      Result: 1
  * test case 6:
    > Enter the first string: c
      Enter the second string: programming
      Enter the third string: language
      Length of the first string: 1
      Length of the second string: 11
      Length of the third string: 8
      Result: 1 */

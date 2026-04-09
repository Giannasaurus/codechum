/** Arithmetic Computation of String Length II
    Write a program that prompts the user to enter five strings and performs string length calculations along with arithmetic computations. The program should calculate the length of each entered string and then compute the result as the sum of the lengths of the first two strings divided by the difference in lengths between the third and fourth strings.

    * Sample Output 1
      > Enter the first string: first
        Enter the second string: second
        Enter the third string: third
        Enter the fourth string: fourth
        Enter the fifth string: fifth
        Length of the first string: 5
        Length of the second string: 6
        Length of the third string: 5
        Length of the fourth string: 6
        Length of the fifth string: 5
        Result: -11
    
    * Sample Output 2
      > Enter the first string: programming
        Enter the second string: fun
        Enter the third string: codechum
        Enter the fourth string: is
        Enter the fifth string: fun
        Length of the first string: 11
        Length of the second string: 3
        Length of the third string: 8
        Length of the fourth string: 2
        Length of the fifth string: 3
        Result: 2
    
    * Sample Output 3
      > Enter the first string: clanguage
        Enter the second string: cplusplus
        Enter the third string: csharp
        Enter the fourth string: java
        Enter the fifth string: python
        Length of the first string: 9
        Length of the second string: 9
        Length of the third string: 6
        Length of the fourth string: 4
        Length of the fifth string: 6
        Result: 9 */

using System;

class Program {
    static void Main() {
        // variables
        string str1, str2, str3, str4, str5;
        int str1Len, str2Len, str3Len, str4Len, str5Len;
        int str12sum, str34diff, result;
        
        // ask for 5 str 
        Console.Write("Enter the first string: ");
        str1=Console.ReadLine();
        Console.Write("Enter the second string: ");
        str2=Console.ReadLine();
        Console.Write("Enter the third string: ");
        str3=Console.ReadLine();
        Console.Write("Enter the fourth string: ");
        str4=Console.ReadLine();
        Console.Write("Enter the fifth string: ");
        str5=Console.ReadLine();
        
        // calculate str len 
        str1Len=str1.Length;
        str2Len=str2.Length;
        str3Len=str3.Length;
        str4Len=str4.Length;
        str5Len=str5.Length;
        
        // calculate sum of first 2 str len / difference of 3rd and 4th str len 
        str12sum=str1Len+str2Len;
        str34diff=str3Len-str4Len;
        result=str12sum/str34diff;
        
        // display result
        Console.Write($"Length of the first string: {str1Len}\n");
        Console.Write($"Length of the second string: {str2Len}\n");
        Console.Write($"Length of the third string: {str3Len}\n");
        Console.Write($"Length of the fourth string: {str4Len}\n");
        Console.Write($"Length of the fifth string: {str5Len}\n");
        Console.Write($"Result: {result}");
    }
}

/** passed test cases
  * test case 1:
    > Enter the first string: first
      Enter the second string: second
      Enter the third string: third
      Enter the fourth string: fourth
      Enter the fifth string: fifth
      Length of the first string: 5
      Length of the second string: 6
      Length of the third string: 5
      Length of the fourth string: 6
      Length of the fifth string: 5
      Result: -11
  * test case 2:
    > Enter the first string: programming
      Enter the second string: fun
      Enter the third string: codechum
      Enter the fourth string: is
      Enter the fifth string: fun
      Length of the first string: 11
      Length of the second string: 3
      Length of the third string: 8
      Length of the fourth string: 2
      Length of the fifth string: 3
      Result: 2
  * test case 3:
    > Enter the first string: clanguage
      Enter the second string: cplusplus
      Enter the third string: csharp
      Enter the fourth string: java
      Enter the fifth string: python
      Length of the first string: 9
      Length of the second string: 9
      Length of the third string: 6
      Length of the fourth string: 4
      Length of the fifth string: 6
      Result: 9
  * test case 4:
    > Enter the first string: everyone
      Enter the second string: should
      Enter the third string: be
      Enter the fourth string: happy
      Enter the fifth string: always
      Length of the first string: 8
      Length of the second string: 6
      Length of the third string: 2
      Length of the fourth string: 5
      Length of the fifth string: 6
      Result: -4
  * test case 5:
    > Enter the first string: adaptive
      Enter the second string: learning
      Enter the third string: is
      Enter the fourth string: good
      Enter the fifth string: very
      Length of the first string: 8
      Length of the second string: 8
      Length of the third string: 2
      Length of the fourth string: 4
      Length of the fifth string: 4
      Result: -8
  * test case 6:
    > Enter the first string: hello
      Enter the second string: world
      Enter the third string: programming
      Enter the fourth string: is
      Enter the fifth string: fun
      Length of the first string: 5
      Length of the second string: 5
      Length of the third string: 11
      Length of the fourth string: 2
      Length of the fifth string: 3
      Result: 1 */

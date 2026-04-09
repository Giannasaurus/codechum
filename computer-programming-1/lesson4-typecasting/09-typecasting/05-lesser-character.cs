/** Lesser Character
    Write a program that asks for two character inputs. Get which character is lesser and print the result in format "The lesser character is: {result}".

  * Sample Output 1
    > Enter character 1: a
      Enter character 2: b
      The lesser character is: a
    
  * Sample Output 2
    > Enter character 1: B
      Enter character 2: C
      The lesser character is: B

  * Sample Output 3
    > Enter character 1: !
      Enter character 2: @
      The lesser character is: ! */

using System;

class Program {
    static void Main() {
        // variables
        char char1, char2, result;
        
        // ask for 2 chars 
        Console.Write("Enter character 1: ");
        char1=char.Parse(Console.ReadLine());
        Console.Write("Enter character 2: ");
        char2=char.Parse(Console.ReadLine());
        
        // get lesser char
        result=char1 < char2 ? char1 : char2;
        
        // result
        Console.Write($"The lesser character is: {result}");
    }
}

/** passed test cases
  * test case 1:
    > Enter character 1: a
      Enter character 2: b
      The lesser character is: a
  * test case 2:
    > Enter character 1: B
      Enter character 2: C
      The lesser character is: B
  * test case 3:
    > Enter character 1: !
      Enter character 2: @
      The lesser character is: !
  * test case 4:
    > Enter character 1: s
      Enter character 2: X
      The lesser character is: X
  * test case 5:
    > Enter character 1: G
      Enter character 2: z
      The lesser character is: G
  * test case 6:
    > Enter character 1: L
      Enter character 2: Y
      The lesser character is: L */

/* Two Lovers
  Write a program that asks for two string inputs, lover1, and lover2. After asking for input, print in the format: "{lover1} and {lover2} are in love."
  
  > Sample Output 1
    Enter lover1: Jane
    Enter lover2: John
    Jane and John are in love.

  > Sample Output 2
    Enter lover1: Pela
    Enter lover2: Lynx
    Pela and Lynx are in love.

  > Sample Output 3
    Enter lover1: John
    Enter lover2: Doe
    John and Doe are in love. */

using System;

class Program {
    static void Main() {
        // variables
        string lover1="", lover2="";
        
        // ask for 2 strings
        Console.Write("Enter lover1: ");
        lover1=Console.ReadLine();
        Console.Write("Enter lover2: ");
        lover2=Console.ReadLine();
        
        // result
        Console.Write($"{lover1} and {lover2} are in love.");
    }
}

/** passed test cases
  * test case 1:
    Enter lover1: Jane
    Enter lover2: John
    Jane and John are in love.
  * test case 2:
    Enter lover1: Pela
    Enter lover2: Lynx
    Pela and Lynx are in love.
  * test case 3:
    Enter lover1: John
    Enter lover2: Doe
    John and Doe are in love.
  * test case 4:
    Enter lover1: Cody
    Enter lover2: Dog
    Cody and Dog are in love.
  * test case 5:
    Enter lover1: Jynx
    Enter lover2: Rest
    Jynx and Rest are in love.
  * test case 6:
    Enter lover1: Loucha
    Enter lover2: Kallen
    Loucha and Kallen are in love. */

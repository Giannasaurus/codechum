/** AND with N
    Write a program that asks for an integer N, and then do the AND operator with N and 25. Print the result in the format: N AND 25 = ?

    * Sample Output 1
      > Enter an integer: 17
        17 AND 25 = 17

    * Sample Output 2
      > Enter an integer: 101
        101 AND 25 = 1

    * Sample Output 3
      > Enter an integer: 79
        79 AND 25 = 9 */

using System;

class Program {
    static void Main() {
        int N, result;
        
        Console.Write("Enter an integer: ");
        N=int.Parse(Console.ReadLine());
        
        result=N&25;
        
        Console.Write($"{N} AND 25 = {result}");
    }
}

/** passed test cases
  * test case 1:
    > Enter an integer: 17
      17 AND 25 = 17
  * test case 2:
    > Enter an integer: 101
      101 AND 25 = 1
  * test case 3:
    > Enter an integer: 79
      79 AND 25 = 9
  * test case 4:
    > Enter an integer: 446
      446 AND 25 = 24
  * test case 5:
    > Enter an integer: 55
      55 AND 25 = 17
  * test case 6:
    > Enter an integer: 78
    78 AND 25 = 8 */

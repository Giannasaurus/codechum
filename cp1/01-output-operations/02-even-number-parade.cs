/** Even Number Parade
  Write a program that prints the first 5 even numbers, beginning from 2, with each number occupying its own line.
  
  * Sample Output 1
  > 2
    4
    6
    8
    10 */

using System;

class MainClass {
    static public void Main()
    {
     // declare variable
     int num;
     
     // num loops over 5 times
     // and multiplies by 2 each time
     for(num=1;num<6;num++) {
        Console.WriteLine(num*2);
     }
    }
}

/** passed test cases
  * test case 1:
    > 2
      4
      6
      8
      10 */

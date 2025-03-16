/** Let's Test Addition with Equal
    Write a program that asks for an integer number, adds 1, and assigns to the number using the += operator.
  
    * Sample Output 1
      > Enter an integer number: 1
        The updated number is: 2
    
    * Sample Output 2
      > Enter an integer number: 2
       The updated number is: 3
    
    * Sample Output 3
      > Enter an integer number: 3
        The updated number is: 4 */

using System;

class Program {
    static void Main() {
        // variables
        int num;
        
        // ask for input
        Console.Write("Enter an integer number: ");
        num=int.Parse(Console.ReadLine());
        
        // add 1 to num
        num+=1;
        
        // display updated number
        Console.Write("The updated number is: {0}", num);
    }
}

/** passed test cases
  * test case 1:
    > Enter an integer number: 1
      The updated number is: 2
  * test case 2:
    > Enter an integer number: 2
      The updated number is: 3
  * test case 3:
    > Enter an integer number: 3
      The updated number is: 4
  * test case 4:
    > Enter an integer number: 4
      The updated number is: 5
  * test case 5:
    > Enter an integer number: 5
      The updated number is: 6
  * test case 6:
    > Enter an integer number: -1
      The updated number is: 0 */

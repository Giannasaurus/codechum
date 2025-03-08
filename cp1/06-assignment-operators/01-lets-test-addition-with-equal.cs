/* Let's Test Addition with Equal
  Write a program that asks for an integer number, adds 1, and assigns to the number using the += operator.
  
  Sample Output 1
  > Enter an integer number: 1
    The updated number is: 2
    
  Sample Output 2
  > Enter an integer number: 2
    The updated number is: 3
    
  Sample Output 3
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

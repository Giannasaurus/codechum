/* Swapping Bitwise
  Write a program that asks for two integers, x, and y. Swap the two numbers using bitwise operators.

  Sample Output 1
  > Enter the first number: 10
    Enter the second number: 25
    Before swap: num1 = 10, num2 = 25
    After swap: num1 = 25, num2 = 10

  Sample Output 2
  > Enter the first number: 34
    Enter the second number: 33
    Before swap: num1 = 34, num2 = 33
    After swap: num1 = 33, num2 = 34

  Sample Output 3
  > Enter the first number: 1
    Enter the second number: 0
    Before swap: num1 = 1, num2 = 0
    After swap: num1 = 0, num2 = 1 */

using System;

class Program {
    static void Main() {
        int X, Y, swap;
        
        Console.Write("Enter the first number: ");
        X=int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        Y=int.Parse(Console.ReadLine());
       
        Console.Write($"Before swap: num1 = {X}, num2 = {Y}\n");
        
        X=X^Y;
        Y=X^Y;
        X=X^Y;
        
        Console.Write($"After swap: num1 = {X}, num2 = {Y}");
    }
}

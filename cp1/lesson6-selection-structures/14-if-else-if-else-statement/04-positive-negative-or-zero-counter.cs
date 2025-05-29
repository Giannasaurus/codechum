/** Write a program that takes five integers as input and counts the number of positive, negative, and zero values among them. Print their respective counts afterwards.

    * Sample Output 1
      > Enter first integer: 1
        Enter second integer: 3
        Enter third integer: -1
        Enter fourth integer: 0
        Enter fifth integer: 4
        Positive count: 3
        Negative count: 1
        Zero count: 1

    * Sample Output 2
      > Enter first integer: -4
        Enter second integer: -3
        Enter third integer: 2
        Enter fourth integer: 4
        Enter fifth integer: 0
        Positive count: 2
        Negative count: 2
        Zero count: 1

    * Sample Output 3
      > Enter first integer: 3
        Enter second integer: 4
        Enter third integer: 5
        Enter fourth integer: -7
        Enter fifth integer: 4
        Positive count: 4
        Negative count: 1
        Zero count: 0 */

using System;

class Program {
    static void Main() {
        int num1, num2, num3, num4, num5;
        int positiveCount=0, negativeCount=0, zeroCount=0;
        
        Console.Write("Enter first integer: ");
        num1=int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        num2=int.Parse(Console.ReadLine());
        Console.Write("Enter third integer: ");
        num3=int.Parse(Console.ReadLine());
        Console.Write("Enter fourth integer: ");
        num4=int.Parse(Console.ReadLine());
        Console.Write("Enter fifth integer: ");
        num5=int.Parse(Console.ReadLine());
        
        if (num1>0) {
            positiveCount++;
        } else if (num1<0) {
            negativeCount++;
        } else {
            zeroCount++;
        }
        
        if (num2>0) {
            positiveCount++;
        } else if (num2<0) {
            negativeCount++;
        } else {
            zeroCount++;
        }
        
        if (num3>0) {
            positiveCount++;
        } else if (num3<0) {
            negativeCount++;
        } else {
            zeroCount++;
        }
        
        if (num4>0) {
            positiveCount++;
        } else if (num4<0) {
            negativeCount++;
        } else {
            zeroCount++;
        }
        
        if (num5>0) {
            positiveCount++;
        } else if (num5<0) {
            negativeCount++;
        } else {
            zeroCount++;
        }
        
        Console.Write($"Positive count: {positiveCount}\n");
        Console.Write($"Negative count: {negativeCount}\n");
        Console.Write($"Zero count: {zeroCount}");
    }
}

/** passed test cases
  * should use: if-else if statement
  * test case 1:
    > Enter first integer: 1
      Enter second integer: 3
      Enter third integer: -1
      Enter fourth integer: 0
      Enter fifth integer: 4
      Positive count: 3
      Negative count: 1
      Zero count: 1
  * test case 2:
    > Enter first integer: -4
      Enter second integer: -3
      Enter third integer: 2
      Enter fourth integer: 4
      Enter fifth integer: 0
      Positive count: 2
      Negative count: 2
      Zero count: 1
  * test case 3:
    > Enter first integer: 3
      Enter second integer: 4
      Enter third integer: 5
      Enter fourth integer: -7
      Enter fifth integer: 4
      Positive count: 4
      Negative count: 1
      Zero count: 0
  * test case 4:
    > Enter first integer: 0
      Enter second integer: 4
      Enter third integer: 2
      Enter fourth integer: 0
      Enter fifth integer: -1
      Positive count: 2
      Negative count: 1
      Zero count: 2
  * test case 5:
    > Enter first integer: 2042
      Enter second integer: 1000
      Enter third integer: 2502
      Enter fourth integer: 12305
      Enter fifth integer: 23300
      Positive count: 5
      Negative count: 0
      Zero count: 0
  * test case 6:
    > Enter first integer: -2
      Enter second integer: 2000
      Enter third integer: 05
      Enter fourth integer: -2
      Enter fifth integer: 0
      Positive count: 2
      Negative count: 2
      Zero count: 1 */

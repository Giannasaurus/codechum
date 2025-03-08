/* X Right Shift Y
  Write a program that asks for two integers X and Y, and then right-shift X by Y. Print the result in the format: X >> Y = ?

  Sample Output 1
  > Enter X: 25
    Enter Y: 46
    25 >> 46 = 0

  Sample Output 2
  > Enter X: 25
    Enter Y: 1
    25 >> 1 = 12

  Sample Output 3
  > Enter X: 1024
    Enter Y: 3
    1024 >> 3 = 128 */

using System;

class Program {
    static void Main() {
        int X, Y, result;
        
        Console.Write("Enter X: ");
        X=int.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        Y=int.Parse(Console.ReadLine());
        
        result=X>>Y;
        
        Console.Write($"{X} >> {Y} = {result}");
    }
}

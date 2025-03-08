/* An Increase
  Ask for a float number price then multiply the value of price by 1.1 to add a 10% increase using the *= operator. Print the final value in two decimal places.

  Sample Output 1
  > Enter the price: 10
    The new price is: 11.00

  Sample Output 2
  > Enter the price: 100
    The new price is: 110.00

  Sample Output 3
  > Enter the price: -5
    The new price is: -5.50 */

using System;

class Program {
    static void Main() {
        // variables
        float price;
        
        // ask for price
        Console.Write("Enter the price: ");
        price=float.Parse(Console.ReadLine());
        
        // multiply price by 1.1
        price*=1.1f;
        
        // display new price
        Console.Write("The new price is: {0:f2}", price);
    }
}

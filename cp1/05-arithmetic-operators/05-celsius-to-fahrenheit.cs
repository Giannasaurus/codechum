/* Celsius to Fahrenheit Converter
  Write a program that takes in a float Celsius, and displays its equivalent value in Fahrenheit in two decimal places. The formula is as follows: °F = °C × (9/5) + 32.

  Sample Output 1
  > Enter temperature in Celsius: 27
    Temperature in Fahrenheit: 80.60

  Sample Output 2
  > Enter temperature in Celsius: 37.5
    Temperature in Fahrenheit: 99.50

  Sample Output 3
  > Enter temperature in Celsius: 44.55
    Temperature in Fahrenheit: 112.19 */

using System;

class MainClass {
    static public void Main()
    {
        // variables
        float celsius, fahrenheit;
        
        // ask for temp in celcius
        Console.Write("Enter temperature in Celsius: ");
        celsius=float.Parse(Console.ReadLine());
        
        // calculate fahrenheit
        fahrenheit=celsius*(9f/5f)+32f;
        
        // display temp in fahrenheit
        Console.Write("Temperature in Fahrenheit: {0:f2}", fahrenheit);
    }
}

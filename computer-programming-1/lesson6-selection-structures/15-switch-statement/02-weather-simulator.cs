/** Write a program that takes a character array weather as input and prints a weather suggestion based on the first character of the weather condition.
    Follow these rules:

    If the weather is "Sunny" and the first character of weather is 'S', print "Suggestion: Enjoy the sunshine"
    If the weather is "Cloudy" and the first character of weather is 'C', print "Suggestion: Stay indoors"
    If the weather is "Rainy" and the first character of weather is 'R', print "Suggestion: Bring an umbrella"
    If the weather is "Windy" and first character of weather is 'W', print "Suggestion: Fly a kite"
    For any other value of the first character, print "Invalid weather condition."
 
    To access the first character of a string, use char firstLetter = weather[0].

  * Sample Output 1
    > Enter the weather condition: Sunny
      Suggestion: Enjoy the sunshine

  * Sample Output 2
    > Enter the weather condition: Cloudy
      Suggestion: Stay indoors

  * Sample Output 3
    > Enter the weather condition: Rainy
      Suggestion: Bring an umbrella */

using System;

class Program {
    static void Main() {
        string weather;
        
        Console.Write("Enter the weather condition: ");
        weather=Console.ReadLine();
        
        char firstLetter=weather[0];
        
        switch (firstLetter) {
            case 'S':
            Console.Write("Suggestion: Enjoy the sunshine");
            break;
            case 'C':
            Console.Write("Suggestion: Stay indoors");
            break;
            case 'R':
            Console.Write("Suggestion: Bring an umbrella");
            break;
            case 'W':
            Console.Write("Suggestion: Fly a kite");
            break;
            default: 
            Console.Write("Invalid weather condition.");
            break;
        }
    }
}

/** passed test cases
  * test case 1:
    > Enter the weather condition: Sunny
      Suggestion: Enjoy the sunshine
  * test case 2:
    > Enter the weather condition: Cloudy
      Suggestion: Stay indoors
  * test case 3:
    > Enter the weather condition: Rainy
      Suggestion: Bring an umbrella
  * test case 4:
    > Enter the weather condition: Rainy
      Suggestion: Bring an umbrella
  * test case 5:
    > Enter the weather condition: X
      Invalid weather condition.
  * test case 6:
    > Enter the weather condition: z
      Invalid weather condition. */

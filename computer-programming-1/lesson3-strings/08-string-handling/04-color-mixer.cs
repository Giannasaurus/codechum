/** Color Mixer
    Write a program that takes three color names as inputs and prints a message like: "Mixing {color1}, {color2}, and {color3} creates a new color!"
  
  * Sample Output 1
    > Enter color 1: red
      Enter color 2: blue
      Enter color 3: green
      Mixing red, blue, and green creates a new color!

  * Sample Output 2
    > Enter color 1: yellow
      Enter color 2: orange
      Enter color 3: purple
      Mixing yellow, orange, and purple creates a new color!

  * Sample Output 3
    > Enter color 1: black
      Enter color 2: white
      Enter color 3: gray
      Mixing black, white, and gray creates a new color! */

using System;

class Program {
    static void Main() {
        // variables
        string color1="", color2="", color3="";
        
        // ask for colors
        Console.Write("Enter color 1: ");
        color1=Console.ReadLine();
        Console.Write("Enter color 2: ");
        color2=Console.ReadLine();
        Console.Write("Enter color 3: ");
        color3=Console.ReadLine();
        
        // display message
        Console.Write($"Mixing {color1}, {color2}, and {color3} creates a new color!");
    }
}

/** passed test cases
  * test case 1:
    > Enter color 1: red
      Enter color 2: blue
      Enter color 3: green
      Mixing red, blue, and green creates a new color!
  * test case 2:
    > Enter color 1: yellow
      Enter color 2: orange
      Enter color 3: purple
      Mixing yellow, orange, and purple creates a new color!
  * test case 3:
    > Enter color 1: black
      Enter color 2: white
      Enter color 3: gray
      Mixing black, white, and gray creates a new color!
  * test case 4:
    > Enter color 1: pink
      Enter color 2: brown
      Enter color 3: beige
      Mixing pink, brown, and beige creates a new color!
  * test case 5:
    > Enter color 1: red
      Enter color 2: blue
      Enter color 3: white
      Mixing red, blue, and white creates a new color!
  * test case 6:
    > Enter color 1: brown
      Enter color 2: black
      Enter color 3: blue
      Mixing brown, black, and blue creates a new color! */

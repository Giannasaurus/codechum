/** Rainbow Arch
    Write a program that brings the vibrant beauty of a rainbow to life by gracefully printing a colorful arch of hues. Copy the number of spaces before each color to mimic the arch of the rainbow as depicted below:

                Green
          Yellow     Brown
      Orange             Indigo
    Red                      Violet

    * Sample Output 1
      >
                Green
          Yellow     Brown
      Orange             Indigo
    Red                      Violet */

using System;

class MainClass {
    static public void Main() {
        Console.WriteLine("            Green");
        Console.WriteLine("      Yellow" + "     Brown");
        Console.WriteLine("  Orange" + "             Indigo");
        Console.WriteLine("Red" + "                      Violet");
    }
}

/** passed test cases
  * test case 1:
    >           Green
          Yellow     Brown
      Orange             Indigo
    Red                      Violet */

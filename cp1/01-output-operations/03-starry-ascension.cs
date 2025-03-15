/** Starry Ascension

    Write a program that generates a pattern of stars, ascending in quantity, as depicted below:
    *
    **
    ***
    ****
    *****

    * Sample Output 1
      > *
        **
        ***
        ****
        ***** */

using System;

class MainClass {
    static public void Main()
    {
        for(int i=1;i<6;i++) {
            for(int j=0;j<i;j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

/** passed test case
  * test case 1:
    > *
      **
      ***
      ****
      ***** */

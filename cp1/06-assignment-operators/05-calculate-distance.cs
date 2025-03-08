/* Calculate Distance
  Write a program that asks for a float input kmph that stands for kilometers per hour. Also, ask for an integer input hour which is the number of hours traveled. Get the distance in km by multiplying kmph by hour then assigning it to a variable distance. Convert the distance into miles by applying the appropriate operation. In this problem, 1 kilometer is equal to 0.621371 miles. Print the distance in miles in three decimal places.

  Sample Output 1
  > Enter kilometers per hour: 60
    Enter number of hours traveled: 5
    Distance in miles: 186.411

  Sample Output 2
  > Enter kilometers per hour: 20
    Enter number of hours traveled: 7
    Distance in miles: 86.992

  Sample Output 3
  > Enter kilometers per hour: 37.77
    Enter number of hours traveled: 5
    Distance in miles: 117.346 */

using System;

class MainClass {
    static public void Main()
    {
        // variables
        float kmph, distance;
        int hour;
        double mph;
        
        // ask for input
        Console.Write("Enter kilometers per hour: ");
        kmph=float.Parse(Console.ReadLine());
        Console.Write("Enter number of hours traveled: ");
        hour=int.Parse(Console.ReadLine());
        
        // calculate distance
        distance=kmph*hour;
        mph=distance*0.621371f;
        
        // display distance in miles
        Console.Write("Distance in miles: {0:f3}", mph);
    }
}

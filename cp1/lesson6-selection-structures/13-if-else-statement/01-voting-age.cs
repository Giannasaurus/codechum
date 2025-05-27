/** Write a program that are related to checking and displaying eligibility to vote based on age.

    * Eligibility to Vote:
      > The program takes an integer age as input and checks if the person is eligible to vote.
        It checks if age is greater than or equal to 18.
        If the condition is met, the function, it indicates that the person is eligible to vote.
        If the condition is not met, it indicates that the person is not eligible to vote.
    
   * Printing Eligibility Message:
      > If the person is eligible to vote, print "You are eligible to vote."
        If the person is not eligible to vote, print "You are not eligible to vote."
    
    * Sample Output 1
      > Enter your age: 15
        You are not eligible to vote.
    
    * Sample Output 2
      > Enter your age: 18
        You are eligible to vote.

    * Sample Output 3
      > Enter your age: 25
        You are eligible to vote. */

using System;

class Program {
    static void Main() {
        int age;
        
        Console.Write("Enter your age: ");
        age=int.Parse(Console.ReadLine());
        
        if (age>=18) {
            Console.Write("You are eligible to vote.");
        } else {
            Console.Write("You are not eligible to vote.");
        }
    }
}

/** passed test cases:
    * minimum requirement:
      > should use: if-else statement
    * test case 1:
      > Enter your age: 15
        You are not eligible to vote.
    * test case 2:
      > Enter your age: 18
        You are eligible to vote.
    * test case 3:
      > Enter your age: 25
        You are eligible to vote.
    * test case 4:
      > Enter your age: 30
        You are eligible to vote.
    * test case 5:
      > Enter your age: 12
        You are not eligible to vote.
    * test case 6:
      > Enter your age: 54
        You are eligible to vote. */

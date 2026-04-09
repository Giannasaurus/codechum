/** Write a program that simulates a game difficulty selection. It accepts a string input ('Easy', 'Medium', 'Hard') representing the difficulty level.
    Use a switch statement to print the corresponding message or challenge description.
    Print the following challenge description:

    Easy - "Message: You selected Easy difficulty. Enjoy the game!"
    Medium - "Message: You selected Medium difficulty. Get ready for a challenge!"
    Hard - "Message: You selected Hard difficulty. Brace yourself for a tough gameplay!"

  * Sample Output 1
    > Enter the difficulty level (Easy, Medium, Hard): Easy
      Message: You selected Easy difficulty. Enjoy the game!

  * Sample Output 2
    > Enter the difficulty level (Easy, Medium, Hard): Medium
      Message: You selected Medium difficulty. Get ready for a challenge!

  * Sample Output 3
    > Enter the difficulty level (Easy, Medium, Hard): Hard
      Message: You selected Hard difficulty. Brace yourself for a tough gameplay! */

using System;

class Program {
    static void Main() {
        string level;
        
        Console.Write("Enter the difficulty level (Easy, Medium, Hard): ");
        level=Console.ReadLine();
        
        switch (level) {
            case "Easy":
            Console.Write("Message: You selected Easy difficulty. Enjoy the game!");
            break;
            case "Medium":
            Console.Write("Message: You selected Medium difficulty. Get ready for a challenge!");
            break;
            case "Hard":
            Console.Write("Message: You selected Hard difficulty. Brace yourself for a tough gameplay!");
            break;
            default:
            Console.Write("Invalid difficulty level.");
            break;
        }
    }
}

/** passed test cases
  * test case 1:
    > Enter the difficulty level (Easy, Medium, Hard): Easy
      Message: You selected Easy difficulty. Enjoy the game!
  * test case 2:
    > Enter the difficulty level (Easy, Medium, Hard): Medium
      Message: You selected Medium difficulty. Get ready for a challenge!
  * test case 3:
    > Enter the difficulty level (Easy, Medium, Hard): Hard
      Message: You selected Hard difficulty. Brace yourself for a tough gameplay!
  * test case 4:
    > Enter the difficulty level (Easy, Medium, Hard): Xard
      Invalid difficulty level.
  * test case 5:
    > Enter the difficulty level (Easy, Medium, Hard): Very Hard
      Invalid difficulty level.
  * test case 6:
    > Enter the difficulty level (Easy, Medium, Hard): Beginner
      Invalid difficulty level. */

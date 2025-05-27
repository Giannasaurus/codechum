/** Special Characters
    Write a program that takes a character, character, as input and checks if it is a special character. If the character is neither an alphabet letter nor a digit, it prints "Character is a special character." Otherwise, it does nothing.

    * Sample Output 1
      > Enter character: !
        Character is a special character.

    * Sample Output 2
      > Enter character: a

    * Sample Output 3
      > Enter character: /
        Character is a special character. */

using System;

class Program {
    static void Main() {
        char character;
        
        Console.Write("Enter character: ");
        character=char.Parse(Console.ReadLine());
        
        if (!char.IsLetterOrDigit(character)) {
            Console.Write("Character is a special character.");
        } else {
        }
    }
}

/** passed test cases
  * should use: if statement
  * test case 1:
    > Enter character: !
      Character is a special character.
  * test case 2:
    > Enter character: a
  * test case 3:
    > Enter character: /
      Character is a special character.
  * test case 4:
    > Enter character: ~
      Character is a special character.
  * test case 5:
    > Enter character: 1
  * test case 6:
    > Enter character: .
      Character is a special character. */

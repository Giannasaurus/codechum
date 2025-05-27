/** Write a program that takes a character character as input and checks whether the character is a vowel or consonant.
    If the character is one of the vowels ('a', 'e', 'i', 'o', 'u' or their uppercase variants), print "The character is a vowel.";
    otherwise, print "The character is a consonant."
    
    * Sample Output 1
      > Enter a character: a
        The character is a vowel.

    * Sample Output 2
      > Enter a character: b
        The character is a consonant.

    * Sample Output 3
      > Enter a character: A
        The character is a vowel. */

using System;

class Program {
    static void Main() {
        char character;
        
        Console.Write("Enter a character: ");
        character=char.Parse(Console.ReadLine());
        
        if (character=='a'||character=='e'||character=='i'||character=='o'||character=='u'||character=='A'||character=='E'||character=='I'||character=='O'||character=='U') {
            Console.Write("The character is a vowel.");
        } else {
            Console.Write("The character is a consonant.");
        } 
    }
}

/** passed test cases:
    * minimum requirement
      > should use: if-else statement
    * test case 1:
      > Enter a character: a
        The character is a vowel.
    * test case 2:
      > Enter a character: b
        The character is a consonant.
    * test case 3:
      > Enter a character: A
        The character is a vowel.
    * test case 4:
      > Enter a character: B
        The character is a consonant.
    * test case 5:
      > Enter a character: e
        The character is a vowel.
    * test case 6:
      > Enter a character: U
        The character is a vowel. */

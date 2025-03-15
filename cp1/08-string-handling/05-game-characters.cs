/* Game Characters
  Create a program that asks for four character names. Print a message like: "My most played characters in the game are {character1}, {character2}, {character3}, and {character4}."

  > Sample Output 1
    Enter the name of your first character: Mario
    Enter the name of your second character: Luigi
    Enter the name of your third character: Princess Peach
    Enter the name of your fourth character: Toad
    My most played characters in the game are Mario, Luigi, Princess Peach, and Toad.

  > Sample Output 2
    Enter the name of your first character: Link
    Enter the name of your second character: Zelda
    Enter the name of your third character: Ganondorf
    Enter the name of your fourth character: Impa
    My most played characters in the game are Link, Zelda, Ganondorf, and Impa.

  > Sample Output 3
    Enter the name of your first character: Ryu
    Enter the name of your second character: Chun-li
    Enter the name of your third character: Guile
    Enter the name of your fourth character: Dhalsim
    My most played characters in the game are Ryu, Chun-li, Guile, and Dhalsim. */

using System;

class Program {
    static void Main() {
        // variables
        string character1="", character2="", character3="", character4="";
        
        // ask for 4 characters
        Console.Write("Enter the name of your first character: ");
        character1=Console.ReadLine();
        Console.Write("Enter the name of your second character: ");
        character2=Console.ReadLine();
        Console.Write("Enter the name of your third character: ");
        character3=Console.ReadLine();
        Console.Write("Enter the name of your fourth character: ");
        character4=Console.ReadLine();
        
        // result
        Console.Write($"My most played characters in the game are {character1}, {character2}, {character3}, and {character4}.");
    }
}

/** passed test cases
  * test case 1:
    Enter the name of your first character: Mario
    Enter the name of your second character: Luigi
    Enter the name of your third character: Princess Peach
    Enter the name of your fourth character: Toad
    My most played characters in the game are Mario, Luigi, Princess Peach, and Toad.
  * test case 2:
    Enter the name of your first character: Link
    Enter the name of your second character: Zelda
    Enter the name of your third character: Ganondorf
    Enter the name of your fourth character: Impa
    My most played characters in the game are Link, Zelda, Ganondorf, and Impa.
  * test case 3:
    Enter the name of your first character: Ryu
    Enter the name of your second character: Chun-li
    Enter the name of your third character: Guile
    Enter the name of your fourth character: Dhalsim
    My most played characters in the game are Ryu, Chun-li, Guile, and Dhalsim.
  * test case 4:
    Enter the name of your first character: Geralt
    Enter the name of your second character: Ciri
    Enter the name of your third character: Yennefer
    Enter the name of your fourth character: Triss
    My most played characters in the game are Geralt, Ciri, Yennefer, and Triss.
  * test case 5:
    Enter the name of your first character: Master Chief
    Enter the name of your second character: Cortana
    Enter the name of your third character: Arbiter
    Enter the name of your fourth character: Johnson
    My most played characters in the game are Master Chief, Cortana, Arbiter, and Johnson.
  * test case 6:
    Enter the name of your first character: Loucha
    Enter the name of your second character: Bronya
    Enter the name of your third character: Seele
    Enter the name of your fourth character: Silver Wolf
    My most played characters in the game are Loucha, Bronya, Seele, and Silver Wolf. */

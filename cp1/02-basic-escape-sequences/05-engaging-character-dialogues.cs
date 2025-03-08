/* Engaging Character Dialogues
  Write a program that showcases dynamic dialogues between multiple characters, using escape sequences to accurately represent their conversations. Print out the dialogues with proper formatting, including appropriate spacing, quotation marks, and the correct usage of escape sequences for special characters. The following text is the dialogue to be printed:
  
  Character A:    "Hello there!"
  Character B:    'Hi! How are you?'
  Character A:    'I'm doing great.' Thanks for asking!
  Character C:    "Hey, what's going on?"
  Character B:    "We were just catching up."
  Character A:    "Yeah, it's been a while."
  Character C:    "Nice to see you both!"
  Character B:    "Likewise! How have you been?"
  Character C:    "I've been good. Thanks!"
  Character A:    "That's great to hear."

  Sample Output 1
    > Character A:	"Hello there!"
      Character B:	'Hi! How are you?'
      Character A:	'I'm doing great.' Thanks for asking!
      Character C:	"Hey, what's going on?"
      Character B:	"We were just catching up."
      Character A:	"Yeah, it's been a while."
      Character C:	"Nice to see you both!"
      Character B:	"Likewise! How have you been?"
      Character C:	"I've been good. Thanks!"
      Character A:	"That's great to hear." */

using System;

namespace Program {
    class main {
        static void Main(string[] args) {
            Console.WriteLine("Character A:\t\"Hello there!\"\nCharacter B:\t\'Hi! How are you?\'\nCharacter A:\t\'I'm doing great.\' Thanks for asking!\nCharacter C:\t\"Hey, what's going on?\"\nCharacter B:\t\"We were just catching up.\"\nCharacter A:\t\"Yeah, it's been a while.\"\nCharacter C:\t\"Nice to see you both!\"\nCharacter B:\t\"Likewise! How have you been?\"\nCharacter C:\t\"I've been good. Thanks!\"\nCharacter A:\t\"That's great to hear.\"");
        }
    }
}

"""
Pretty Printing

Print the text "I am a programmer" multiple times in exactly the following format:
\ ' I am a programmer `" //
  \ ' I am a programmer "` //
    \ ' I am a programmer `" //
      \ ' I am a programmer "` // 
      
Note that the number of spaces before each line increases by 2 (i.e. the first line has 0 spaces, the second line has 2 spaces, the third line has 4 spaces, and the fourth line has 6 spaces)

Sample output
> 
\\ ' I am a programmer " //
  \\ ' I am a programmer " //
    \\ ' I am a programmer " //
      \\ ' I am a programmer " //
"""

def printText(text):
    for x in range(4):
        spaces = " " * (x * 2)
        print(f"{spaces}\\\\ \' {text} \" //")
    
printText("I am a programmer")

"""
Passed test cases

Test case 1
>
\\ ' I am a programmer " //
  \\ ' I am a programmer " //
    \\ ' I am a programmer " //
      \\ ' I am a programmer " //
"""
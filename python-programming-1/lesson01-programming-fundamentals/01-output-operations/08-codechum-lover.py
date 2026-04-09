"""
CodeChum Lover

Make a program that will print "CodeChum is Love" in this format:
CodeChum is Love
  CodeChum is Love
    CodeChum is Love
    
Sample output 1
>
CodeChum is Love
  CodeChum is Love
    CodeChum is Love
"""

def printWithTab(text):
    for x in range(3):
        print("  " * x + text)
    
printWithTab("CodeChum is Love")

"""
Passed test cases

Test case 1
>
CodeChum is Love
  CodeChum is Love
    CodeChum is Love
"""
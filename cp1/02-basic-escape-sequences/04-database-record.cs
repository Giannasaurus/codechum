/* Database Record
  Create a program that prints the following text:
  Database Record
  \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
  Name:        John Doe
  Email:        john.doe@example.com
  University:    ABC University
  Sample Output 1
    > Database Record
      \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
      Name:		John Doe
      Email:		john.doe@example.com
      University:	ABC University */

using System; 

namespace Program {
    class main {
        static void Main(string[] args) {
            Console.WriteLine("Database Record\n\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\nName:\t\tJohn Doe\nEmail:\t\tjohn.doe@example.com\nUniversity:\tABC University");
        }
    }
}

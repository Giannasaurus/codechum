/** Book Reservation Details
    Create a program that displays the reservation details for a book titled "The Great Gatsby" by F. Scott Fitzgerald. The program should utilize appropriate placeholders for each detail. Output should look like:

    You have successfully reserved the book 'The Great Gatsby' by F. Scott Fitzgerald.
    Year of Publication: 1925
    Genre: Fiction
    Library: Central Library
    Member ID: 12345
    Return Date: June 30, 2023

    * Sample Output 1
      > You have successfully reserved the book 'The Great Gatsby' by F. Scott Fitzgerald.
        Year of Publication: 1925
        Genre: Fiction
        Library: Central Library
        Member ID: 12345
        Return Date: June 30, 2023 */

using System;

namespace Program {
    class main {
        static void Main(string[] args) {
            string bookTitle="The Great Gatsby", bookAuthor="F. Scott Fitzgerald", bookGenre="Fiction", libLocation="Central Library", returnMonth="June";
            double publicationYear=1925, memberId=12345, returnDay=30, returnYear=2023;
            
            Console.WriteLine("You have successfully reserved the book \'{0}\' by {1}.\nYear of Publication: {2}\nGenre: {3}\nLibrary: {4}\nMember ID: {5}\nReturn Date: {6} {7}, {8}", bookTitle, bookAuthor, publicationYear, bookGenre, libLocation, memberId, returnMonth, returnDay, returnYear);
        }
    }
}

/** passed test cases
  * test case 1:
    > You have successfully reserved the book 'The Great Gatsby' by F. Scott Fitzgerald.
      Year of Publication: 1925
      Genre: Fiction
      Library: Central Library
      Member ID: 12345
      Return Date: June 30, 2023 */

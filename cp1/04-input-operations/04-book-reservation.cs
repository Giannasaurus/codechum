/* Book Reservation
  Write a program that asks the user to enter the title of a book (string), the author (string), the year of publication (int), the genre (string), the library (string), the member ID (string) and the return date (string). Print the entered values directly. The output should look like:

  You have successfully reserved the book [Title] by [Author].
  Year of Publication: [Year]
  Genre: [Genre]
  Library: [Library]
  Member ID: [MemberID]
  Return Date: [ReturnDate]

  Sample Output 1
  > Enter the book title: 1984
    Enter the author: Orwell
    Enter the year of publication: 1949
    Enter the genre: Dystopian
    Enter the library: Central
    Enter your member ID: 12345
    Enter the return date: 2023-07-10
    You have successfully reserved the book '1984' by Orwell.
    Year of Publication: 1949
    Genre: Dystopian
    Library: Central
    Member ID: 12345
    Return Date: 2023-07-10
    
  Sample Output 2
  > Enter the book title: Mockingbird
    Enter the author: Lee
    Enter the year of publication: 1960
    Enter the genre: Fiction
    Enter the library: Westside
    Enter your member ID: 67890
    Enter the return date: 2023-06-28
    You have successfully reserved the book 'Mockingbird' by Lee.
    Year of Publication: 1960
    Genre: Fiction
    Library: Westside
    Member ID: 67890
    Return Date: 2023-06-28

  Sample Output 3
  > Enter the book title: Catcher
    Enter the author: Salinger
    Enter the year of publication: 1951
    Enter the genre: Coming-of-age
    Enter the library: Southside
    Enter your member ID: 86420
    Enter the return date: 2023-07-15
    You have successfully reserved the book 'Catcher' by Salinger.
    Year of Publication: 1951
    Genre: Coming-of-age
    Library: Southside
    Member ID: 86420
    Return Date: 2023-07-15 */

using System;

class MainClass {
    static public void Main()
    {
        // variables
        string book, author, genre, library, memberId, returnDate;
        int yearOfPublication;
        
        // ask user for info
        Console.Write("Enter the book title: ");
        book=Console.ReadLine();
        Console.Write("Enter the author: ");
        author=Console.ReadLine();
        Console.Write("Enter the year of publication: ");
        yearOfPublication=int.Parse(Console.ReadLine());
        Console.Write("Enter the genre: ");
        genre=Console.ReadLine();
        Console.Write("Enter the library: ");
        library=Console.ReadLine();
        Console.Write("Enter your member ID: ");
        memberId=Console.ReadLine();
        Console.Write("Enter the return date: ");
        returnDate=Console.ReadLine();
        
        // display info
        Console.Write($"You have successfully reserved the book '{book}' by {author}.\n");
        Console.Write($"Year of Publication: {yearOfPublication}\n");
        Console.Write($"Genre: {genre}\n");
        Console.Write($"Library: {library}\n");
        Console.Write($"Member ID: {memberId}\n");
        Console.Write($"Return Date: {returnDate}");
    }
}

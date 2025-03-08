/* Personal Information
  Write a program that asks the user to enter their name (string), age (int), and city (string). Print the entered values directly. The output should look like:

  Name: [Name]
  Age: [Age] 
  City: [City]

  Sample Output 1
  > Enter your name: Cody
    Enter your age: 18
    Enter your city: Cebu
    Name: Cody
    Age: 18
    City: Cebu
    
  Sample Output 2
  > Enter your name: Raul
    Enter your age: 22
    Enter your city: Masbate
    Name: Raul
    Age: 22
    City: Masbate
    
  Sample Output 3
  > Enter your name: David
    Enter your age: 60
    Enter your city: Talisay
    Name: David
    Age: 60
    City: Talisay */

using System;

class MainClass {

    static public void Main()
    {
        // variables
        string name, city;
        int age;
        
        // ask user for info
        Console.Write("Enter your name: ");
        name=Console.ReadLine();
        Console.Write("Enter your age: ");
        age=int.Parse(Console.ReadLine());
        Console.Write("Enter your city: ");
        city=Console.ReadLine();
        
        // display user info
        Console.Write($"Name: {name}\n");
        Console.Write($"Age: {age}\n");
        Console.Write($"City: {city}");
    }
}

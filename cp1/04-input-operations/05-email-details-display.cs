/* Email Details Display
  Write a program that prompts the user to enter the recipient, message, name, subject, version, discount, status, code, location, age, company name, website, phone, job title, and department. Display the entered values directly on the console in a specific format simulating an email.

  Dear [Recipient], I hope this email finds you well.
  [Message]
  Subject: [Subject]
  Sender: [Name]
  Version: [Version]
  Discount: [Discount]%
  Status: [Status]
  Code: [Code]
  Location: [Location]
  Age: [Age]
  Company: [Company Name]
  Website: [Website]
  Phone: [Phone]
  Job Title: [Job Title]
  Department: [Department]

  Sample Output 1
  > Enter the recipient: John
    Enter the message: Greetings
    Enter the name: Emily
    Enter the subject: Proposal
    Enter the version: 1.2
    Enter the discount: 10.5
    Enter the status: A
    Enter the code: ABC123
    Enter the location: Paris
    Enter the age: 35
    Enter the company name: XYZ
    Enter the website: www.xyz.com
    Enter the phone: 123-456-7890
    Enter the job title: Manager
    Enter the department: Sales
    Dear John, I hope this email finds you well.
    Greetings
    Subject: Proposal
    Sender: Emily
    Version: 1.2
    Discount: 10.50%
    Status: A
    Code: ABC123
    Location: Paris
    Age: 35
    Company: XYZ
    Website: www.xyz.com
    Phone: 123-456-7890
    Job Title: Manager
    Department: Sales
  
  Sample Output 2
  > Enter the recipient: Sarah
    Enter the message: Invitation
    Enter the name: James
    Enter the subject: Conference
    Enter the version: 2.1
    Enter the discount: 5.7
    Enter the status: P
    Enter the code: DEF456
    Enter the location: London
    Enter the age: 42
    Enter the company name: ABCCorp
    Enter the website: www.abccorp.com
    Enter the phone: 987-654-3210
    Enter the job title: Engineer
    Enter the department: R&D
    Dear Sarah, I hope this email finds you well.
    Invitation
    Subject: Conference
    Sender: James
    Version: 2.1
    Discount: 5.70%
    Status: P
    Code: DEF456
    Location: London
    Age: 42
    Company: ABCCorp
    Website: www.abccorp.com
    Phone: 987-654-3210
    Job Title: Engineer
    Department: R&D

  Sample Output 3
  > Enter the recipient: Lisa
    Enter the message: Update
    Enter the name: Michael
    Enter the subject: Newsletter
    Enter the version: 3.0
    Enter the discount: 2.3
    Enter the status: O
    Enter the code: GHI789
    Enter the location: NY
    Enter the age: 28
    Enter the company name: PQRLtd
    Enter the website: www.pqrltd.com
    Enter the phone: 555-123-4567
    Enter the job title: Analyst
    Enter the department: Finance
    Dear Lisa, I hope this email finds you well.
    Update
    Subject: Newsletter
    Sender: Michael
    Version: 3.0
    Discount: 2.30%
    Status: O
    Code: GHI789
    Location: NY
    Age: 28
    Company: PQRLtd
    Website: www.pqrltd.com
    Phone: 555-123-4567
    Job Title: Analyst
    Department: Finance */

using System;

class Program {
    static public void Main()
    {
        // variables
        string recipient, message, name, subject, code, location, companyName, website, phone, jobTitle, department;
        char status;
        int age;
        double version, discount;
        
        // ask user for info
        Console.Write("Enter the recipient: ");
        recipient=Console.ReadLine();
        Console.Write("Enter the message: ");
        message=Console.ReadLine();
        Console.Write("Enter the name: ");
        name=Console.ReadLine();
        Console.Write("Enter the subject: ");
        subject=Console.ReadLine();
        Console.Write("Enter the version: ");
        version=double.Parse(Console.ReadLine());
        Console.Write("Enter the discount: ");
        discount=double.Parse(Console.ReadLine());
        Console.Write("Enter the status: ");
        status=char.Parse(Console.ReadLine());
        Console.Write("Enter the code: ");
        code=Console.ReadLine();
        Console.Write("Enter the location: ");
        location=Console.ReadLine();
        Console.Write("Enter the age: ");
        age=int.Parse(Console.ReadLine());
        Console.Write("Enter the company name: ");
        companyName=Console.ReadLine();
        Console.Write("Enter the website: ");
        website=Console.ReadLine();
        Console.Write("Enter the phone: ");
        phone=Console.ReadLine();
        Console.Write("Enter the job title: ");
        jobTitle=Console.ReadLine();
        Console.Write("Enter the department: ");
        department=Console.ReadLine();
        
        // display info with message
        Console.Write($"Dear {recipient}, I hope this email finds you well.\n");
        Console.Write($"{message}\n");
        Console.Write($"Subject: {subject}\n");
        Console.Write($"Sender: {name}\n");
        Console.Write($"Version: {version:f1}\n");
        Console.Write($"Discount: {discount:f2}%\n");
        Console.Write($"Status: {status}\n");
        Console.Write($"Code: {code}\n");
        Console.Write($"Location: {location}\n");
        Console.Write($"Age: {age}\n");
        Console.Write($"Company: {companyName}\n");
        Console.Write($"Website: {website}\n");
        Console.Write($"Phone: {phone}\n");
        Console.Write($"Job Title: {jobTitle}\n");
        Console.Write($"Department: {department}");
    }
}

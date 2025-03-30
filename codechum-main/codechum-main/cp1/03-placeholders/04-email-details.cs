/** Email Details
    Write a program that prints the output below:

    Dear John, I hope this email finds you well.
    I wanted to reach out and say hello.
    I hope you are doing well and enjoying your day.
    It's been a while since we last spoke, and I wanted to catch up with you.
    Let's plan to meet up soon and have a great time together!
    Subject: Greetings
    Sender: Jane
    Version: 1.2
    Discount: 10.50%
    Status: A
    Code: ABCD123
    Location: City XYZ
    Age: 30
    Company: ABC Corporation
    Website: www.example.com
    Phone: +1 123-456-7890
    Job Title: Software Engineer
    Department: Engineering
    
    The program should use placeholders to present the information accurately.

    * Sample Output 1
      > Dear John, I hope this email finds you well.
        I wanted to reach out and say hello.
        I hope you are doing well and enjoying your day.
        It's been a while since we last spoke, and I wanted to catch up with you.
        Let's plan to meet up soon and have a great time together!
        Subject: Greetings
        Sender: Jane
        Version: 1.2
        Discount: 10.50%
        Status: A
        Code: ABCD123
        Location: City XYZ
        Age: 30
        Company: ABC Corporation
        Website: www.example.com
        Phone: +1 123-456-7890
        Job Title: Software Engineer
        Department: Engineering */

using System;

namespace Program {
    class main {
        static void Main(string[] args) {
            string receipient="John", subject="Greetings", sender="Jane", status="A", code="ABCD123", location="City XYZ", company="ABC Corporation", website="www.example.com", jobTitle="Software Engineer", department="Engineering";
            double version=1.2, discount=10.5, age=30, phoneCountry=1, phoneNum1=123, phoneNum2=456, phoneNum3=7890;
            
            Console.WriteLine("Dear {0}, I hope this email finds you well.\nI wanted to reach out and say hello.\nI hope you are doing well and enjoying your day.\nIt's been a while since we last spoke, and I wanted to catch up with you.\nLet's plan to meet up soon and have a great time together!\nSubject: {1}\nSender: {2}\nVersion: {3}\nDiscount: {4}0%\nStatus: {5}\nCode: {6}\nLocation: {7}\nAge: {8}\nCompany: {9}\nWebsite: {10}\nPhone: +{11} {12}-{13}-{14}\nJob Title: {15}\nDepartment: {16}", receipient, subject, sender, version, discount, status, code, location, age, company, website, phoneCountry, phoneNum1, phoneNum2, phoneNum3, jobTitle, department);
        }
    }
}

/** passed test cases
  * test case 1:
    > Dear John, I hope this email finds you well.
      I wanted to reach out and say hello.
      I hope you are doing well and enjoying your day.
      It's been a while since we last spoke, and I wanted to catch up with you.
      Let's plan to meet up soon and have a great time together!
      Subject: Greetings
      Sender: Jane
      Version: 1.2
      Discount: 10.50%
      Status: A
      Code: ABCD123
      Location: City XYZ
      Age: 30
      Company: ABC Corporation
      Website: www.example.com
      Phone: +1 123-456-7890
      Job Title: Software Engineer
      Department: Engineering */

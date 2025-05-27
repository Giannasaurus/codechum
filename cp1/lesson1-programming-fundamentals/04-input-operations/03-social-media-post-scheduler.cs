/** Social Media Post Scheduler
     Write a program that prompts the user to enter the post date (string), post time (string), post reach (double), post engagement (double), post duration (float), and post category (char). Display the entered values directly on the console in the format of a post scheduling summary.

    Post Scheduled:
    Date: [Post Date]
    Time: [Post Time]
    Reach: [Post Reach]
    Engagement: [Post Engagement]
    Duration: [Post Duration]
    Category: [Post Category]

    * Sample Output 1
      > Enter Post Date: 2023-06-01
        Enter Post Time: 12:30
        Enter Post Reach: 2500
        Enter Post Engagement: 1250
        Enter Post Duration: 4.5
        Enter Post Category: A

        Post Scheduled:
        Date: 2023-06-01
        Time: 12:30
        Reach: 2500.00
        Engagement: 1250.00
        Duration: 4.50
        Category: A
    
    * Sample Output 2
      > Enter Post Date: 2023-07-15
        Enter Post Time: 09:45
        Enter Post Reach: 5000
        Enter Post Engagement: 2500
        Enter Post Duration: 6.2
        Enter Post Category: B

        Post Scheduled:
        Date: 2023-07-15
        Time: 09:45
        Reach: 5000.00
        Engagement: 2500.00
        Duration: 6.20
        Category: B

    * Sample Output 3
      > Enter Post Date: 2023-08-10
        Enter Post Time: 15:20
        Enter Post Reach: 3500
        Enter Post Engagement: 1750
        Enter Post Duration: 3.8
        Enter Post Category: C

        Post Scheduled:
        Date: 2023-08-10
        Time: 15:20
        Reach: 3500.00
        Engagement: 1750.00
        Duration: 3.80
        Category: C */

using System;

class Program {
    static void Main() {
        // variables
        string postDate, postTime;
        double postReach, postEngagement;
        float postDuration;
        char postCategory;
        
        // ask user for info
        Console.Write("Enter Post Date: ");
        postDate=Console.ReadLine();
        Console.Write("Enter Post Time: ");
        postTime=Console.ReadLine();
        Console.Write("Enter Post Reach: ");
        postReach=double.Parse(Console.ReadLine());
        Console.Write("Enter Post Engagement: ");
        postEngagement=double.Parse(Console.ReadLine());
        Console.Write("Enter Post Duration: ");
        postDuration=float.Parse(Console.ReadLine());
        Console.Write("Enter Post Category: ");
        postCategory=char.Parse(Console.ReadLine());
        
        // display info
        Console.Write("\nPost Scheduled:\n");
        Console.Write($"Date: {postDate}\n");
        Console.Write($"Time: {postTime}\n");
        Console.Write($"Reach: {postReach:f2}\n");
        Console.Write($"Engagement: {postEngagement:f2}\n");
        Console.Write($"Duration: {postDuration:f2}\n");
        Console.Write($"Category: {postCategory}");
    }
}

/** passed test cases
  * test case 1:
    > Enter Post Date: 2023-06-01
      Enter Post Time: 12:30
      Enter Post Reach: 2500
      Enter Post Engagement: 1250
      Enter Post Duration: 4.5
      Enter Post Category: A

      Post Scheduled:
      Date: 2023-06-01
      Time: 12:30
      Reach: 2500.00
      Engagement: 1250.00
      Duration: 4.50
      Category: A
  * test case 2:
    > Enter Post Date: 2023-07-15
      Enter Post Time: 09:45
      Enter Post Reach: 5000
      Enter Post Engagement: 2500
      Enter Post Duration: 6.2
      Enter Post Category: B

      Post Scheduled:
      Date: 2023-07-15
      Time: 09:45
      Reach: 5000.00
      Engagement: 2500.00
      Duration: 6.20
      Category: B
  * test case 3:
    > Enter Post Date: 2023-08-10
      Enter Post Time: 15:20
      Enter Post Reach: 3500
      Enter Post Engagement: 1750
      Enter Post Duration: 3.8
      Enter Post Category: C

      Post Scheduled:
      Date: 2023-08-10
      Time: 15:20
      Reach: 3500.00
      Engagement: 1750.00
      Duration: 3.80
      Category: C
  * test case 4:
    > Enter Post Date: 2023-09-05
      Enter Post Time: 17:55
      Enter Post Reach: 5000
      Enter Post Engagement: 2000
      Enter Post Duration: 5.1
      Enter Post Category: A

      Post Scheduled:
      Date: 2023-09-05
      Time: 17:55
      Reach: 5000.00
      Engagement: 2000.00
      Duration: 5.10
      Category: A
  * test case 5:
    > Enter Post Date: 2023-10-20
      Enter Post Time: 11:10
      Enter Post Reach: 6000.25
      Enter Post Engagement: 3000.25
      Enter Post Duration: 7.5
      Enter Post Category: B

      Post Scheduled:
      Date: 2023-10-20
      Time: 11:10
      Reach: 6000.25
      Engagement: 3000.25
      Duration: 7.50
      Category: B
  * test case 6:
    > Enter Post Date: 2023-11-15
      Enter Post Time: 14:40
      Enter Post Reach: 4500.2
      Enter Post Engagement: 2250.6
      Enter Post Duration: 4.2
      Enter Post Category: C

      Post Scheduled:
      Date: 2023-11-15
      Time: 14:40
      Reach: 4500.20
      Engagement: 2250.60
      Duration: 4.20
      Category: C*/

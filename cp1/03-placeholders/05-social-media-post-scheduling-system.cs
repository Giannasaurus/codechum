/* Social Media Post Scheduling System
  Write a program that prints the output below:

  Post Scheduled:
  Content: Exciting news! Our new product is launching soon.
  Date: 2023-06-30
  Time: 10:00 AM
  Reach: 2500.50
  Engagement: 0.75
  Duration: 1.50
  Cost: 50.25
  Category: N
  Status: S
  Author Name: John Doe
  Author Email: johndoe@example.com
  Platform: Facebook
  Audience: Targeted
  Budget: 1000.00

  The program should display various post information using placeholders.

  Sample Output 1
    > Post Scheduled:
      Content: Exciting news! Our new product is launching soon.
      Date: 2023-06-30
      Time: 10:00 AM
      Reach: 2500.50
      Engagement: 0.75
      Duration: 1.50
      Cost: 50.25
      Category: N
      Status: S
      Author Name: John Doe
      Author Email: johndoe@example.com
      Platform: Facebook
      Audience: Targeted
      Budget: 1000.00 */

using System;

namespace Program {
    class main {
        static void Main(string[] args) {
            string content="Exciting news! Our new product is launching soon.", timeAMPM="AM", category="N", status="S", authorName="John Doe", authorEmail="johndoe@example.com", platform="Facebook", audience="Targeted";
            double dateYear=2023, dateMonth=6, dateDay=30, timeFirstHand=10, timeSecondHand=0, reach=2500.5, engagement=0.75, duration=1.5, cost=50.25, budget=1000;
            
            Console.WriteLine("Post Scheduled:\nContent: {0}\nDate: {1}-0{2}-{3}\nTime: {4}:{5}0 {6}\nReach: {7}0\nEngagement: {8}\nDuration: {9}0\nCost: {10}\nCategory: {11}\nStatus: {12}\nAuthor Name: {13}\nAuthor Email: {14}\nPlatform: {15}\nAudience: {16}\nBudget: {17}.00", content, dateYear, dateMonth, dateDay, timeFirstHand, timeSecondHand, timeAMPM, reach, engagement, duration, cost, category, status, authorName, authorEmail, platform, audience, budget);
        }
    }
}

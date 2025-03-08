/* Invoice Generation
  Create a program that generates an invoice with details such as the customer name of "John Doe", order ID of 12345, and total amount of $99.99, using placeholders. Output should look like:
  Invoice for Customer: John Doe
  Order ID: 12345
  Total Amount: $99.99

  Sample Output 1
    > Invoice for Customer: John Doe
      Order ID: 12345
      Total Amount: $99.99 */

using System;

namespace Program {
    class main {
        static void Main(string[] args) {
            string customer="John Doe";
            double orderId=12345, totalAmount=99.99;
            
            Console.WriteLine("Invoice for Customer: {0}\nOrder ID: {1}\nTotal Amount: ${2}", customer, orderId, totalAmount);
        }
    }
}

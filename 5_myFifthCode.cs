/* Rule 1: Your code should only display one message.
The message that your code displays will depend on the other five rules. For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.

Rule 2: If the user's subscription will expire in 10 days or less, display the message:
Your subscription will expire soon. Renew now!

Rule 3: If the user's subscription will expire in five days or less, display the messages:
Your subscription expires in _ days.
Renew now and save 10%!

Be sure to replace the _ character displayed in the message above with the value stored in the variable daysUntilExpiration when you construct your message output.

Rule 4: If the user's subscription will expire in one day, display the messages:
Your subscription expires within a day!
Renew now and save 20%!

Rule 5: If the user's subscription has expired, display the message:
Your subscription has expired.

Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing. */

namespace MyFifthCode {
    class Program {
        public static void RunSubscriptionMessage() {          
            for (int x = 0; x < 20; x++) {
                Random random = new Random();
                int daysUntilExpiration = random.Next(12);
                int discountPercentage = 0;
                Console.WriteLine($"Days until expiration: {daysUntilExpiration}");

                if (daysUntilExpiration == 0) {
                    Console.WriteLine("Your subscription has expired.\n");
                } else if (daysUntilExpiration == 1) {
                    discountPercentage += 20;
                    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!\n");
                } else if (daysUntilExpiration <= 5) {
                    discountPercentage += 10;
                    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days\nRenew now and save {discountPercentage}%!\n");
                } else if (daysUntilExpiration <= 10) {
                    Console.WriteLine("Your subscription will expire soon. Renew now!\n");
                } else if (daysUntilExpiration > 10) {
                    Console.WriteLine("");
                }
            }
        }
    }
}
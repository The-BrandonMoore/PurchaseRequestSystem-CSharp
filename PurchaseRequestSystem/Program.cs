using PurchaseRequestSystem.Models;

namespace PurchaseRequestSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            User user1 = new(1, "BMoore", "TestPass", "Brandon", "Moore", "email@email.com", "740-555-8191");
            User user2 = new(2, "MMoore", "Pass123", "Megan", "Moore", "wife'semail@heremail.com", "740-882-9002");

            Vendor vendor1 = new(1, "HB001", "Heavenly Books", "123 Faith Street", "Nashville", "TN", "37201", "615-555-1234", "info@heavenlybooks.com");
            Vendor vendor2 = new(2, "GMS02", "Grace Music Store", "456 Worship  Ave", "Charlotte", "NC", "28202", "704-555-5678", "sales@gracemusicstore.com");








        }
    }
}

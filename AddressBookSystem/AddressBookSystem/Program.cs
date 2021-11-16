using System;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Address Program Press- 1-Contacts, 2-Add Contact, 3-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information in Format of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        StartContact contact = new StartContact();
                        contact.FirstName = Console.ReadLine();
                        contact.LastName = Console.ReadLine();
                        contact.Address = Console.ReadLine();
                        contact.City = Console.ReadLine();
                        contact.State = Console.ReadLine();
                        contact.Zip = Console.ReadLine();
                        contact.PhoneNumber = Console.ReadLine();
                        contact.Email = Console.ReadLine();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
using System;

namespace AddressBookSystem
{
    class Program
    {
        Contact contact = new Contact();
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Address Program Press- 1-Contacts, 2-Add Contact, 3-Edit Contact, 4-Delete Contact, 5-Add Multiple Contact, 6-Refactor Method");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information in Format of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Contact newContact = new Contact();
                        newContact.FirstName = Console.ReadLine();
                        newContact.LastName = Console.ReadLine();
                        newContact.Address = Console.ReadLine();
                        newContact.City = Console.ReadLine();
                        newContact.State = Console.ReadLine();
                        newContact.Zip = Console.ReadLine();
                        newContact.PhoneNumber = Console.ReadLine();
                        newContact.Email = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Console.WriteLine("Enter the Contact to be Add: ");
                        Contact contact = new Contact();
                        AddressBook addressBook = new AddressBook();
                        addressBook.AddContact(contact);
                        contact.FirstName = Console.ReadLine();
                        contact.LastName = Console.ReadLine();
                        contact.Address = Console.ReadLine();
                        contact.City = Console.ReadLine();
                        contact.State = Console.ReadLine();
                        contact.Zip = Console.ReadLine();
                        contact.PhoneNumber = Console.ReadLine();
                        contact.Email = Console.ReadLine();
                        addressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact Name to be Edited: ");
                        string name = Console.ReadLine();
                        AddressBook ab = new AddressBook();
                        ab.EditContact(name);
                        ab.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Contact Name to be Deleted: ");
                        string user = Console.ReadLine();
                        AddressBook abb = new AddressBook();
                        abb.DeleteContact(user);
                        abb.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Console.WriteLine("Enter the Contact to be Add: ");
                        Contact con = new Contact();
                        AddressBook abo = new AddressBook();
                        abo.AddContact(con);
                        con.FirstName = Console.ReadLine();
                        con.LastName = Console.ReadLine();
                        con.Address = Console.ReadLine();
                        con.City = Console.ReadLine();
                        con.State = Console.ReadLine();
                        con.Zip = Console.ReadLine();
                        con.PhoneNumber = Console.ReadLine();
                        con.Email = Console.ReadLine();
                        abo.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        string nam = Console.ReadLine();
                        AddressBook aboo = new AddressBook();
                        aboo.AddUniqueContact(nam);
                        aboo.DisplayUniqueContacts();
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }

        }
    }
}
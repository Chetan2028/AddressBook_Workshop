using System;

namespace AddressBook_Workshop
{
    public class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem");
            AddressBook addressBook = new AddressBook();
            addressBook.DisplayMenu();
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    addressBook.AddContact();
                    break;
                case 2:
                    addressBook.EditContact();
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }
    }
}

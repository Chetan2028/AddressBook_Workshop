using System;

namespace AddressBook_Workshop
{
    public class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem");
            AddressBook addressBook = new AddressBook();
            addressBook.AddressBookMenu();
            
        }
    }
}

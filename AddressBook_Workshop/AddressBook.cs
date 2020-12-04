using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_Workshop
{
    public class AddressBook
    {
        //list to store contacts
        List<Contact> contactList = new List<Contact>();

        ContactValidator validator = new ContactValidator();

        /// <summary>
        /// Adds the contact.
        /// </summary>
        public void AddContact()
        {
            try
            {
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();
                validator.ValidateFirstName(firstName);

                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();
                validator.ValidateLastName(lastName);

                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();
                validator.ValidateAddress(address);

                Console.WriteLine("Enter Zip");
                int zip = Convert.ToInt32(Console.ReadLine());
                validator.ValidateZip(zip);

                Console.WriteLine("Enter Phone Number");
                string phoneNumber = Console.ReadLine();
                validator.ValidatePhoneNumber(phoneNumber);

                Console.WriteLine("Enter City");
                string city = Console.ReadLine();
                validator.ValidateCity(city);

                Console.WriteLine("Enter State");
                string state = Console.ReadLine();
                validator.ValidateState(state);

                Console.WriteLine("Enter Your Email");
                string email = Console.ReadLine();
                validator.ValidateEmail(email);


                Contact contact = new Contact
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    City = city,
                    State = state,
                    Zip = zip,
                    PhoneNumber = phoneNumber,
                    Email = email
                };

                contactList.Add(contact);
            }
            catch (AddressBookCustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Edits the contact.
        /// </summary>
        public void EditContact()
        {
            try
            {
                Console.WriteLine("Enter the First Name Which you want to edit");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter the Mobile Number which you want to edit");
                string phoneNumber = Console.ReadLine();

                foreach (Contact contacts in contactList)
                {
                    if (contacts.FirstName.Equals(firstName) && contacts.PhoneNumber.Equals(phoneNumber))
                    {
                        EditContactList(contacts);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch(AddressBookCustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Edits the contact list.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void EditContactList(Contact contact)
        {
            Console.WriteLine("Press 1 to Edit FirstName \nPress 2 to Edit LastName \nPress 3 to Edit Address \nPress 4 to Edit City" +
                "\nPress 5 to Edit State \nPress 6 to Edit Zip \nPress 7 to Edit Email \nPress 8 to Edit PhoneNumber ");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new First Name");
                        string firstName = Console.ReadLine();
                        validator.ValidateFirstName(firstName);
                        contact.FirstName = firstName;
                        break;
                    case 2:
                        Console.WriteLine("Enter new Last Name");
                        string lastName = Console.ReadLine();
                        validator.ValidateLastName(lastName);
                        contact.LastName = lastName;
                        break;
                    case 3:
                        Console.WriteLine("Enter new Address");
                        string address = Console.ReadLine();
                        validator.ValidateAddress(address);
                        contact.Address = address;
                        break;
                    case 4:
                        Console.WriteLine("Enter new City");
                        string city = Console.ReadLine();
                        validator.ValidateCity(city);
                        contact.City = city;
                        break;
                    case 5:
                        Console.WriteLine("Enter new State");
                        string state = Console.ReadLine();
                        validator.ValidateState(state);
                        contact.State = state;
                        break;
                    case 6:
                        Console.WriteLine("Enter new Zip");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        validator.ValidateZip(zip);
                        contact.Zip = zip;
                        break;
                    case 7:
                        Console.WriteLine("Enter new Email");
                        string email = Console.ReadLine();
                        validator.ValidateEmail(email);
                        contact.Email = email;
                        break;
                    case 8:
                        Console.WriteLine("Enter new Phone Number");
                        string phoneNumber = Console.ReadLine();
                        validator.ValidatePhoneNumber(phoneNumber);
                        contact.PhoneNumber = phoneNumber;
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
            catch(AddressBookCustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        public void DeleteContact()
        {
            Console.WriteLine("Enter contact's First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter contact's mobile Number");
            string phoneNumber = Console.ReadLine();

            foreach (Contact contacts in contactList)
            {
                if (contacts.FirstName.Equals(firstName) && contacts.PhoneNumber.Equals(phoneNumber))
                {
                    contactList.Remove(contacts);
                }
            }
        }

        /// <summary>
        /// Displays the menu.
        /// </summary>
        public void DisplayMenu()
        {
            Console.WriteLine("Press 1 to Add Contact \nPress 2 to Edit Contact \nPress 3 to Delete Contact ");
        }
    }
}

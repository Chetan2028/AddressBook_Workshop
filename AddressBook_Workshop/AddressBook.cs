using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook_Workshop
{
    public class AddressBook
    {
        //list to store contacts
        List<Contact> contactList = new List<Contact>();

        ContactValidator validator = new ContactValidator();

        //Store Address Book in Dictionary
        Dictionary<string, AddressBook> addressBookDictionary = new Dictionary<string, AddressBook>();

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

                bool result = validator.CheckForDuplicates(contactList, firstName, phoneNumber);
                if (result)
                {
                    AddContact();
                }
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
            catch (AddressBookCustomException e)
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
            catch (AddressBookCustomException e)
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
        /// Views the contact.
        /// </summary>
        public void ViewContact()
        {
            if (contactList.Count != 0)
            {
                foreach (Contact contacts in contactList)
                {
                    Console.WriteLine("First Name : " + contacts.FirstName + "\nLast Name : " + contacts.LastName + "\nAddress : " + contacts.Address
                        + "\nCity : " + contacts.City + "\nState : " + contacts.State + "\nZip : " + contacts.Zip +
                        "\nPhoneNumber : " + contacts.PhoneNumber + "\nEmail : " + contacts.Email);
                    Console.WriteLine("-----------***************************--------------");
                }
            }
            else
            {
                Console.WriteLine("No Contacts to display");
            }
        }

        /// <summary>
        /// Contacts the menu.
        /// </summary>
        public void ContactMenu()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Press 1 to Add Contact \nPress 2 to Edit Contact \nPress 3 to Delete Contact " +
                "\nPress 4 to View Contact \nPress 5 to Sort Contact Details \nPress 6 to Write Contact Details into File " +
                "\nPress 7 to Read Data From Text File \nPress 8 to Exit");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        EditContact();
                        break;
                    case 3:
                        DeleteContact();
                        break;
                    case 4:
                        ViewContact();
                        break;
                    case 5:
                        SortData();
                        break;
                    case 6:
                        WriteContactIntoFile();
                        break;
                    case 7:
                        ReadDataFromTextFile();
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the name of the address book.
        /// </summary>
        /// <returns></returns>
        public void CreateAddressBook()
        {
            try
            {
                Console.WriteLine("Enter the name of Address Book you want to create");
                string bookName = Console.ReadLine();
                if (!addressBookDictionary.ContainsKey(bookName))
                {
                    AddressBook addressBook = new AddressBook();
                    addressBookDictionary.Add(bookName, addressBook);
                    addressBook.ContactMenu();
                }
                else
                {
                    throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_ADDRESS_BOOK, "Address With Such Name Already Exists");
                }
            }
            catch (AddressBookCustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Gets the name of the existing book.
        /// </summary>
        /// <returns></returns>
        public void AccessExistingBook()
        {
            Console.WriteLine("Enter the name of Address Book you want to access");
            string existingBookName = Console.ReadLine();
            if (addressBookDictionary.ContainsKey(existingBookName))
            {
                AddressBook addressBook = new AddressBook();
                Console.WriteLine($"Welcome to {existingBookName} Address Book");
                addressBookDictionary[existingBookName].ContactMenu();
            }
            else
            {
                Console.WriteLine("No Such Address Book Found");
            }
        }

        /// <summary>
        /// Views the address book.
        /// </summary>
        public void ViewAddressBook()
        {
            if (addressBookDictionary.Count != 0)
            {
                foreach (var addressBook in addressBookDictionary.Keys)
                {
                    Console.WriteLine(addressBook);
                }
            }
            else
            {
                Console.WriteLine("No Address Book to display");
            }
        }

        /// <summary>
        /// Searchings the by city.
        /// </summary>
        public void SearchingByCity()
        {
            Console.WriteLine("Please enter City name");
            string searchCity = Console.ReadLine();
            foreach (KeyValuePair<string, AddressBook> keyValuePair in addressBookDictionary)
            {
                Console.WriteLine("Name of the Address Book ----------> " + keyValuePair.Key);
                AddressBook addressBook = keyValuePair.Value;
                addressBook.SearchContactDetails(searchCity);
            }
        }

        /// <summary>
        /// Searchings the state of the by.
        /// </summary>
        public void SearchingByState()
        {
            Console.WriteLine("Please enter State name");
            string searchState = Console.ReadLine();
            foreach (KeyValuePair<string, AddressBook> keyValuePair in addressBookDictionary)
            {
                Console.WriteLine("Name of the Address Book --------->" + keyValuePair.Key);
                AddressBook addressBook = keyValuePair.Value;
                addressBook.SearchContactDetails(searchState);
            }
        }

        /// <summary>
        /// Searches the contact details by city.
        /// </summary>
        /// <param name="searchElement">The search city.</param>
        public void SearchContactDetails(string searchElement)
        {
            contactList.ForEach(contacts =>
                {
                    if (contacts.City.Equals(searchElement))
                    {
                        Console.WriteLine("First Name : " + contacts.FirstName + "\nLast Name : " + contacts.LastName + "\nAddress : " + contacts.Address
                        + "\nCity : " + contacts.City + "\nState : " + contacts.State + "\nZip : " + contacts.Zip +
                        "\nPhoneNumber : " + contacts.PhoneNumber + "\nEmail : " + contacts.Email);
                        Console.WriteLine("-------------------------***********************---------------------");
                    }
                    if (contacts.State.Equals(searchElement))
                    {
                        Console.WriteLine("First Name : " + contacts.FirstName + "\nLast Name : " + contacts.LastName + "\nAddress : " + contacts.Address
                        + "\nCity : " + contacts.City + "\nState : " + contacts.State + "\nZip : " + contacts.Zip +
                        "\nPhoneNumber : " + contacts.PhoneNumber + "\nEmail : " + contacts.Email);
                        Console.WriteLine("-------------------------***********************---------------------");
                    }
                });
        }

        /// <summary>
        /// Sortings the contact details.
        /// </summary>
        public List<Contact> SortingContactDetails()
        {
            Console.WriteLine("Please press 1 to sort the data by name");
            Console.WriteLine("Please press 2 to sort the data by city");
            Console.WriteLine("Please press 3 to sort the data by state");
            Console.WriteLine("Please press 4 to sort the data by zip");
            Console.WriteLine("Please press any other to return the unsorted contacts");
            int sortingContacts = Convert.ToInt32(Console.ReadLine());

            switch (sortingContacts)
            {
                case 1:
                    contactList.Sort((contact1, contact2) => contact1.FirstName.CompareTo(contact2.FirstName));
                    contactList.Sort((contact1, contact2) => contact1.LastName.CompareTo(contact2.LastName));
                    return contactList;
                case 2:
                    contactList.Sort((contact1, contact2) => contact1.City.CompareTo(contact2.City));
                    return contactList;
                case 3:
                    contactList.Sort((contact1, contact2) => contact1.State.CompareTo(contact2.State));
                    return contactList;
                case 4:
                    contactList.Sort((contact1, contact2) => contact1.Zip.CompareTo(contact2.Zip));
                    return contactList;
                default:
                    return contactList;
            }
        }

        /// <summary>
        /// Sorts the data.
        /// </summary>
        public void SortData()
        {
            List<Contact> sortingData = SortingContactDetails();
            foreach (var contacts in sortingData)
            {
                Console.WriteLine("First Name : " + contacts.FirstName + "\nLast Name : " + contacts.LastName + "\nAddress : " + contacts.Address
                        + "\nCity : " + contacts.City + "\nState : " + contacts.State + "\nZip : " + contacts.Zip +
                        "\nPhoneNumber : " + contacts.PhoneNumber + "\nEmail : " + contacts.Email);
                Console.WriteLine("-------------------------***********************---------------------");
            }
        }

        /// <summary>
        /// Writes the contact into file.
        /// </summary>
        public void WriteContactIntoFile()
        {
            try
            {
                Contact contacts;
                string line;
                string filePath = @"D:\C# Programs\AddressBook_Workshop\AddressBook_Workshop\ContactFile.txt";

                using(StreamWriter writer = File.AppendText(filePath))
                {
                    for (int i = 0; i < contactList.Count; i++)
                    {
                        contacts = contactList[i];
                        line = contacts.FirstName + "\t" + contacts.LastName + "\t" + contacts.Address + "\t" + contacts.PhoneNumber
                            + "\t" + contacts.State + "\t" + contacts.City + "\t" + contacts.Zip + "\t" + contacts.Email;

                        writer.WriteLine(line);
                    }
                }
            }
            catch(IOException)
            {
                Console.WriteLine("File not found");
            }
        }

        /// <summary>
        /// Reads the data from text file.
        /// </summary>
        public void ReadDataFromTextFile()
        {
            string filePath = @"D:\C# Programs\AddressBook_Workshop\AddressBook_Workshop\ContactFile.txt";
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        /// <summary>
        /// Addresses the book menu.
        /// </summary>
        public void AddressBookMenu()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Press 1 to Create Address Book \nPress 2 to Access Address Book \nPress 3 to View Address Book" +
                    " \nPress 4 to Search Contact by City \nPress 5 to Search Contacts by State \nPress 6 to exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateAddressBook();
                        break;
                    case 2:
                        AccessExistingBook();
                        break;
                    case 3:
                        ViewAddressBook();
                        break;
                    case 4:
                        SearchingByCity();
                        break;
                    case 5:
                        SearchingByState();
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
        }
    }
}


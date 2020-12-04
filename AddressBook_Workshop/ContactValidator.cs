using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBook_Workshop
{
    public class ContactValidator
    {
        //Regex Constants
        public const string REGEX_FIRST_NAME = "^[A-Z][A-Za-z]{3,}$";
        public const string REGEX_LAST_NAME = "^[A-Z][A-Za-z]{3,}$";
        public const string REGEX_ADDRESS = @"^[A-Za-z ]*$";
        public const string REGEX_ZIP = "^[1-9][0-9]{5}$";
        public const string REGEX_CITY = "^[A-Z][A-Za-z]{3,}$";
        public const string REGEX_STATE = "^[A-Z][A-Za-z]{3,}$";
        public const string REGEX_PHONE_NUMBER = "^[1-9][0-9]{9}$";
        public const string REGEX_EMAIL = "^[A-Za-z0-9]*[@][a-z]*[.][a-z]*";

        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <exception cref="AddressBook_Workshop.AddressBookCustomException">Invalid First Name</exception>
        public void ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName,REGEX_FIRST_NAME))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_FIRST_NAME, "Invalid First Name");
            }
        }

        /// <summary>
        /// Validates the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <exception cref="AddressBook_Workshop.AddressBookCustomException">Invalid Last Name</exception>
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName,REGEX_LAST_NAME))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_LAST_NAME, "Invalid Last Name");
            }
        }

        /// <summary>
        /// Validates the address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <exception cref="AddressBook_Workshop.AddressBookCustomException">Invalid Address</exception>
        public void ValidateAddress(string address)
        {
            if (Regex.IsMatch(address, REGEX_ADDRESS))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_ADDRESS, "Invalid Address");
            }
        }

        /// <summary>
        /// Validates the city.
        /// </summary>
        /// <param name="city">The city.</param>
        /// <exception cref="AddressBook_Workshop.AddressBookCustomException">Invalid City</exception>
        public void ValidateCity(string city)
        {
            if (Regex.IsMatch(city, REGEX_CITY))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_CITY, "Invalid City");
            }
        }

        /// <summary>
        /// Validates the state.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <exception cref="AddressBook_Workshop.AddressBookCustomException">Invalid State</exception>
        public void ValidateState(string state)
        {
            if (Regex.IsMatch(state, REGEX_STATE))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_STATE, "Invalid State");
            }
        }

        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <exception cref="AddressBook_Workshop.AddressBookCustomException">Invalid Phone Number</exception>
        public void ValidatePhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, REGEX_PHONE_NUMBER))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_PHONE_NUMBER, "Invalid Phone Number");
            }
        }

        /// <summary>
        /// Validates the zip.
        /// </summary>
        /// <param name="zip">The zip.</param>
        /// <exception cref="AddressBook_Workshop.AddressBookCustomException">Invalid Zip</exception>
        public void ValidateZip(int zip)
        {
            if (Regex.IsMatch(zip.ToString(), REGEX_ZIP))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_ZIP, "Invalid Zip");
            }
        }

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <exception cref="AddressBook_Workshop.AddressBookCustomException">Invalid Email</exception>
        public void ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, REGEX_EMAIL))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_EMAIL, "Invalid Email");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_Workshop
{
    public class AddressBookCustomException : Exception
    {

        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_ADDRESS,
            INVALID_CITY,
            INVALID_STATE,
            INVALID_ZIP,
            INVALID_PHONE_NUMBER,
            INVALID_EMAIL,
            INVALID_ADDRESS_BOOK
        }

        public ExceptionType type;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookCustomException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public AddressBookCustomException(ExceptionType type , string message) : base(message)
        {
            this.type = type;
        }
    }
}

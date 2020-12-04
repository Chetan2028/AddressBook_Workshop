using AddressBook_Workshop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
    [TestClass]
    public class AddressBookUnitTest
    {
        AddressBook address = new AddressBook();
        ContactValidator validator = new ContactValidator();

        [TestMethod]
        public void GivenContactDetail_ShouldAnalyse_ReturnContactCount()
        {
            //Arrange
            address.AddContact();

        }
    }
}

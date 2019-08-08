using Xunit;

namespace Contacts
{
    public class ContactsUnitTest
    {
        [Fact]
        public void Test1()
        {
            var contacts = new Contacts();
            contacts.Add("hack");
            contacts.Add("hacker");

            int count = contacts.FindContactsStartingWith("hac");

            Assert.Equal(2, count);
        }
    }
}

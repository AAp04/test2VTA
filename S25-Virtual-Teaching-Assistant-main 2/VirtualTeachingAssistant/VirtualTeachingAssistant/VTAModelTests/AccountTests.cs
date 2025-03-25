using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTAModelLibrary;

namespace VTAModelTests
{
    [TestClass]
    public class AccountTests
    {

        [TestMethod]
        public void AccountContructorTest()
        {
            Account a = new Account(10, "brucewayne", "imbatman", "Bruce", "Wayne","bwayne@wayne.com");
            Assert.IsNotNull(a);
            Assert.AreEqual(10, a.ID);
            Assert.AreEqual("brucewayne", a.AccountName);
            Assert.AreEqual("imbatman", a.Password);
            Assert.AreEqual("Bruce", a.FirstName);
            Assert.AreEqual("Wayne", a.LastName);
            Assert.AreEqual("bwayne@wayne.com", a.Email);
        }

        [TestMethod]
        public void AccountAssignmentTest() {
            Account a = new Account();
            Assert.IsNotNull(a);
            Assert.AreEqual(0, a.ID);
            Assert.AreEqual("", a.AccountName);
            Assert.AreEqual("", a.Password);
            Assert.AreEqual("", a.FirstName);
            Assert.AreEqual("", a.LastName);
            Assert.AreEqual("", a.Email);
            a.ID = 10;
            a.AccountName = "brucewayne";
            a.Password = "imbatman";
            a.FirstName = "Bruce";
            a.LastName = "Wayne";
            a.Email = "bwayne@wayne.com";
            Assert.AreEqual(10, a.ID);
            Assert.AreEqual("brucewayne", a.AccountName);
            Assert.AreEqual("imbatman", a.Password);
            Assert.AreEqual("Bruce", a.FirstName);
            Assert.AreEqual("Wayne", a.LastName);
            Assert.AreEqual("bwayne@wayne.com", a.Email);

        }
    }
}

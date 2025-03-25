using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTAModelLibrary;

namespace VTAModelTests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentConstructorTest()
        {
            Student s = new Student(10,"Freshman",10);
            Assert.IsNotNull(s);
            Assert.AreEqual(10,s.ID);
            Assert.AreEqual("Freshman",s.Year);
            Assert.AreEqual(10,s.AccountID);
        }
        [TestMethod]
        public void StudentAssignmentTest() {
            Student s = new Student();
            Assert.IsNotNull(s);
            Assert.AreEqual(0, s.ID);
            Assert.AreEqual("", s.Year);
            Assert.AreEqual(0, s.AccountID);

            s.ID = 10;
            s.Year = "Freshman";
            s.AccountID = 10;
            Assert.AreEqual(10, s.ID);
            Assert.AreEqual("Freshman", s.Year);
            Assert.AreEqual(10, s.AccountID);

        }
    }
}

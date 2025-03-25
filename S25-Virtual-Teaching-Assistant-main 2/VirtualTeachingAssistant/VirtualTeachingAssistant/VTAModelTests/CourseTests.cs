using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTAModelLibrary;

namespace VTAModelTests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CourseConstructorTest() {
            Course c = new Course(10, "History 101", "History", "FALL", 2025);
            Assert.IsNotNull(c);
            Assert.AreEqual(10, c.ID);
            Assert.AreEqual("History 101", c.Title);
            Assert.AreEqual("History", c.Subject);
            Assert.AreEqual("FALL", c.Semester);
            Assert.AreEqual(2025, c.Year);

        }

        [TestMethod]
        public void CourseAssignmentTest() {

            Course c = new Course();
            Assert.IsNotNull(c);
            Assert.AreEqual(0, c.ID);
            Assert.AreEqual(string.Empty, c.Title);
            Assert.AreEqual(string.Empty, c.Subject);
            Assert.AreEqual(string.Empty, c.Semester);
            Assert.AreEqual(0, c.Year);
            c.ID = 10;
            c.Title = "History 101";
            c.Subject = "History";
            c.Semester = "FALL";
            c.Year = 2025;
            Assert.AreEqual(10, c.ID);
            Assert.AreEqual("History 101", c.Title);
            Assert.AreEqual("History", c.Subject);
            Assert.AreEqual("FALL", c.Semester);
            Assert.AreEqual(2025, c.Year);
        }
    }
}

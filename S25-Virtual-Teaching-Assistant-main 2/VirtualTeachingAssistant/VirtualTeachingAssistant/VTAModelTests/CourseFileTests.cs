using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTAModelLibrary;

namespace VTAModelTests
{
    [TestClass]
    public class CourseFileTests
    {
        [TestMethod]
        public void CourseFileConstructorTest()
        {
            CourseFile cf = new CourseFile(10, 10, "examplelink.jpg", "Syllabus");
            Assert.IsNotNull(cf);
            Assert.AreEqual(10, cf.ID);
            Assert.AreEqual(10, cf.CourseID);
            Assert.AreEqual("examplelink.jpg", cf.FileLink);
            Assert.AreEqual("Syllabus", cf.AssignmentCategory);
        }

        [TestMethod]
        public void CourseFileAssignmentTest()
        {
            CourseFile cf = new CourseFile();
            Assert.IsNotNull(cf);
            Assert.AreEqual(0, cf.ID);
            Assert.AreEqual(0, cf.CourseID);
            Assert.AreEqual("", cf.FileLink);
            Assert.AreEqual("", cf.AssignmentCategory);
            cf.ID = 10;
            cf.CourseID = 10;
            cf.FileLink = "examplelink.jpg";
            cf.AssignmentCategory = "Syllabus";
            Assert.AreEqual(10, cf.ID);
            Assert.AreEqual(10, cf.CourseID);
            Assert.AreEqual("examplelink.jpg", cf.FileLink);
            Assert.AreEqual("Syllabus", cf.AssignmentCategory);
        }

    }
}

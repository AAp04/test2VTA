using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTAModelLibrary;

namespace VTAModelTests
{
    [TestClass]
    public class StudentRequestTests
    {
        [TestMethod]
        public void StudentRequestConstructorTest()
        {
            StudentRequest sr = new StudentRequest(10, 10, "High");
            Assert.IsNotNull(sr);
            Assert.AreEqual(10,sr.StudentID);
            Assert.AreEqual(10,sr.RequestID);
            Assert.AreEqual("High", sr.PriorityLevel);
        }

        [TestMethod]
        public void StudentRequestAssignmentTest() {
            StudentRequest sr = new StudentRequest();
            Assert.IsNotNull(sr);
            Assert.AreEqual(0, sr.StudentID);
            Assert.AreEqual(0, sr.RequestID);
            Assert.AreEqual("", sr.PriorityLevel);

            sr.StudentID = 10;
            sr.RequestID = 10;
            sr.PriorityLevel = "High";
            Assert.AreEqual(10, sr.StudentID);
            Assert.AreEqual(10, sr.RequestID);
            Assert.AreEqual("High", sr.PriorityLevel);

        }
    }
}

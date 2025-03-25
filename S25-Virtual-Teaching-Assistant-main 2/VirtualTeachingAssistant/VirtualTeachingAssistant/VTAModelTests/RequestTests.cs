using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTAModelLibrary;

namespace VTAModelTests
{
    [TestClass]
    public class RequestTests
    {
        [TestMethod]
        public void RequestConstructorTest()
        {
            Request r = new Request(10,"body","type",DateTime.Now,"status",10,10);
            Assert.IsNotNull(r);
            Assert.AreEqual(10,r.ID);
            Assert.AreEqual("body",r.Body);
            Assert.AreEqual("type",r.Type);
            Assert.AreEqual("status",r.Status);
            Assert.AreEqual(10,r.CourseID);
            Assert.AreEqual(10,r.ChatID);
        }

        [TestMethod]
        public void RequestAssignmentTest() {
            Request r = new Request();
            Assert.IsNotNull(r);
            Assert.AreEqual(0, r.ID);
            Assert.AreEqual("", r.Body);
            Assert.AreEqual("", r.Type);
            Assert.AreEqual("", r.Status);
            Assert.AreEqual(0, r.CourseID);
            Assert.AreEqual(0, r.ChatID);
            r.ID = 10;
            r.Body = "body";
            r.Type = "type";
            r.Status = "status";
            r.CourseID = 10;
            r.ChatID = 10;
            Assert.AreEqual(10, r.ID);
            Assert.AreEqual("body", r.Body);
            Assert.AreEqual("type", r.Type);
            Assert.AreEqual("status", r.Status);
            Assert.AreEqual(10, r.CourseID);
            Assert.AreEqual(10, r.ChatID);
        }
    }
}

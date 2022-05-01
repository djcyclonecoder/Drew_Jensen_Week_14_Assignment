using Microsoft.VisualStudio.TestTools.UnitTesting;
using Drew_Jensen_Week_14_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drew_Jensen_Week_14_Assignment.Models.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void GetStudentName()
        {
            // Assign    
            var name = new Student();

            // Act
            name.StudFirstName = "Buck";
            name.StudLastName = "Rogers";

            string fullName = name.StudFirstName + " " + name.StudLastName;

            // Assert
            Assert.AreEqual("Buck Rogers", fullName);
        }

    }
}



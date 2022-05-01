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
    
    
    public class ClassTests
    {
        [TestMethod()]
        public void GetClassRoomNumber()
        {
            // Assign    
            var sut = new Class();

            // Act
            sut.ClassRoomNumber = "Bulwinkle Hall 315";

            // Assert
            Assert.AreEqual("Bulwinkle Hall 315", sut.ClassRoomNumber);
        }


    }


}
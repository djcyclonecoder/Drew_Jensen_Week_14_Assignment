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
    public class FacultyTests
    {
        [TestMethod()]

        public void GetTenureChecked()
        {
            // Assign    
            var tenure = new Faculty();

            // Act
            tenure.TenureIsChecked = true;


            // Assert
            Assert.IsTrue(tenure.TenureIsChecked);
        }

    }
}
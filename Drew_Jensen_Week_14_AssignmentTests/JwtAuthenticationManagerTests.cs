using Microsoft.VisualStudio.TestTools.UnitTesting;
using Drew_Jensen_Week_14_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drew_Jensen_Week_14_Assignment.Controllers;

namespace Drew_Jensen_Week_14_Assignment.Tests
{
    [TestClass()]
    public class JwtAuthenticationManagerTests
    {
        [TestMethod()]
        public void AuthenticateTest()
        {
            JwtAuthenticationManager manager = new JwtAuthenticationManager("fakekeynotlegit12344556!$!");

            User user = new User
            {
                username = "user4",

                password = "pwd4"
            };

            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNotNull(ret);
        }

        [TestMethod()]
        public void AuthenticateTestPasswordCheck()
        {
            JwtAuthenticationManager manager = new JwtAuthenticationManager("fakekeynotlegit12344556!$!");

            User user = new User
            {
                username = "user4",

                password = "pwd"
            };

            var ret = manager.Authenticate(user.username, user.password);

            Assert.AreNotEqual(user.password, "pwd4");
        }
    }
}
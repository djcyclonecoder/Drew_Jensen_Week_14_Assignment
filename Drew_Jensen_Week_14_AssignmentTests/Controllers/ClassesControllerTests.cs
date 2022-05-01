using Microsoft.VisualStudio.TestTools.UnitTesting;
using Drew_Jensen_Week_14_Assignment.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Drew_Jensen_Week_14_Assignment.Models;
using Drew_Jensen_Week_14_Assignment.Data;
using Microsoft.EntityFrameworkCore;

namespace Drew_Jensen_Week_14_Assignment.Controllers.Tests
{
    [TestClass()]
    public class ClassesControllerTests
    {

        private readonly Wossamotta_UContext _context;

        public ClassesControllerTests(Wossamotta_UContext context)
        {
            _context = context;
        }



    }
    
}
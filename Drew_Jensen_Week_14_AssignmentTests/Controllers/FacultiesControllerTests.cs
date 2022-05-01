using Microsoft.VisualStudio.TestTools.UnitTesting;
using Drew_Jensen_Week_14_Assignment.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drew_Jensen_Week_14_Assignment.Data;
using Drew_Jensen_Week_14_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Drew_Jensen_Week_14_Assignment.Controllers.Tests
{
    [TestClass()]
    public class FacultiesControllerTests
    {

        private readonly Wossamotta_UContext _context;

        public FacultiesControllerTests(Wossamotta_UContext context)
        {
            _context = context;
        }


        [TestMethod()]
        public async Task<ActionResult<IEnumerable<Faculty>>> GetFacultiesTest()
        {
            Faculty faculty = new Faculty();

            faculty.FacultyId = "FA000012";
            faculty.Title = "Professor Emeritus";
            faculty.TenureIsChecked = true;
            faculty.FacFirstName = "Jacob";
            faculty.FacLastName = "Marley";

            /*
            "facultyId": "FA000012",
            "title": "Professor Emeritus",
            "tenureIsChecked": true,
            "facFirstName": "Jacob",
            "facLastName": "Marley",
            //v"facultyClasses": []
            */

            // Assert.IsInstanceOfType(faculty, typeof(Faculty));

            return await _context.Faculties.ToListAsync();

            // return = null;

            Assert.IsInstanceOfType(faculty, typeof(Faculty));



            /*
            // GET: api/Faculties
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Faculty>>> GetFaculties()
            {
                return await _context.Faculties.ToListAsync();
            }
            */











            Assert.Fail();
        }
    }
}
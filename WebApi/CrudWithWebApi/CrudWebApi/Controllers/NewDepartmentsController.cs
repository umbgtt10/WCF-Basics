using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CrudLibrary;

namespace CrudWebApi.Controllers
{
    //[MyException] ==> Applied at controller level
    public class NewDepartmentsController : ApiController
    {
        private MyOrgContext _context = new MyOrgContext();

        // ..api/Departments
        [ResponseType(typeof(IEnumerable<Department>))]
        public IHttpActionResult Get()
        {
            return Ok(_context.Departments.ToList());
        }

        // ..api/Departments/id
        [ResponseType(typeof(Department))]
        //[MyException] ==> Applied at method/verb level
        public IHttpActionResult Get(int id)
        {
            var department = _context.Departments.Find(id);

            if (department == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(department);
            }
        }

        // ..api/Departments/id
        [ResponseType(typeof(Department))]
        public IHttpActionResult Put(int id, Department department)
        {
            var existingDepartment = _context.Departments.Find(id);

            if (existingDepartment == null)
            {
                return NotFound();
            }
            else
            {
                existingDepartment.Gender = department.Gender;
                existingDepartment.DName = department.DName;
                existingDepartment.HOD = department.HOD;
                _context.SaveChanges();
                return Ok(department);
            }
        }

        // ..api/Departments/id
        [ResponseType(typeof(Department))]
        public IHttpActionResult Delete(int id)
        {
            var department = _context.Departments.Find(id);

            if (department == null)
            {
                return NotFound();
            }
            else
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
                return Ok(department);
            }
        }

        // ..api/Departments
        [ResponseType(typeof(Department))]
        public IHttpActionResult Post(Department department)
        {
            try
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return CreatedAtRoute("DefaultApi", new {id = department.Did}, department);
            }
            catch (Exception e)
            {
                var existingDepartment = _context.Departments.Single(d =>
                    d.DName.Equals(department.DName) && 
                    d.Gender.Equals(department.Gender) &&
                    d.HOD.Equals(department.Gender));

                return BadRequest($"Department with id:{existingDepartment.Did} already present.");
            }
        }
    }
}

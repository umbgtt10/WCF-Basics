using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrudLibrary;

namespace CrudWebApi.Controllers
{
    public class DepartmentsController : ApiController
    {
        private MyOrgContext _context = new MyOrgContext();

        // ..api/Departments
        public IList<Department> Get()
        {
            return _context.Departments.ToList();
        }

        // ..api/Departments/id
        public Department Get(int id)
        {
            var department = _context.Departments.Find(id);

            if (department == null)
            {
                return null;
            }
            else
            {
                return department;
            }
        }

        // ..api/Departments/id
        public void Put(int id, Department department)
        {
            _context.Entry(department).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // ..api/Departments/id
        public void Delete(int id)
        {
            var department = _context.Departments.Find(id);
            _context.Departments.Remove(department);
            _context.SaveChanges();
        }

        // ..api/Departments
        public void Post(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }
    }
}

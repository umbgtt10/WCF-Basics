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
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse<IEnumerable<Department>>(
                HttpStatusCode.OK,
                _context.Departments.ToList());
        }

        // ..api/Departments/id
        public HttpResponseMessage Get(int id)
        {
            var department = _context.Departments.Find(id);

            if (department == null)
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.NotFound,
                    $"Department with id:{id} not found.");
            }
            else
            {
                return Request.CreateResponse(
                    HttpStatusCode.OK,
                    department);
            }
        }

        // ..api/Departments/id
        public HttpResponseMessage Put(int id, Department department)
        {
            var existingDepartment = _context.Departments.Find(id);

            if (existingDepartment == null)
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.NotFound,
                    $"Department with id:{id} not found.");
            }
            else
            {
                _context.Entry(existingDepartment).CurrentValues.SetValues(department);
                _context.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, department);
            }
        }

        // ..api/Departments/id
        public HttpResponseMessage Delete(int id)
        {
            var department = _context.Departments.Find(id);

            if (department == null)
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.NotFound,
                    $"Department with id:{id} not found.");
            }
            else
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, department);
            }
        }

        // ..api/Departments
        public HttpResponseMessage Post(Department department)
        {
            try
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created, department);
            }
            catch (Exception e)
            {
                var existingDepartment = _context.Departments.Single(d =>
                    d.DName.Equals(department.DName) && 
                    d.Gender.Equals(department.Gender) &&
                    d.HOD.Equals(department.Gender));

                return Request.CreateErrorResponse(
                    HttpStatusCode.BadRequest, $"Department with id:{existingDepartment.Did} already present.");
            }

        }
    }
}

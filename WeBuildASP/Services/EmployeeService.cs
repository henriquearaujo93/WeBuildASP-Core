using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBuildASP.Models;
using WeBuildASP.Services.Exceptions;

namespace WeBuildASP.Services
{
    public class EmployeeService
    {
        //Dependency for Context
        private readonly WeBuildASPContext _context;

        //Construct for dependency
        public EmployeeService(WeBuildASPContext context)
        {
            _context = context;
        }

        //Return a list of Employees
        public List<Employee> FindAll()
        {
            return _context.EMPLOYS.ToList();
        }

        //Find Employees by id
        public Employee FindById(int id)
        {
            //return Employes
            return _context.EMPLOYS.FirstOrDefault(obj => obj.ID == id);
        }

        //Method to insert Employee
        public void Insert(Employee employee)
        {
            int lastId = _context.EMPLOYS.Select(obj => obj.ID).Last(); //Load last Employee Id            

            //Increment new employee id to the last one
            employee.IncrementId(lastId);

            _context.Add(employee); //Add new employee
            _context.SaveChanges(); //Save changes
        }

        //Remove Employee by id
        public void remove(int id)
        {
            var obj = _context.EMPLOYS.Find(id);
            _context.EMPLOYS.Remove(obj);

            //Confirm Alter
            _context.SaveChanges();
        }

        //Update Employee
        public void Update(Employee obj)
        {
            //Test if id exists
            if (!_context.EMPLOYS.Any(x => x.ID == obj.ID))
            {
                throw new NotFoundException("Id not Found");
            }

            //Update Employe
            _context.Update(obj);

            //Save changes
            _context.SaveChanges();
        }
    }
}

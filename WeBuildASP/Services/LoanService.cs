using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBuildASP.Models;
using WeBuildASP.Services.Exceptions;

namespace WeBuildASP.Services
{
    public class LoanService
    {
        //Dependency for Context
        private readonly WeBuildASPContext _context;

        //Construct for dependency
        public LoanService(WeBuildASPContext context)
        {
            _context = context;
        }

        //Return a list of Loan
        public List<Loan> FindAll()
        {
            return _context.LOAN.ToList();
        }

        //Method to insert Loan
        public void Insert(Loan loan)
        {
            //int lastId = _context.LOAN.Select(obj => obj.ID).Last(); //Load last loan Id            

            //Increment new Loan id to the last one
            loan.IncrementId();

            _context.Add(loan); //Add new loan
            _context.SaveChanges(); //Save changes
        }

        //Method to find Loan by Id
        public Loan FindById(int id)
        {
            //return Loan
            return _context.LOAN.FirstOrDefault(obj => obj.ID == id);
        }

        //Remove Loan by Id
        public void remove(int id)
        {
            var obj = _context.LOAN.Find(id);
            _context.LOAN.Remove(obj);

            //Confirm Alter
            _context.SaveChanges();
        }

        //Update Loan
        public void Update(Loan obj)
        {
            //Test if id exists
            if (!_context.LOAN.Any(x => x.ID == obj.ID))
            {
                throw new NotFoundException("Id not Found");
            }

            //Update Loan
            _context.Update(obj);

            //Save changes
            _context.SaveChanges();
        }
    }
}
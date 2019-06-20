using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBuildASP.Models;
using WeBuildASP.Services.Exceptions;

namespace WeBuildASP.Services
{
    public class LoanForEmployService
    {
        //Dependency for Context
        private readonly WeBuildASPContext _context;

        //Construct for dependency
        public LoanForEmployService(WeBuildASPContext context)
        {
            _context = context;
        }

        //Return a list of Loan for employ
        public List<LoanForEmploy> FindAll()
        {
            return _context.LOAN_FOR_EMPLOY.ToList();
        }

        //Method to find Loans by Id
        public LoanForEmploy FindById(int id)
        {
            //return Loans
            return _context.LOAN_FOR_EMPLOY.FirstOrDefault(obj => obj.ID == id);
        }

        //Update Loans
        public void Update(LoanForEmploy obj)
        {
            //Test if id exists
            if (!_context.LOAN_FOR_EMPLOY.Any(x => x.ID == obj.ID))
            {
                throw new NotFoundException("Id not Found");
            }

            //Update Loan
            _context.Update(obj);

            //Save changes
            _context.SaveChanges();
        }

        //Method to  Average for loan
        public float Average()
        {
            //Return Average 
            return _context.LOAN_FOR_EMPLOY.Average(x => x.L_F_AMOUNT);
        }
        
    }
}

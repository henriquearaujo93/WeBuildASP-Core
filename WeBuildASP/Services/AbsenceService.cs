using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBuildASP.Models;
using WeBuildASP.Services.Exceptions;

namespace WeBuildASP.Services
{
    public class AbsenceService
    {
        //Dependency for Context
        private readonly WeBuildASPContext _context;

        //Construct for dependency
        public AbsenceService(WeBuildASPContext context)
        {
            _context = context;
        }

        //Return a list of Teams
        public List<Absence> FindAll()
        {
            return _context.ABSENCE.ToList();
        }

        //Method to find Absence by Id
        public Absence FindById(int id)
        {
            //return Absence
            return _context.ABSENCE.FirstOrDefault(obj => obj.ID == id);
        }

        //Remove Absence by Id
        public void remove(int id)
        {
            var obj = _context.ABSENCE.Find(id);
            _context.ABSENCE.Remove(obj);

            //Confirm Alter
            _context.SaveChanges();
        }

        //Update Absence
        public void Update(Absence obj)
        {
            //Test if id exists
            if (!_context.ABSENCE.Any(x => x.ID == obj.ID))
            {
                throw new NotFoundException("Id not Found");
            }

            //Update Absence
            _context.Update(obj);

            //Save changes
            _context.SaveChanges();
        }
    }
}

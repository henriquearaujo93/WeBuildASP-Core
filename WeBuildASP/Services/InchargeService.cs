using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBuildASP.Models;
using WeBuildASP.Services.Exceptions;

namespace WeBuildASP.Services
{
    public class InchargeService
    {
        //Dependency for Context
        private readonly WeBuildASPContext _context;

        //Construct for dependency
        public InchargeService(WeBuildASPContext context)
        {
            _context = context;
        }

        //Return a list of Incharges
        public List<Incharge> FindAll()
        {
            return _context.INCHARGE.ToList();
        }

        //Method to insert Incharger
        public void Insert(Incharge incharge)
        {
            int lastId = _context.INCHARGE.Select(obj => obj.ID).Last(); //Load last incharge Id            
            
            //Increment new Incharge id to the last one
            incharge.IncrementId(lastId);

            _context.Add(incharge); //Add new incharge
            _context.SaveChanges(); //Save changes
        }

        //Method to find Incharge by Id
        public Incharge FindById(int id)
        {
            //return Incharge
            return _context.INCHARGE.FirstOrDefault(obj => obj.ID == id);
        }

        //Remove Incharge by id
        public void remove(int id)
        {
            var obj = _context.INCHARGE.Find(id);
            _context.INCHARGE.Remove(obj);

            //Confirm Alter
            _context.SaveChanges();
        }

        //Update Incharge
        public void Update(Incharge obj)
        {
            //Test if id exists
            if (!_context.INCHARGE.Any(x => x.ID == obj.ID))
            {
                throw new NotFoundException("Id not Found");
            }

            //Update Incharge
            _context.Update(obj);

            //Save changes
            _context.SaveChanges();
        }
    }
}

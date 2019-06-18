using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBuildASP.Models;
using WeBuildASP.Services.Exceptions;

namespace WeBuildASP.Services
{
    public class PresenceService
    {
        //Dependency for Context
        private readonly WeBuildASPContext _context;

        //Construct for dependency
        public PresenceService(WeBuildASPContext context)
        {
            _context = context;
        }

        //Return a list of Presences
        public List<Presence> FindAll()
        {
            return _context.PRESENCE.ToList();
        }

        //Method to insert Presence
        public void Insert(Presence presence)
        {
            int lastId = _context.PRESENCE.Select(obj => obj.ID).Last(); //Load last presence Id            

            //Increment new Presence id to the last one

            presence.IncrementId(lastId);

            _context.Add(presence); //Add new presence
            _context.SaveChanges(); //Save changes
        }

        //Method to find Presences by Id
        public Presence FindById(int id)
        {
            //return Presence
            return _context.PRESENCE.FirstOrDefault(obj => obj.ID == id);
        }

        //Remove Presence by id
        public void remove(int id)
        {
            var obj = _context.PRESENCE.Find(id);
            _context.PRESENCE.Remove(obj);

            //Confirm Alter
            _context.SaveChanges();
        }

        //Update Presences
        public void Update(Presence obj)
        {
            //Test if id exists
            if (!_context.PRESENCE.Any(x => x.ID == obj.ID))
            {
                throw new NotFoundException("Id not Found");
            }

            //Update Presence
            _context.Update(obj);

            //Save changes
            _context.SaveChanges();
        }
    }
}

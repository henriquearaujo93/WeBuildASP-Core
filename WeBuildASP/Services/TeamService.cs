using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBuildASP.Models;
using WeBuildASP.Services.Exceptions;

namespace WeBuildASP.Services
{

    public class TeamService
    {
        //Dependency for Context
        private readonly WeBuildASPContext _context;

        //Construct for dependency
        public TeamService(WeBuildASPContext context)
        {
            _context = context;
        }

        //Return a list of Teams
        public List<Team> FindAll()
        {
            return _context.TEAM.ToList();
        }

        //Method to insert Team
        public void Insert(Team team)
        {
            int lastId = _context.TEAM.Select(obj => obj.ID).Last(); //Load last incharge Id            

            //Increment new Team id to the last one
            team.IncrementId(lastId);

                _context.Add(team); //Add new team
            _context.SaveChanges(); //Save changes
        }

        //Method to find Team by Id
        public Team FindById(int id)
        {
            //return Team
            return _context.TEAM.FirstOrDefault(obj => obj.ID == id);
        }

        //Remove Team by Id
        public void remove(int id)
        {
            var obj = _context.TEAM.Find(id);
            _context.TEAM.Remove(obj);

            //Confirm Alter
            _context.SaveChanges();
        }

        //Update Teams
        public void Update(Team obj)
        {
            //Test if id exists
            if (!_context.TEAM.Any(x => x.ID == obj.ID))
            {
                throw new NotFoundException("Id not Found");
            }

            //Update Team
            _context.Update(obj);

            //Save changes
            _context.SaveChanges();
        }
    }
}
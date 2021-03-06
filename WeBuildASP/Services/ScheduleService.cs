﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBuildASP.Models;
using WeBuildASP.Services.Exceptions;

namespace WeBuildASP.Services
{
    public class ScheduleService
    {
        //Dependency for Context
        private readonly WeBuildASPContext _context;

        //Construct for dependency
        public ScheduleService(WeBuildASPContext context)
        {
            _context = context;
        }

        //Return a list of Schedules
        public List<Schedule> FindAll()
        {
            return _context.SCHEDULE.ToList();
        }

        //Method to insert new Schedule
        public void Insert(Schedule schedule)
        {
            int lastId = _context.SCHEDULE.Select(obj => obj.ID).Last(); //Load last Schedule Id            

            //Increment new Team id to the last one
            schedule.IncrementId(lastId);

            _context.Add(schedule); //Add new team
            _context.SaveChanges(); //Save changes
        }

        //Method to find Schedule by Id
        public Schedule FindById(int id)
        {
            //return Team
            return _context.SCHEDULE.FirstOrDefault(obj => obj.ID == id);
        }

        //Remove Schedule by Id
        public void remove(int id)
        {
            var obj = _context.SCHEDULE.Find(id);
            _context.SCHEDULE.Remove(obj);

            //Confirm Alter
            _context.SaveChanges();
        }

        //Update Schedules
        public void Update(Schedule obj)
        {
            //Test if id exists
            if (!_context.SCHEDULE.Any(x => x.ID == obj.ID))
            {
                throw new NotFoundException("Id not Found");
            }

            //Update Schedule
            _context.Update(obj);

            //Save changes
            _context.SaveChanges();
        }
    }
}

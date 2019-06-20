using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBuildASP.Models;

namespace WeBuildASP.Services
{
    public class StatisticService
    {
        //Dependency for Context
        private readonly WeBuildASPContext _context;

        //Construct for dependency
        public StatisticService(WeBuildASPContext context)
        {
            _context = context;
        }
    }
}

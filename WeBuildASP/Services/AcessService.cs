using System.Collections.Generic;
using System.Linq;
using WeBuildASP.Models;

namespace WeBuildASP.Services
{
    public class AcessService
    {
        //Dbcontext dependence
        private readonly WeBuildASPContext _context;

        //construtor para poder ocorrer instancia
        public AcessService(WeBuildASPContext context)
        {
            _context = context;
        }

        //Method to return all ACESS
        public List<Acess> FindAll()
        {
            return _context.ACESS.OrderBy(x => x.A_NAME).ToList();
        }



    }
}

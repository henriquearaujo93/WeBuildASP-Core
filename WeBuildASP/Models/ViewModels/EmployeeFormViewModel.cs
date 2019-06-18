using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models.ViewModels
{
    public class EmployeeFormViewModel
    {
        public Employee Employee { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}

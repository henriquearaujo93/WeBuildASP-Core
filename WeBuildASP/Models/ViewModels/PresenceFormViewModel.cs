using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models.ViewModels
{
    public class PresenceFormViewModel
    {
        public Presence Presence { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}

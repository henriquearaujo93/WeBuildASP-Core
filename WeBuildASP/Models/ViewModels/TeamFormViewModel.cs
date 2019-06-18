using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models.ViewModels
{
    public class TeamFormViewModel
    {
        public Team Team { get; set; }
        public ICollection<Incharge> Incharges { get; set; }
    }
}

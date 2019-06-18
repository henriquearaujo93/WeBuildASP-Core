using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models.ViewModels
{
    public class InchargeFormViewModel
    {
        public Incharge Incharge { get; set; }
        public ICollection<User> Users { get; set; }
    }
}

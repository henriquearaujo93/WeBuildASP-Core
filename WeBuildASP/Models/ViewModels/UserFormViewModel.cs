using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models.ViewModels
{
    public class UserFormViewModel
    {
        public User User { get; set; }
        public ICollection<Acess> Acess { get; set; }
    }
}

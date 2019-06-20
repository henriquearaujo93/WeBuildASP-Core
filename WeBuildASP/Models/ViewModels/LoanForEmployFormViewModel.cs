using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models.ViewModels
{
    public class LoanForEmployFormViewModel
    {
        public LoanForEmploy LoanForEmploy { get; set; }
        public ICollection<Employee> Employs { get; set; }
    }
}

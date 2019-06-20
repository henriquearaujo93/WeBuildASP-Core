using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models
{
    public class Absence
    {
        [DisplayName("Id")]
        public int ID { get; set; }
        [DisplayName("Date")]
        public DateTime? Ab_Date { get; set; }
        [DisplayName("Is Justify")]
        public bool Ab_Justify { get; set; }
        [DisplayName("Employ")]
        public int Ab_IdEmploy { get; set; }
        public static int Count { get; set; }

        public Absence() { }

        public Absence(int id, DateTime date, bool justify, int employ)
        {
            this.ID = id;
            this.Ab_Date = date;
            this.Ab_Justify = justify;
            this.Ab_IdEmploy = employ;
            Count++;
        }

    }
}

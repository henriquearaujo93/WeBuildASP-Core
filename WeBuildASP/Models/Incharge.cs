using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models
{
    public class Incharge
    {
        [DisplayName("Id")]
        public int ID { get; set; }
        [DisplayName("Name")]
        public string I_NAME { get; set; }
        [DisplayName("Last Name")]
        public string I_LASTNAME { get; set; }
        [DisplayName("Active")]
        public bool I_ACTIVE { get; set; }
        [DisplayName("User Id")]
        public int I_USER { get; set; }
        public static int Count { get; set; }

        public Incharge() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id of the incharge</param>
        /// <param name="name">name of the Incharge</param>
        /// <param name="lastName">last name of the user</param>
        /// <param name="active">If the incharge is active or not</param>
        public Incharge(int id, string name, string lastName, bool active)
        {
            this.ID = id;
            this.I_NAME = name;
            this.I_LASTNAME = lastName;
            this.I_ACTIVE = active;
            Count++;
        }

        //Method to increment incharge id
        public void IncrementId()
        {
            this.ID += 1;
        }

        //Method to increment Incharge id with last id
        public void IncrementId(int lastId)
        {
            this.ID = lastId + 1;
        }
    }
}

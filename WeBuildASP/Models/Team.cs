using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models
{
    public class Team
    {
        [DisplayName("Id")]
        public int ID { get; set; }
        [DisplayName("Country")]
        public string T_COUNTRY { get; set; }
        [DisplayName("Incharge")]
        public int T_INCHAR { get; set; }
        [DisplayName("Active")]
        public bool T_ACTIVE { get; set; }
        public static int Count { get; set; }
        public Team() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id of the Team</param>
        /// <param name="country">country of the Team</param>
        /// <param name="incharge">Incharge of the team</param>
        /// <param name="active">If the team is active or not</param>
        public Team(int id, string country, Incharge incharge, bool active)
        {
            this.ID = id;
            this.T_COUNTRY = country;
            this.T_INCHAR = incharge.ID;
            this.T_ACTIVE = active;
            Count++;
        }

        //Method to increment Team id
        public void IncrementId()
        {
            this.ID += 1;
        }

        //Method to increment Team id with last id
        public void IncrementId(int lastId)
        {
            this.ID = lastId + 1;
        }
    }
}

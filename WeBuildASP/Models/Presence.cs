using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models
{
    public class Presence
    {
        [DisplayName("Id")]
        public int ID { get; set; }
        [DisplayName("Entry")]
        public DateTime? P_REGISTERENTRY { get; set; }
        [DisplayName("Out")]
        public DateTime? P_REGISTEROUT { get; set; }
        [DisplayName("Entry Lounch")]
        public DateTime? P_REGISTERENTRYLUNCH { get; set; }
        [DisplayName("Out Lounch")]
        public DateTime? P_REGISTEROUTLUNCH { get; set; }
        [DisplayName("Employ")]
        public int P_EMPLOY { get; set; }
        public static int Count { get; set; }

        public Presence() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id of the Presence</param>
        /// <param name="registerEntry">date entry of the employe</param>
        /// <param name="registerOut">date Out of the employe</param>
        /// <param name="entryLounch">date entry lunch of the employe</param>
        /// <param name="outLounch">date of out lunch of the employe</param>
        public Presence(int id, DateTime registerEntry, DateTime registerOut, DateTime entryLounch, DateTime outLounch)
        {
            this.ID = id;
            this.P_REGISTERENTRY = registerEntry;
            this.P_REGISTEROUT = registerOut;
            this.P_REGISTERENTRYLUNCH = entryLounch;
            this.P_REGISTEROUTLUNCH = outLounch;
            Count++;
        }

        //Method to increment presence id
        public void IncrementId()
        {
            this.ID += 1;
        }

        //Method to increment presence id with last id
        public void IncrementId(int lastId)
        {
            this.ID = lastId + 1;
        }
    }
}
